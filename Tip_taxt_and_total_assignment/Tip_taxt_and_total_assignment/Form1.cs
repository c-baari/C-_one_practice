using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_taxt_and_total_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try {
                // tax
                //using constant variable

                //double TAX = 0.07;

                //creating and initializing variables
                String food1, food2;
                double price1, price2;

                food1=txtfood1.Text;
                price1= double.Parse(txtprice1.Text);
                food2= txtfood2.Text;
                price2=double.Parse(txtprice2.Text);

                //calculating tax and the total

                double total = price1 + price2;
                double tax = total*0.07;
                double total_amount = total+tax;

                //displaying
                string fulldata = "The tax is: " + tax;
                string fulltotal = "The total is: " +total_amount;

                lbltaxdisplay.Text=fulldata;


                lbltotalshow.Text=fulltotal;


            }
            catch
            {
                MessageBox.Show("price must be number");
            }
           




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfood1.Clear();
            txtfood2.Clear();
            txtprice1.Clear();
            txtprice2.Clear();
            lbltaxdisplay.Text="";
            lbltotalshow.Text="";

        }
    }
}
