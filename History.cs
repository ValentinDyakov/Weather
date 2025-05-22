using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class History : Form
    {
        private Stack<string> _cityStack; // stack to store city history
        public event Action<string> LastCitySelected;
        public History(List<string> cityHistoryList, Stack<string> cityHistoryStack)
        {
            InitializeComponent();
            _cityStack = cityHistoryStack;
            _cityStack.Pop();
            LoadCityHistory(cityHistoryList);
        }

        private void LoadCityHistory(List<string> cityHistoryList)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowCount = 0;

            int row = 0;
            foreach(string i in cityHistoryList)
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Label label = new Label();
                label.Text = i;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(label, 0, row);
                row++;
            }
        }

        private void btnLastCity_Click(object sender, EventArgs e)
        {
            if (_cityStack.Count > 0)
            {

                string lastCity = _cityStack.Pop(); // get last entered city
                LastCitySelected?.Invoke(lastCity); // raise event
                this.Close(); // close history form
            }
            else
            {
                MessageBox.Show("No city in history.");
            }
        }
    }
}
