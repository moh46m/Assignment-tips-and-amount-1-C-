using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_Tips_amount1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get food names
            string food1 = txtFood1.Text;
            string food2 = txtFood2.Text;

            // Get food prices
            double priceFood1 = double.Parse(txtPriceFood1.Text);
            double priceFood2 = double.Parse(txtPriceFood2.Text);

            // Add food prices
            double totalAmount = priceFood1 + priceFood2;

            // Set tax and tip rates
            const double salesTaxRate = 5;
            const double tipRate = 15;

            // Calculate tax
            double salesTaxAmount = totalAmount * (salesTaxRate / 100);

            // Calculate tip
            double tipAmount = totalAmount * (tipRate / 100);

            // Calculate full amount
            double fullAmount = totalAmount + salesTaxAmount + tipAmount;

            // Calculate net amount
            double netAmount = fullAmount - salesTaxAmount - tipAmount;

            // Display results
            txtSalesTax.Text = salesTaxAmount.ToString("C2");
            txtTipAmount.Text = tipAmount.ToString("C2");
            txtTotalAmount.Text = fullAmount.ToString("C2");
            txtNetAmount.Text = netAmount.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input boxes
            txtFood1.Clear();
            txtPriceFood1.Clear();
            txtFood2.Clear();
            txtPriceFood2.Clear();
            txtTipsAmount.Clear();

            // Clear result boxes
            txtSalesTax.Clear();
            txtTipAmount.Clear();
            txtTotalAmount.Clear();
            txtNetAmount.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
