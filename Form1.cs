using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TimeZoneConverter;

namespace Weather
{
    public partial class Form1 : Form
    {
        private List<string> searchHistoryList = new List<string>();
        private Stack<string> searchHistoryStack = new Stack<string>();

        private string localTimeZone = TimeZoneInfo.Local.ToString();
        private int spamPreventionCounter = 0;
        public Form1()
        {
            InitializeComponent();

            //При стартиране на приложението зарежда данните за града София, за да може приложението да не е празно.
            LoadData("Sofia");

            // Стартира таймера, който ще обновява часът на всяка секунда
            localTimeTimer.Enabled = true;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Проста проверка да не се спами искания към API-то
            if (spamPreventionCounter > 10)
            {
                MessageBox.Show("You are searching too fast. Please wait a few seconds before searching again.");
                spamPrevention.Enabled = true;
            }
            else
            {
                // При успешен достъп до тук. Извиква метода LoadData с града изписан в текстовото поле.
                if (!string.IsNullOrEmpty(tbSearch.Text))
                { 
                    await Task.Run(() => LoadData(tbSearch.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a city name.");
                }
            }
            
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            /*string history = "Последни Търсени градове:\n" + string.Join("\n", searchHistory.Reverse());
            MessageBox.Show(history, "История");*/
            var historyForm = new History(searchHistoryList, searchHistoryStack);
            historyForm.LastCitySelected += city =>
            {
                LoadData(city);
            };
            historyForm.ShowDialog();
        }
        // API ключ, който приложението използва да прави искания към API-то
        public string weatherAPIKey = "";
        private async void LoadData(string placeName)
        {
            spamPreventionCounter++;
            // Използва using, за да се уверя, че ресурсите се освобождават след като приключи изпълнението на метода.
            using (HttpClient client = new HttpClient())
            {
                try{
                    // Извиква API-то за информация на астрономията на определен град. Тук взима данните за изгрева и залеза на слънцето
                    string url = string.Format("https://api.weatherapi.com/v1/astronomy.json?key={0}&q={1}&dt={2}", weatherAPIKey, placeName, DateTime.Now.ToString("yyyy-MM-dd"));
                    var json = await client.GetStringAsync(url).ConfigureAwait(false);
                    // Десериализира JSON обекта в динамична променлива, която създава динамично обекта astronomyData.
                    dynamic astronomyData = JsonConvert.DeserializeObject<dynamic>(json);


                    // Извиква API-то за информация за времето на определен град. Тук взима данните за текущото време, часовата зона и дните
                    url = string.Format("https://api.weatherapi.com/v1/forecast.json?key={0}&q={1}&days=6", weatherAPIKey, placeName);
                    json = await client.GetStringAsync(url).ConfigureAwait(false);
                    // Десериализира JSON обекта в динамична променлива, която създава динамично обекта weatheData.
                    dynamic weatherData = JsonConvert.DeserializeObject<dynamic>(json);

                    // Използва TZConvert от библиотеката TimeZoneConverter за да конвертира часовата зона от IANA в Windows
                    localTimeZone = TZConvert.IanaToWindows(weatherData.location.tz_id.Value);

                    // Извиква методите, които зареждат данните във визуалната среда на приложението.
                    LoadCurrentWeatherData(weatherData, astronomyData, weatherData);

                    LoadHourlyWeatherData(weatherData);

                    LoadDailyWeatherData(weatherData);

                    // Стартира таймера, който ще обновява часът на всяка секунда
                }
                catch (Exception x)
                {
                    // Ако градът не съществува.
                    MessageBox.Show("Error: This city does not exist");
                }
            }
            searchHistoryList.Add(placeName);
            searchHistoryStack.Push(placeName);
        }
        private void LoadCurrentWeatherData(dynamic currentWeatherData, dynamic astronomyData, dynamic forecastWeatherData)
        {
                Invoke(new Action(() =>
                {
                    // Взима данните за текущото време от API-то и ги изписва във визуалната среда
                    lblCurrentWeather.Text = "Current Weather";
                    lblLocalTime.Text = "Local Time";
                    lblSunrise.Text = "Sunrise";
                    lblSunset.Text = "Sunset";
                    lblHumidity.Text = "Humidity";
                    lblChanceOfRain.Text = "Chance of rain";
                    lblRain.Text = "Rain";
                    lblWindSpeed.Text = "Wind Speed";
                    lblWindDirection.Text = "Wind Direction";
                    lblGust.Text = "Gust";
                    lblCloud.Text = "Cloud";
                    lblPressure.Text = "Pressure";

                    lblTempCelsius.Text = Math.Round(currentWeatherData.current.temp_c.Value).ToString() + "°C"; 
                    pbCurrentCondition.Load(GetImageWebAddress(currentWeatherData.current.condition.icon.Value));
                    lblPlaceCity.Text = currentWeatherData.location.name + ",";
                    lblPlaceCountry.Text = currentWeatherData.location.country;
                    lblApparentTempC.Text = "Feels Like " + Math.Round(currentWeatherData.current.feelslike_c.Value).ToString() + "°C";
                    lblWeatherDescription.Text = currentWeatherData.current.condition.text;
                    lblHumidityData.Text = currentWeatherData.current.humidity.ToString() + "%";
                    lblRainData.Text = currentWeatherData.current.precip_mm.ToString() + " mm"; ;
                    lblWindSpeedData.Text = Math.Round(currentWeatherData.current.wind_kph.Value * 0.277778).ToString() + " m/s";
                    lblWindDirectionData.Text = currentWeatherData.current.wind_dir;
                    lblGustData.Text = Math.Round(currentWeatherData.current.gust_kph.Value * 0.277778).ToString() + " m/s";
                    lblCloudData.Text = currentWeatherData.current.cloud.ToString() + "%";
                    lblPressureData.Text = currentWeatherData.current.pressure_mb.ToString() + " hPa";
                    lblSunrise.Text = "Sunrise " + astronomyData.astronomy.astro.sunrise;
                    lblSunset.Text = "Sunset " + astronomyData.astronomy.astro.sunset;
                    if (forecastWeatherData.forecast.forecastday[0].day.daily_will_it_snow == 1 || forecastWeatherData.forecast.forecastday[0].day.daily_chance_of_snow > 50)
                    {
                        lblChanceOfRain.Text = "Chance of Snow";
                        lblChanceOfRainData.Text = forecastWeatherData.forecast.forecastday[0].day.daily_chance_of_snow.ToString() + "%";
                    }
                    else
                    {
                        lblChanceOfRain.Text = "Chance of Rain";
                        lblChanceOfRainData.Text = forecastWeatherData.forecast.forecastday[0].day.daily_chance_of_rain.ToString() + "%";
                    }
                }));
        }

        private async void LoadHourlyWeatherData(dynamic hourlyForecastWeatherData)
        {
            await Task.Run(() =>
            {
                // Създава променлива в DateTime формат, която записва в себе си локалното време в града взето от API-то.
                DateTime now = hourlyForecastWeatherData.location.localtime;

                // Взима часа от локалното време и го използва за начален индекс на прогнозата за времето.
                int startIndex = int.Parse(now.ToString("HH")) + 1;

                int _xPos = 0;

                Invoke(new Action(() =>
                {
                    // Изчиства всички контроли от панела hourlyPanel, ако случайно има такива, за да може да ги заредим отново.
                    hourlyPanel.Controls.Clear();

                    // Цикъл, който създава TableLayoutPanel-и за всеки час от прогнозата за времето
                    for (int j = startIndex; j < 24; j++)
                    {
                        // Създава TableLayoutPanel, който използва за форматиране на данните във визуалната среда.
                        TableLayoutPanel tlpHourly = new TableLayoutPanel
                        {
                            ColumnCount = 1,
                            RowCount = 7,
                            Size = new Size(158, 264),
                            Location = new Point(_xPos, 58)
                        };
                        // Създава стилове за редовете на TableLayoutPanel
                        for (int i = 0; i < tlpHourly.RowCount; i++)
                        {
                            tlpHourly.RowStyles.Add(new RowStyle());
                        }

                        // Задава размерите на редовете на TableLayoutPanel
                        for (int i = 0; i < tlpHourly.RowCount; i++)
                        {
                            if (i == 1)
                            {
                                tlpHourly.RowStyles[i].SizeType = SizeType.Absolute;
                                tlpHourly.RowStyles[i].Height = 100;
                            }
                            else if (i == 0 || i == 2)
                            {
                                tlpHourly.RowStyles[i].SizeType = SizeType.Absolute;
                                tlpHourly.RowStyles[i].Height = 25;
                            }
                        }

                        // Създава обект Label, който използва за изписване на часа на времето.
                        Label lblHourlyTime = new Label
                        {
                            Text = hourlyForecastWeatherData.forecast.forecastday[0].hour[j].time.ToString().Split(' ')[1],
                            Font = new Font("Arial", 12),
                            ForeColor = Color.White,
                            Margin = new Padding(3, 0, 3, 0),
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Създава обект PictureBox, който използва за изобразяване на иконата на времето получено от API-то.
                        PictureBox pbHourlyCondition = new PictureBox
                        {
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Anchor = AnchorStyles.Top | AnchorStyles.Left,
                            Margin = new Padding(0, 3, 0, 3),
                            Dock = DockStyle.Fill
                        };
                        // Зарежда иконата на времето в PictureBox
                        pbHourlyCondition.Load(GetImageWebAddress(hourlyForecastWeatherData.forecast.forecastday[0].hour[j].condition.icon.Value));

                        // Създава обект Label, който използва за изписване на температурата на времето.
                        Label lblHourlyTemp = new Label
                        {
                            Text = Math.Round(hourlyForecastWeatherData.forecast.forecastday[0].hour[j].temp_c.Value) + "°C",
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            Margin = new Padding(0, 3, 0, 3),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Създава обект Label, който използва за изписване на описание на времето.
                        Label lblHourlyDescription = new Label
                        {
                            Text = hourlyForecastWeatherData.forecast.forecastday[0].hour[j].condition.text.Value,
                            Font = new Font("Arial", 12),
                            Margin = new Padding(0, 3, 0, 3),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Създава обект Label, който използва за изписване на вероятността за дъжд или сняг.
                        Label lblHourlyRainChance = new Label
                        {
                            Text = hourlyForecastWeatherData.forecast.forecastday[0].hour[j].will_it_snow == 1 || hourlyForecastWeatherData.forecast.forecastday[0].hour[j].chance_of_snow > 50
                                ? "Snow - " + hourlyForecastWeatherData.forecast.forecastday[0].hour[j].chance_of_snow.Value + "%"
                                : "Rain - " + hourlyForecastWeatherData.forecast.forecastday[0].hour[j].chance_of_rain.Value + "%",
                            Font = new Font("Arial", 10),
                            Margin = new Padding(0, 3, 0, 3),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Създава обект Label, който използва за изписване на скоростта на вятъра.
                        Label lblHourlyWindSpeed = new Label
                        {
                            Text = "Wind Speed - " + Math.Round(hourlyForecastWeatherData.forecast.forecastday[0].hour[j].wind_kph.Value * 0.277778) + " m/s",
                            Font = new Font("Arial", 10),
                            Margin = new Padding(0, 3, 0, 3),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.TopCenter
                        };

                        // Създава обект Label, който използва за изписване на усещането на температурата.
                        Label lblHourlyFeelsLike_C = new Label
                        {
                            Text = "Feels like - " + Math.Round(hourlyForecastWeatherData.forecast.forecastday[0].hour[j].feelslike_c.Value * 0.277778) + "°C",
                            Font = new Font("Arial", 10),
                            Margin = new Padding(0, 3, 0, 3),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.TopCenter
                        };

                        // Добавя всички обекти в TableLayoutPanel
                        tlpHourly.Controls.Add(lblHourlyTime, 0, 0);
                        tlpHourly.Controls.Add(pbHourlyCondition, 0, 1);
                        tlpHourly.Controls.Add(lblHourlyTemp, 0, 2);
                        tlpHourly.Controls.Add(lblHourlyFeelsLike_C, 0, 3);
                        tlpHourly.Controls.Add(lblHourlyDescription, 0, 4);
                        tlpHourly.Controls.Add(lblHourlyRainChance, 0, 5);
                        tlpHourly.Controls.Add(lblHourlyWindSpeed, 0, 6);

                        // Добавя TableLayoutPanel в панела hourlyPanel
                        hourlyPanel.Controls.Add(tlpHourly);

                        // Увеличава позицията на следващия TableLayoutPanel
                        _xPos += 156;
                    }
                }));
            });
        }
        private async void LoadDailyWeatherData(dynamic dailyForecastWeatherData)
        {
            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    lblHourlyWeather.Text = "Hourly Weather";
                    // Изчиства всички контроли от панела dailyPanel, без tbSearch и btnSearch.
                    for (int i = dailyPanel.Controls.Count - 1; i >= 0; i--)
                    {
                        Control ctrl = dailyPanel.Controls[i];
                        if (ctrl.Tag != "1")
                        {
                            dailyPanel.Controls.Remove(ctrl);
                            ctrl.Dispose();
                        }
                    }

                    // Променлива, която използва за позициониране на TableLayoutPanel-ите в панела dailyPanel
                    int _yPos = 35;

                    // Цикъл, който създава TableLayoutPanel-и за всеки ден от прогнозата за времето
                    for (int j = 0; j < 3; j++)
                    {
                        // Създава TableLayoutPanel-и за всеки ден от прогнозата за времето
                        TableLayoutPanel tlpDaily = new TableLayoutPanel
                        {
                            RowCount = 1,
                            ColumnCount = 4,
                            Size = new Size(475, 100),
                            Location = new Point(11, _yPos),
                        };

                        // Създава стилове за всички колони на TableLayoutPanel
                        for (int i = 0; i < tlpDaily.ColumnCount; i++)
                        {
                            tlpDaily.ColumnStyles.Add(new ColumnStyle());
                        }

                        // Задава размерите на колоните на TableLayoutPanel
                        for (int i = 0; i < tlpDaily.ColumnCount; i++)
                        {
                            tlpDaily.ColumnStyles[i].SizeType = SizeType.Percent;
                            tlpDaily.ColumnStyles[i].Width = 20;
                        }

                        // Създава обект Label, който използва за изписване на деня от седмицата.
                        Label lblDay = new Label
                        {
                            Text = GetDayofWeekFromDateString(dailyForecastWeatherData.forecast.forecastday[j].date.Value),
                            Font = new Font("Arial", 11, FontStyle.Bold),
                            Margin = new Padding(3, 0, 3, 0),
                            ForeColor = Color.White,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        // Създава обект Label, който използва за изписване на вероятността за дъжд или сняг.
                        Label lblDailyRainChance = new Label
                        {
                            Text = dailyForecastWeatherData.forecast.forecastday[j].chance_of_snow > 0
                                ? "Snow - " + dailyForecastWeatherData.forecast.forecastday[j].day.daily_chance_of_snow.Value + "%"
                                : "Rain - " + dailyForecastWeatherData.forecast.forecastday[j].day.daily_chance_of_rain.Value + "%",
                            Font = new Font("Arial", 10),
                            Margin = new Padding(3, 0, 3, 0),
                            ForeColor = Color.White,
                        };

                        // Създава обект Label, който използва за изписване на описание на времето.
                        Label lblDailyConditionText = new Label
                        {
                            Text = dailyForecastWeatherData.forecast.forecastday[j].day.condition.text.Value,
                            Font = new Font("Arial", 10),
                            Margin = new Padding(3, 0, 3, 0),
                            ForeColor = Color.White,
                        };

                        // Създава обект PictureBox, който използва за изобразяване на иконата на времето получено от API-то.
                        PictureBox imageBox = new PictureBox
                        {
                            Margin = new Padding(3, 0, 3, 0),
                            Dock = DockStyle.Fill,
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        // Зарежда иконата на времето в PictureBox
                        imageBox.Load(GetImageWebAddress(dailyForecastWeatherData.forecast.forecastday[j].day.condition.icon.Value));

                        // Създава обект Label, който използва за изписване на максималната за деня.
                        Label maxTempLabel = new Label
                        {
                            Text = Math.Round(dailyForecastWeatherData.forecast.forecastday[j].day.maxtemp_c.Value) + "°C",
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            Margin = new Padding(3, 0, 3, 0),
                            ForeColor = Color.White
                        };

                        // Създава обект Label, който използва за изписване на минималната за деня.
                        Label minTempLabel = new Label
                        {
                            Text = Math.Round(dailyForecastWeatherData.forecast.forecastday[j].day.mintemp_c.Value) + "°C",
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            Margin = new Padding(3, 0, 3, 0),
                            ForeColor = Color.White
                        };

                        // Създава Panel, който използва за позициониране на обектите в TableLayoutPanel
                        Panel dailyConditionPanel = new Panel
                        {
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Margin = new Padding(3, 25, 0, 0)
                        };
                        // Позиционира обектите в обект от тип Panel
                        lblDailyRainChance.Top = maxTempLabel.Bottom + 5;
                        dailyConditionPanel.Controls.Add(lblDailyConditionText);
                        dailyConditionPanel.Controls.Add(lblDailyRainChance);

                        // Създава Panel, който използва за позициониране на обектите в TableLayoutPanel
                        Panel dailyTempPanel = new Panel
                        {
                            AutoSize = true,
                            Dock = DockStyle.Fill,
                            Margin = new Padding(0, 25, 3, 0)
                        };
                        // Позиционира обектите в обект от тип Panel
                        minTempLabel.Top = maxTempLabel.Bottom + 5;
                        dailyTempPanel.Controls.Add(maxTempLabel);
                        dailyTempPanel.Controls.Add(minTempLabel);

                        // Добавя всички обекти в TableLayoutPanel
                        tlpDaily.Controls.Add(lblDay, 0, 0);
                        tlpDaily.Controls.Add(dailyConditionPanel, 1, 0);
                        tlpDaily.Controls.Add(imageBox, 2, 0);
                        tlpDaily.Controls.Add(dailyTempPanel, 3, 0);

                        // Добавя TableLayoutPanel в панела dailyPanel
                        dailyPanel.Controls.Add(tlpDaily);

                        // Увеличава позицията на следващия TableLayoutPanel
                        _yPos += 100;
                    }
                }));
            });
        }
        public string GetImageWebAddress(string icon)
        {
            icon = Regex.Replace(icon, @"//cdn\.weatherapi\.com/weather/64x64", "");
            string link = "https://cdn.weatherapi.com/weather/128x128"+icon;
            return link;
        }
        public string GetDayofWeekFromDateString(string dateString)
        {
            // Преобразува датата от стринг в DateTime и връща деня от седмицата
            DateTime date = DateTime.Parse(dateString);
            return date.DayOfWeek.ToString();
        }

        private void localTimeTimer_Tick(object sender, EventArgs e)
        {
            // Update the local time every second
            // Обновяваме времето на всяка секунда от часовата зона UTC
            DateTime utcNow = DateTime.UtcNow;
            // Взимаме променливата която зададохме по-рано за часовата зона на локалното време в определеният и я търсим използвайки Windows 
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(localTimeZone);
            lblLocalTimeData.Text = TimeZoneInfo.ConvertTimeFromUtc(utcNow, timeZone).ToString("HH:mm:ss");
        }

        private void spamPrevention_Tick(object sender, EventArgs e)
        {
            // След 10 секунди се нулира брояча за спам и може да се търси отново.
            spamPreventionCounter = 0;
        }

        
    }
}

