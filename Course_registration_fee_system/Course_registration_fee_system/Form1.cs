using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_registration_fee_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //variable to be assigned student name
            String Student_name=txtname.Text;

            double validate;
            if(double.TryParse(txtid.Text, out validate) &&
                double.TryParse(txtcourses.Text, out validate) &&
                double.TryParse(txtfee.Text, out validate))
            {

                try
                {
                    //constant variable
                    double DISCOUNT1 = 0.10;
                    double DISCOUNT2 = 0.05;
                    //declaring variables
                    double studentId, numberOfCourse, studyLevel, tuitionFee ,Fee, total;

                    String fulldata;

                    //assigning variables
                    studentId=double.Parse(txtid.Text);
                    numberOfCourse=double.Parse(txtcourses.Text);
                    studyLevel=double.Parse(txtlevels.Text);
                   
                    Fee=double.Parse(txtfee.Text);

                    


                    //ckecking conditions

                    if (studyLevel==1)
                    {
                        total = numberOfCourse*40;
                        if (numberOfCourse>=6)
                        {
                            double getDiscount = total* DISCOUNT1;
                            double final = total-getDiscount+Fee;
                            fulldata="Student name: " + Student_name +
                            " studentId: "+ studentId +
                            " Study level: " + studyLevel +
                            
                            " fee: "+ Fee+
                            " discount earned: " + getDiscount+
                            " final registartion: "+ final;
                            lblshow.Text=fulldata;


                        }
                        else
                        {

                            fulldata="Student name: " + Student_name +
                                " studentId: "+ studentId +
                                " Study level: " + studyLevel +
                                
                                " fee: "+ Fee+
                                " final registartion: "+ total;
                            lblshow.Text=fulldata;
                        }

                    }
                    //checking year 2
                    else if (studyLevel==2)

                    {
                        total = numberOfCourse*45;

                        if (numberOfCourse>=6)
                        {
                            total=numberOfCourse*50;
                            double getDiscount = total* DISCOUNT1;
                            double final = total-getDiscount+Fee;
                            
                            fulldata="Student name: " + Student_name +
                            " studentId: "+ studentId +
                            " Study level: " + studyLevel +

                            " fee: "+ Fee+
                            " discount earned: " + getDiscount+
                            " final registartion: "+ final;
                            lblshow.Text=fulldata;


                        }
                        else
                        {

                            total=numberOfCourse*45;
                            fulldata="Student name: " + Student_name +
                                " studentId: "+ studentId +
                                " Study level: " + studyLevel +

                                " fee: "+ Fee+
                                " final registartion: "+ total;
                            lblshow.Text= fulldata;
                        }
                    }
                    //checking year 3
                    else if (studyLevel==3)
                        
                    {
                        
                        total=numberOfCourse*50;

                        if (numberOfCourse>=6)
                        {
                            double getDiscount = total* DISCOUNT1;
                            double final = total-getDiscount+Fee;
                            total=numberOfCourse*50;
                            fulldata="Student name: " + Student_name +
                            " studentId: "+ studentId +
                            " Study level: " + studyLevel +

                            " fee: "+ Fee+
                            " discount earned: " + getDiscount+
                            " final registartion: "+ final;
                            lblshow.Text=fulldata;


                        }
                        else
                        {
                            
                            fulldata="Student name: " + Student_name +
                                " studentId: "+ studentId +
                                " Study level: " + studyLevel +
               
                                " fee: "+ Fee+
                                " final registartion: "+ total;
                            lblshow.Text=fulldata;
                        }

                    }
                    //checking year 4
                    else if (studyLevel==4)

                    {
                        total=numberOfCourse*55;
                        if (numberOfCourse>=6)
                        {
                            double getDiscount = total* DISCOUNT1;
                            double final = total-getDiscount+Fee;
                            fulldata="Student name: " + Student_name +
                            " studentId: "+ studentId +
                            " Study level: " + studyLevel +
                 
                            " fee: "+ Fee+
                            " discount earned: " + getDiscount+
                            " final registartion: "+ final;
                            lblshow.Text=fulldata;


                        }
                        else
                        {
                            total=numberOfCourse*55;
                            fulldata="Student name: " + Student_name +
                                " studentId: "+ studentId +
                                " Study level: " + studyLevel +
                   
                                " fee: "+ Fee+
                                " final registartion: "+ total;
                            lblshow.Text=fulldata;

                        }
                   
                    }
                    //ckeck if not been selected the study years
                    else
                    {
                        MessageBox.Show("study year are 4 please enter either the 4 years");
                    }







                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
               
              
            }

            else
            {
                MessageBox.Show("Please enter valid numeric.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtid.Text = string.Empty;
            txtcourses.Text = string.Empty;
            txtlevels.Text = string.Empty;
            txtfee.Text = string.Empty;
            lblshow.Text = string.Empty;
        }

        private void tnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
