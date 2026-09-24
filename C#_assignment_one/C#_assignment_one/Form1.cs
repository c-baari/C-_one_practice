using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__assignment_one
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String fname, department;
            int id, semester;
            fname=txtname.Text;
            department=txtdept.Text;
            id=int.Parse(txtid.Text);
            semester=int.Parse(txtsemester.Text);
            lbloutput.Text="Name: " + fname + " Department: " + department + " ID: " + id + " Semester: " + semester;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtdept.Clear();
            txtid.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        }
    }
}
