using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblnameofthemonth_Click(object sender, EventArgs e)
        {

        }

        private void btnshowoutput_Click(object sender, EventArgs e)
        {
            String day_of_the_week = txtdayoftheweek.Text;
            String name_of_the_month = txtdayofthemonth.Text;
            String day_of_the_month = txtmonth.Text;
            int year =int.Parse(txtyear.Text);
            String full_date=day_of_the_week+ " "+name_of_the_month+" "+
                day_of_the_month+" "+year;
            lbloutput.Text = full_date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayoftheweek.Clear();
            txtdayofthemonth.Clear();
            txtmonth.Clear();
            txtyear.Clear();
            lbloutput.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
