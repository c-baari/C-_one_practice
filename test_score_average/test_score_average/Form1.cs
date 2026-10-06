using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_score_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Validate input to ensure that the scores are numeric and not negative
            double validation;
            if (double.TryParse(txtscore1.Text, out validation) &&
                double.TryParse(txtscore2.Text, out validation) &&
                double.TryParse(txtscore3.Text, out validation))
            {
                // All inputs are numeric, proceed with calculations
                try

                {
                    //declaring and initializing variables

                    double score1, score2, score3, total, average;

                    score1= double.Parse(txtscore1.Text);
                    score2= double.Parse(txtscore2.Text);
                    score3= double.Parse(txtscore3.Text);

                    // Calculate total and average
                    total = score1 + score2 + score3;
                    average = total / 3;


                    // Check for negative scores and display appropriate messages

                    if (score1<0)
                    {
                        MessageBox.Show("Score 1 cannot be negative. Please enter a valid score.");
                    }
                    else if (score2<0)
                    {
                        MessageBox.Show("Score 2 cannot be negative. Please enter a valid score.");
                    }
                    else if (score3<0)
                    {
                        MessageBox.Show("Score 3 cannot be negative. Please enter a valid score.");
                    }
                    else
                    {
                    
                        lblshow.Text = average.ToString();
                    }
  
                }
                // Handle any unexpected exceptions that may occur during parsing or calculations
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
              
            }
            // If any of the inputs are not numeric, display an error message
            else
            {
                MessageBox.Show("Please enter valid numeric scores.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes and the label

            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            lblshow.Text = string.Empty;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close the application when the exit button is clicked

            this.Close();
        }
    }
}
