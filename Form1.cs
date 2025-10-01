using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class changeCounterForm : Form
    {
        // Constant fields
        private const decimal FIVE_CENTS_VALUE = 0.05m;
        private const decimal TEN_CENTS_VALUE = 0.10m;
        private const decimal TWENTY_FIVE_cENTS_VALUE = 0.25m;
        private const decimal FIFTY_CENTS_VALUE = 0.50M;

        // Field variable to hold the total,
        // Initialized with 0
        private decimal total = 0m;
        public changeCounterForm()
        {
            InitializeComponent();
        }

        private void fiveCentsPicture_Click(object sender, EventArgs e)
        {
            // Add the value of 5 cents to the total
            total += FIVE_CENTS_VALUE;

            // Display the total, formatted as currency
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPicture_Click(object sender, EventArgs e)
        {
            // Add the value of 10 cents to the total
            total += TEN_CENTS_VALUE;

            // Display the total, formatted as currency
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFivePicture_Click(object sender, EventArgs e)
        {
            // Add the value of 25 cents to the total
            total += TWENTY_FIVE_cENTS_VALUE;

            // Display the total, formatted as currency
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPicture_Click(object sender, EventArgs e)
        {
            // Add the value of 50 cents to the total
            total += FIFTY_CENTS_VALUE;

            // Display the total, formatted as currency
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
