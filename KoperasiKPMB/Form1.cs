using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoperasiKPMB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double price=0;

            if (cmbMenu.Text == "Book")
            {
                price = 3.50;
            }

            else if (cmbMenu.Text == "Pen")
            {
                price = 2.50;
            }

            else if (cmbMenu.Text == "Pencil")
            {
                price = 1.50;
            }

            else if (cmbMenu.Text == "Ruler")
            {
                price = 2.50;
            }

            int quantity = int.Parse(txtQuantity.Text);

            double actual=0;
            actual = price * quantity;
            txtActual.Text = actual.ToString();

            double discount=0;

            if (quantity <11)
            {
               
            }

            else if (quantity>=11 && quantity<=20)
            {
               discount= actual * 0.05;
            }

            else if (quantity>=21 && quantity<=50)
            {
                discount = actual * 0.1;
            }

            else if (quantity>50)
            {
                discount = actual * 0.15;
            }

            else
            {
                MessageBox.Show("Invalid quantity");
            }

            txtDiscount.Text = discount.ToString();

            double total = 0;
            total = actual-discount;
            txtTotal.Text = total.ToString();
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
        }
    }
}
