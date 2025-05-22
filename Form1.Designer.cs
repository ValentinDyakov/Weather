namespace Weather
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            currentPanel = new Panel();
            lblLocalTimeData = new Label();
            lblLocalTime = new Label();
            lblPlaceCountry = new Label();
            lblSunset = new Label();
            lblSunrise = new Label();
            panel2 = new Panel();
            lblCloudData = new Label();
            lblGustData = new Label();
            lblCloud = new Label();
            lblWindDirectionData = new Label();
            lblWindSpeedData = new Label();
            lblWindDirection = new Label();
            lblGust = new Label();
            lblWindSpeed = new Label();
            panel1 = new Panel();
            lblPressureData = new Label();
            lblPressure = new Label();
            lblRainData = new Label();
            lblChanceOfRainData = new Label();
            lblHumidityData = new Label();
            lblChanceOfRain = new Label();
            lblRain = new Label();
            lblHumidity = new Label();
            lblPlaceCity = new Label();
            lblApparentTempC = new Label();
            lblWeatherDescription = new Label();
            lblTempCelsius = new Label();
            pbCurrentCondition = new PictureBox();
            lblCurrentWeather = new Label();
            hourlyPanel = new Panel();
            dailyPanel = new Panel();
            btnHistory = new Button();
            tbSearch = new TextBox();
            btnSearch = new Button();
            localTimeTimer = new System.Windows.Forms.Timer(components);
            lblHourlyWeather = new Label();
            spamPrevention = new System.Windows.Forms.Timer(components);
            currentPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCurrentCondition).BeginInit();
            dailyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // currentPanel
            // 
            currentPanel.BackColor = SystemColors.MenuHighlight;
            currentPanel.Controls.Add(lblLocalTimeData);
            currentPanel.Controls.Add(lblLocalTime);
            currentPanel.Controls.Add(lblPlaceCountry);
            currentPanel.Controls.Add(lblSunset);
            currentPanel.Controls.Add(lblSunrise);
            currentPanel.Controls.Add(panel2);
            currentPanel.Controls.Add(panel1);
            currentPanel.Controls.Add(lblPlaceCity);
            currentPanel.Controls.Add(lblApparentTempC);
            currentPanel.Controls.Add(lblWeatherDescription);
            currentPanel.Controls.Add(lblTempCelsius);
            currentPanel.Controls.Add(pbCurrentCondition);
            currentPanel.Controls.Add(lblCurrentWeather);
            currentPanel.Location = new Point(5, 6);
            currentPanel.Margin = new Padding(4, 3, 4, 3);
            currentPanel.Name = "currentPanel";
            currentPanel.Size = new Size(881, 315);
            currentPanel.TabIndex = 2;
            // 
            // lblLocalTimeData
            // 
            lblLocalTimeData.AutoSize = true;
            lblLocalTimeData.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLocalTimeData.ForeColor = Color.White;
            lblLocalTimeData.Location = new Point(0, 284);
            lblLocalTimeData.Margin = new Padding(4, 0, 4, 0);
            lblLocalTimeData.Name = "lblLocalTimeData";
            lblLocalTimeData.Size = new Size(0, 18);
            lblLocalTimeData.TabIndex = 26;
            // 
            // lblLocalTime
            // 
            lblLocalTime.AutoSize = true;
            lblLocalTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLocalTime.ForeColor = Color.White;
            lblLocalTime.Location = new Point(0, 255);
            lblLocalTime.Margin = new Padding(4, 0, 4, 0);
            lblLocalTime.Name = "lblLocalTime";
            lblLocalTime.Size = new Size(0, 18);
            lblLocalTime.TabIndex = 25;
            // 
            // lblPlaceCountry
            // 
            lblPlaceCountry.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaceCountry.ForeColor = SystemColors.Control;
            lblPlaceCountry.Location = new Point(184, 273);
            lblPlaceCountry.Margin = new Padding(4, 0, 4, 0);
            lblPlaceCountry.Name = "lblPlaceCountry";
            lblPlaceCountry.Size = new Size(317, 31);
            lblPlaceCountry.TabIndex = 24;
            // 
            // lblSunset
            // 
            lblSunset.AutoSize = true;
            lblSunset.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSunset.ForeColor = Color.White;
            lblSunset.Location = new Point(181, 127);
            lblSunset.Margin = new Padding(4, 0, 4, 0);
            lblSunset.Name = "lblSunset";
            lblSunset.Size = new Size(0, 18);
            lblSunset.TabIndex = 23;
            // 
            // lblSunrise
            // 
            lblSunrise.AutoSize = true;
            lblSunrise.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSunrise.ForeColor = Color.White;
            lblSunrise.Location = new Point(181, 98);
            lblSunrise.Margin = new Padding(4, 0, 4, 0);
            lblSunrise.Name = "lblSunrise";
            lblSunrise.Size = new Size(0, 18);
            lblSunrise.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCloudData);
            panel2.Controls.Add(lblGustData);
            panel2.Controls.Add(lblCloud);
            panel2.Controls.Add(lblWindDirectionData);
            panel2.Controls.Add(lblWindSpeedData);
            panel2.Controls.Add(lblWindDirection);
            panel2.Controls.Add(lblGust);
            panel2.Controls.Add(lblWindSpeed);
            panel2.Location = new Point(676, 8);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 297);
            panel2.TabIndex = 21;
            // 
            // lblCloudData
            // 
            lblCloudData.AutoSize = true;
            lblCloudData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCloudData.ForeColor = SystemColors.Control;
            lblCloudData.Location = new Point(4, 246);
            lblCloudData.Margin = new Padding(4, 0, 4, 0);
            lblCloudData.Name = "lblCloudData";
            lblCloudData.Size = new Size(0, 19);
            lblCloudData.TabIndex = 24;
            // 
            // lblGustData
            // 
            lblGustData.AutoSize = true;
            lblGustData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGustData.ForeColor = SystemColors.Control;
            lblGustData.Location = new Point(1, 182);
            lblGustData.Margin = new Padding(4, 0, 4, 0);
            lblGustData.Name = "lblGustData";
            lblGustData.Size = new Size(0, 19);
            lblGustData.TabIndex = 20;
            // 
            // lblCloud
            // 
            lblCloud.AutoSize = true;
            lblCloud.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCloud.ForeColor = SystemColors.Control;
            lblCloud.Location = new Point(4, 216);
            lblCloud.Margin = new Padding(4, 0, 4, 0);
            lblCloud.Name = "lblCloud";
            lblCloud.Size = new Size(0, 16);
            lblCloud.TabIndex = 23;
            // 
            // lblWindDirectionData
            // 
            lblWindDirectionData.AutoSize = true;
            lblWindDirectionData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWindDirectionData.ForeColor = SystemColors.Control;
            lblWindDirectionData.Location = new Point(1, 119);
            lblWindDirectionData.Margin = new Padding(4, 0, 4, 0);
            lblWindDirectionData.Name = "lblWindDirectionData";
            lblWindDirectionData.Size = new Size(0, 19);
            lblWindDirectionData.TabIndex = 19;
            // 
            // lblWindSpeedData
            // 
            lblWindSpeedData.AutoSize = true;
            lblWindSpeedData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWindSpeedData.ForeColor = SystemColors.Control;
            lblWindSpeedData.Location = new Point(1, 55);
            lblWindSpeedData.Margin = new Padding(4, 0, 4, 0);
            lblWindSpeedData.Name = "lblWindSpeedData";
            lblWindSpeedData.Size = new Size(0, 19);
            lblWindSpeedData.TabIndex = 18;
            // 
            // lblWindDirection
            // 
            lblWindDirection.AutoSize = true;
            lblWindDirection.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWindDirection.ForeColor = SystemColors.Control;
            lblWindDirection.Location = new Point(1, 89);
            lblWindDirection.Margin = new Padding(4, 0, 4, 0);
            lblWindDirection.Name = "lblWindDirection";
            lblWindDirection.Size = new Size(0, 16);
            lblWindDirection.TabIndex = 17;
            // 
            // lblGust
            // 
            lblGust.AutoSize = true;
            lblGust.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGust.ForeColor = SystemColors.Control;
            lblGust.Location = new Point(1, 151);
            lblGust.Margin = new Padding(4, 0, 4, 0);
            lblGust.Name = "lblGust";
            lblGust.Size = new Size(0, 16);
            lblGust.TabIndex = 16;
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWindSpeed.ForeColor = SystemColors.Control;
            lblWindSpeed.Location = new Point(1, 25);
            lblWindSpeed.Margin = new Padding(4, 0, 4, 0);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(0, 16);
            lblWindSpeed.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPressureData);
            panel1.Controls.Add(lblPressure);
            panel1.Controls.Add(lblRainData);
            panel1.Controls.Add(lblChanceOfRainData);
            panel1.Controls.Add(lblHumidityData);
            panel1.Controls.Add(lblChanceOfRain);
            panel1.Controls.Add(lblRain);
            panel1.Controls.Add(lblHumidity);
            panel1.Location = new Point(505, 8);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 297);
            panel1.TabIndex = 19;
            // 
            // lblPressureData
            // 
            lblPressureData.AutoSize = true;
            lblPressureData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPressureData.ForeColor = SystemColors.Control;
            lblPressureData.Location = new Point(4, 246);
            lblPressureData.Margin = new Padding(4, 0, 4, 0);
            lblPressureData.Name = "lblPressureData";
            lblPressureData.Size = new Size(0, 19);
            lblPressureData.TabIndex = 22;
            // 
            // lblPressure
            // 
            lblPressure.AutoSize = true;
            lblPressure.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPressure.ForeColor = SystemColors.Control;
            lblPressure.Location = new Point(4, 216);
            lblPressure.Margin = new Padding(4, 0, 4, 0);
            lblPressure.Name = "lblPressure";
            lblPressure.Size = new Size(0, 16);
            lblPressure.TabIndex = 21;
            // 
            // lblRainData
            // 
            lblRainData.AutoSize = true;
            lblRainData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRainData.ForeColor = SystemColors.Control;
            lblRainData.Location = new Point(2, 182);
            lblRainData.Margin = new Padding(4, 0, 4, 0);
            lblRainData.Name = "lblRainData";
            lblRainData.Size = new Size(0, 19);
            lblRainData.TabIndex = 20;
            // 
            // lblChanceOfRainData
            // 
            lblChanceOfRainData.AutoSize = true;
            lblChanceOfRainData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChanceOfRainData.ForeColor = SystemColors.Control;
            lblChanceOfRainData.Location = new Point(2, 119);
            lblChanceOfRainData.Margin = new Padding(4, 0, 4, 0);
            lblChanceOfRainData.Name = "lblChanceOfRainData";
            lblChanceOfRainData.Size = new Size(0, 19);
            lblChanceOfRainData.TabIndex = 19;
            // 
            // lblHumidityData
            // 
            lblHumidityData.AutoSize = true;
            lblHumidityData.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHumidityData.ForeColor = SystemColors.Control;
            lblHumidityData.Location = new Point(2, 55);
            lblHumidityData.Margin = new Padding(4, 0, 4, 0);
            lblHumidityData.Name = "lblHumidityData";
            lblHumidityData.Size = new Size(0, 19);
            lblHumidityData.TabIndex = 18;
            // 
            // lblChanceOfRain
            // 
            lblChanceOfRain.AutoSize = true;
            lblChanceOfRain.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChanceOfRain.ForeColor = SystemColors.Control;
            lblChanceOfRain.Location = new Point(2, 89);
            lblChanceOfRain.Margin = new Padding(4, 0, 4, 0);
            lblChanceOfRain.Name = "lblChanceOfRain";
            lblChanceOfRain.Size = new Size(0, 16);
            lblChanceOfRain.TabIndex = 17;
            // 
            // lblRain
            // 
            lblRain.AutoSize = true;
            lblRain.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRain.ForeColor = SystemColors.Control;
            lblRain.Location = new Point(2, 152);
            lblRain.Margin = new Padding(4, 0, 4, 0);
            lblRain.Name = "lblRain";
            lblRain.Size = new Size(0, 16);
            lblRain.TabIndex = 16;
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHumidity.ForeColor = SystemColors.Control;
            lblHumidity.Location = new Point(2, 25);
            lblHumidity.Margin = new Padding(4, 0, 4, 0);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(0, 16);
            lblHumidity.TabIndex = 15;
            // 
            // lblPlaceCity
            // 
            lblPlaceCity.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaceCity.ForeColor = SystemColors.Control;
            lblPlaceCity.Location = new Point(181, 245);
            lblPlaceCity.Margin = new Padding(4, 0, 4, 0);
            lblPlaceCity.Name = "lblPlaceCity";
            lblPlaceCity.Size = new Size(317, 31);
            lblPlaceCity.TabIndex = 18;
            // 
            // lblApparentTempC
            // 
            lblApparentTempC.AutoSize = true;
            lblApparentTempC.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApparentTempC.ForeColor = SystemColors.Control;
            lblApparentTempC.Location = new Point(181, 70);
            lblApparentTempC.Margin = new Padding(4, 0, 4, 0);
            lblApparentTempC.Name = "lblApparentTempC";
            lblApparentTempC.Size = new Size(0, 16);
            lblApparentTempC.TabIndex = 4;
            // 
            // lblWeatherDescription
            // 
            lblWeatherDescription.AutoSize = true;
            lblWeatherDescription.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWeatherDescription.ForeColor = Color.White;
            lblWeatherDescription.Location = new Point(181, 33);
            lblWeatherDescription.Margin = new Padding(4, 0, 4, 0);
            lblWeatherDescription.Name = "lblWeatherDescription";
            lblWeatherDescription.Size = new Size(0, 24);
            lblWeatherDescription.TabIndex = 3;
            // 
            // lblTempCelsius
            // 
            lblTempCelsius.AutoSize = true;
            lblTempCelsius.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTempCelsius.ForeColor = Color.White;
            lblTempCelsius.Location = new Point(9, 187);
            lblTempCelsius.Margin = new Padding(4, 0, 4, 0);
            lblTempCelsius.Name = "lblTempCelsius";
            lblTempCelsius.Size = new Size(0, 55);
            lblTempCelsius.TabIndex = 2;
            // 
            // pbCurrentCondition
            // 
            pbCurrentCondition.Location = new Point(4, 68);
            pbCurrentCondition.Margin = new Padding(4, 3, 4, 3);
            pbCurrentCondition.Name = "pbCurrentCondition";
            pbCurrentCondition.Size = new Size(117, 115);
            pbCurrentCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pbCurrentCondition.TabIndex = 1;
            pbCurrentCondition.TabStop = false;
            // 
            // lblCurrentWeather
            // 
            lblCurrentWeather.AutoSize = true;
            lblCurrentWeather.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentWeather.ForeColor = Color.White;
            lblCurrentWeather.Location = new Point(4, 0);
            lblCurrentWeather.Margin = new Padding(4, 0, 4, 0);
            lblCurrentWeather.Name = "lblCurrentWeather";
            lblCurrentWeather.Size = new Size(0, 24);
            lblCurrentWeather.TabIndex = 0;
            // 
            // hourlyPanel
            // 
            hourlyPanel.AutoScroll = true;
            hourlyPanel.BackColor = SystemColors.ControlDark;
            hourlyPanel.Location = new Point(5, 324);
            hourlyPanel.Margin = new Padding(4, 3, 4, 3);
            hourlyPanel.Name = "hourlyPanel";
            hourlyPanel.Size = new Size(881, 345);
            hourlyPanel.TabIndex = 3;
            // 
            // dailyPanel
            // 
            dailyPanel.AutoScroll = true;
            dailyPanel.BackColor = SystemColors.ControlDark;
            dailyPanel.Controls.Add(btnHistory);
            dailyPanel.Controls.Add(tbSearch);
            dailyPanel.Controls.Add(btnSearch);
            dailyPanel.Location = new Point(889, 6);
            dailyPanel.Margin = new Padding(4, 3, 4, 3);
            dailyPanel.Name = "dailyPanel";
            dailyPanel.Size = new Size(582, 663);
            dailyPanel.TabIndex = 4;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(34, 12);
            btnHistory.Margin = new Padding(4, 3, 4, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(88, 27);
            btnHistory.TabIndex = 10;
            btnHistory.Tag = "1";
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(131, 13);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(320, 23);
            tbSearch.TabIndex = 9;
            tbSearch.Tag = "1";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(461, 12);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 8;
            btnSearch.Tag = "1";
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // localTimeTimer
            // 
            localTimeTimer.Interval = 1000;
            localTimeTimer.Tick += localTimeTimer_Tick;
            // 
            // lblHourlyWeather
            // 
            lblHourlyWeather.AutoSize = true;
            lblHourlyWeather.BackColor = SystemColors.ControlDark;
            lblHourlyWeather.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblHourlyWeather.ForeColor = Color.White;
            lblHourlyWeather.Location = new Point(8, 324);
            lblHourlyWeather.Margin = new Padding(4, 0, 4, 0);
            lblHourlyWeather.Name = "lblHourlyWeather";
            lblHourlyWeather.Size = new Size(0, 24);
            lblHourlyWeather.TabIndex = 27;
            lblHourlyWeather.Tag = "";
            // 
            // spamPrevention
            // 
            spamPrevention.Interval = 3000;
            spamPrevention.Tick += spamPrevention_Tick;
            // 
            // Form1
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1475, 672);
            Controls.Add(lblHourlyWeather);
            Controls.Add(dailyPanel);
            Controls.Add(hourlyPanel);
            Controls.Add(currentPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1491, 711);
            MinimizeBox = false;
            MinimumSize = new Size(1491, 711);
            Name = "Form1";
            Text = "Weather";
            currentPanel.ResumeLayout(false);
            currentPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCurrentCondition).EndInit();
            dailyPanel.ResumeLayout(false);
            dailyPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.Panel hourlyPanel;
        private System.Windows.Forms.Panel dailyPanel;
        private System.Windows.Forms.PictureBox pbCurrentCondition;
        private System.Windows.Forms.Label lblCurrentWeather;
        private System.Windows.Forms.Label lblTempCelsius;
        private System.Windows.Forms.Label lblPlaceCity;
        private System.Windows.Forms.Label lblApparentTempC;
        private System.Windows.Forms.Label lblWeatherDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGustData;
        private System.Windows.Forms.Label lblWindDirectionData;
        private System.Windows.Forms.Label lblWindSpeedData;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label lblGust;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRainData;
        private System.Windows.Forms.Label lblChanceOfRainData;
        private System.Windows.Forms.Label lblHumidityData;
        private System.Windows.Forms.Label lblChanceOfRain;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblCloudData;
        private System.Windows.Forms.Label lblCloud;
        private System.Windows.Forms.Label lblPressureData;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label lblPlaceCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label lblLocalTimeData;
        private System.Windows.Forms.Timer localTimeTimer;
        private System.Windows.Forms.Label lblHourlyWeather;
        private System.Windows.Forms.Timer spamPrevention;
        private System.Windows.Forms.Button btnHistory;
    }
}

