using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_COURSE_REGISTRATION
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
            
      
        }

        private void btnaddcourse_Click(object sender, EventArgs e)
        {

      



        }

        private void btnremove_Click(object sender, EventArgs e)
        {
       

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string cousre;
            int numberOfCourse ;
            decimal price, valudate;
            cousre = txtcourse.Text;
            if (cousre!=null)
            {




                if (decimal.TryParse(txtprice.Text, out valudate))
                {
                    price=decimal.Parse(txtprice.Text);
                    numberOfCourse= int.Parse(txtnumberofcourse.Text);
                    if (price>0)
                    {
                        if (numberOfCourse>1 && numberOfCourse<6)
                        {
                            int count = 0;
                            //while (cousre!=cousre)
                           
                                courseInfo.Items.Add("course name: " + cousre);
                                courseInfo.Items.Add("course price: $" + price);
                                courseInfo.Items.Add("number of course: " + numberOfCourse);


                                //count++;

                            
                            //else
                            //{
                            //    MessageBox.Show("this course is been added before!");
                            //}
                        }
                        else
                        {
                            MessageBox.Show("number of course must be betweeen 1 up to 5");
                        }


                    }
                    else
                    {
                        MessageBox.Show("price must be negative");
                    }
                }
                else
                {
                    MessageBox.Show("pleas enter  a numeric number!");
                }
            }
            else
            {
                MessageBox.Show("course must not be empty");
            }
            txtcourse.Clear();
            txtprice.Clear();
            txtnumberofcourse.Clear();
        
        }

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            string name, course, regidtrationStatu;
            int id, validate, age, numberOfCourse ;
            double courseRegistrationFee, courseDiscount;
            double price, total;
            try
            {
                if (int.TryParse(txtid.Text, out validate))
                {
                    if (int.TryParse(txtage.Text, out validate))
                    {
                        id=int.Parse(txtid.Text);
                        name=txtname.Text;
                        age=int.Parse(txtage.Text);
                        price=double.Parse(txtprice.Text);
                        numberOfCourse= int.Parse(txtnumberofcourse.Text);

                        if (id>0)
                        {
                            if (name!=null)
                            {



                                if (age>0)
                                {
                                    if (age>16 && age<60)
                                    {
                                        if (numberOfCourse==1)
                                        {
                                            total=price;
                                            studentInfo.Items.Add("student ID: "+ id);
                                            studentInfo.Items.Add("student name: "+ name);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("-------------------------------------");
                                            studentInfo.Items.Add("basic regitration fee: $" +price);
                                            studentInfo.Items.Add("course discount: $" + "no course discount");
                                            studentInfo.Items.Add("--------------------------------------");
                                            studentInfo.Items.Add("final registration fee: $"+ total);
                                            studentInfo.Items.Add("registration status: "+ "approved");
                                            studentInfo.Items.Add(" ");

                                        }
                                        else if (numberOfCourse==2)
                                        {
                                            courseDiscount= (int)price*0.05;
                                            total= price-courseDiscount;

                                            studentInfo.Items.Add("student ID: "+ id);
                                            studentInfo.Items.Add("student name: "+ name);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("-------------------------------------");
                                            studentInfo.Items.Add("basic regitration fee: $" +price);
                                            studentInfo.Items.Add("course discount: $" + courseDiscount);
                                            studentInfo.Items.Add("--------------------------------------");
                                            studentInfo.Items.Add("final registration fee: $"+ total);
                                            studentInfo.Items.Add("registration status: "+ "approved");
                                            studentInfo.Items.Add(" ");




                                        }
                                        else if (numberOfCourse==3 || numberOfCourse==4)
                                        {
                                            courseDiscount=(int)price*0.1;
                                            total= price-courseDiscount;

                                            studentInfo.Items.Add("student ID: "+ id);
                                            studentInfo.Items.Add("student name: "+ name);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("-------------------------------------");
                                            studentInfo.Items.Add("basic regitration fee: $" +price);
                                            studentInfo.Items.Add("course discount: $" + courseDiscount);
                                            studentInfo.Items.Add("--------------------------------------");
                                            studentInfo.Items.Add("final registration fee: $"+ total);
                                            studentInfo.Items.Add("registration status: "+ "approved");
                                            studentInfo.Items.Add(" ");
                                        }
                                        else if (numberOfCourse==5)
                                        {
                                            courseDiscount=(int)price*0.15;
                                            total= price-courseDiscount;

                                            studentInfo.Items.Add("student ID: "+ id);
                                            studentInfo.Items.Add("student name: "+ name);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("number of course: "+ numberOfCourse);
                                            studentInfo.Items.Add("-------------------------------------");
                                            studentInfo.Items.Add("basic regitration fee: $" +price);
                                            studentInfo.Items.Add("course discount: $" + courseDiscount);
                                            studentInfo.Items.Add("--------------------------------------");
                                            studentInfo.Items.Add("final registration fee: $"+ total);
                                            studentInfo.Items.Add("registration status: "+ "approved");
                                            studentInfo.Items.Add(" ");
                                        }
                                        else
                                        {
                                            MessageBox.Show("at least one course must be inserted");
                                        }



                                    }
                                    else
                                    {
                                        MessageBox.Show("age must be 16 up to 60");
                                    }


                                }
                                else
                                {
                                    MessageBox.Show("age connot be negative! ");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("id must not be negative and it must be inserted! ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("age must be numeric");
                    }

                }
                else
                {
                    MessageBox.Show("id must be numeric");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtprice.Clear();
            txtcourse.Clear();
            txtprice.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {

            String selectedItem = courseInfo.SelectedItem.ToString();
            if (courseInfo.SelectedIndex!=-1)
            {

                courseInfo.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("please select item to remove");
            }
        }

        private void txtnumberofcourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
