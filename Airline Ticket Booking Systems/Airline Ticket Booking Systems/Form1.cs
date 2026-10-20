using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Get the passenger information from the textboxes.
            int validate;
            string passengerName = txtname.Text;
            int age = int.Parse(txtage.Text);
            int number_of_tickets = int.Parse(txttickets.Text);
            int baggageWeight = int.Parse(txtweight.Text);
            // Get the passenger information from the textboxes.
            if (int.TryParse(txtage.Text, out validate) &&
                    int.TryParse(txttickets.Text, out validate) &&
                    int.TryParse(txtweight.Text, out validate))
            {
                // Check that the passenger entered valid information.
                if (passengerName == "")
                {
                    MessageBox.Show("Please enter the passenger name.");
                }
                else if (age < 1 || age > 100)
                {
                    MessageBox.Show("Age must be between 1 and 100.");
                }
                else if (number_of_tickets < 1 || number_of_tickets > 5)
                {
                    MessageBox.Show("Tickets must be between 1 and 5.");
                }
                else if (baggageWeight < 0 || baggageWeight > 50)
                {
                    MessageBox.Show("Baggage must be between 0 and 50 kg.");
                }
                else if (age < 12 && radioButtonfirstclass.Checked)
                {
                    // Children below 12 cannot book First Class.
                    MessageBox.Show("Booking rejected. Children below 12 cannot book First Class.");
                }
                else if (!radioButtonfirstclass.Checked &&
                         !radioButtonnormal.Checked &&
                         !radioButtonbussinesclass.Checked)
                {
                    // A travel class must be selected.
                    MessageBox.Show("Please select a travel class.");
                }
                else
                {
                    // Approve the booking after all validations succeed.
                    string bookingApproved = "Approved";
                    // Set the ticket price according to the selected class.
                    double ticketPrice;

                    if (radioButtonfirstclass.Checked)
                    {
                        ticketPrice = 150;
                    }
                    else if (radioButtonnormal.Checked)
                    {
                        ticketPrice = 300;
                    }
                    else
                    {
                        ticketPrice = 500;
                    }

                    // Calculate the basic ticket cost.
                    double basicCost = ticketPrice * number_of_tickets;

                    // Calculate the discount for the number of tickets.
                    double ticketDiscount = 0;

                    if (number_of_tickets == 3 || number_of_tickets == 4)
                    {
                        ticketDiscount = basicCost * 0.05;
                    }
                    else if (number_of_tickets == 5)
                    {
                        ticketDiscount = basicCost * 0.10;
                    }

                    // Calculate the discount based on passenger age.
                    double ageDiscount = 0;

                    if (age < 12)
                    {
                        ageDiscount = basicCost * 0.20;
                    }
                    else if (age >= 60)
                    {
                        ageDiscount = basicCost * 0.10;
                    }

                    // Add insurance cost if the passenger selects it.
                    double insuranceCost = 0;

                    if (checkBoxadd.Checked)
                    {
                        insuranceCost = 25 * number_of_tickets;
                    }

                    // Baggage up to 20 kg is free.
                    // The assignment does not specify the excess baggage price.
                    double baggageCost = 0;

                    if (baggageWeight <= 20)
                    {
                        baggageCost = 0;
                    }

                    // Calculate the final ticket cost.
                    double totalDiscount = ticketDiscount + ageDiscount;

                    double finalCost = basicCost - totalDiscount
                                        + insuranceCost + baggageCost;

                    // Identify the selected travel class.
                    string travelClass;

                    if (radioButtonfirstclass.Checked)
                    {
                        travelClass = "First Class";
                    }
                    else if (radioButtonnormal.Checked)
                    {
                        travelClass = "Normal Class";
                    }
                    else
                    {
                        travelClass = "Business Class";
                    }

                    // Display the booking details.
                    listbox.Items.Add("AIRLINE BOOKING DETAILS");
                    listbox.Items.Add("--------------------------------");
                    listbox.Items.Add("Passenger Name: " + passengerName);
                    listbox.Items.Add("Passenger Age: " + age);
                    listbox.Items.Add("Number of Tickets: " + number_of_tickets);
                    listbox.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                    listbox.Items.Add("Travel Class: " + travelClass);
                    listbox.Items.Add(" ");
                    listbox.Items.Add("Basic Ticket Cost: $" + basicCost.ToString("0.00"));
                    listbox.Items.Add("Ticket Discount: $" + ticketDiscount.ToString("0.00"));
                    listbox.Items.Add("Age Discount: $" + ageDiscount.ToString("0.00"));
                    listbox.Items.Add("Insurance Cost: $" + insuranceCost.ToString("0.00"));
                    listbox.Items.Add("Baggage Cost: $" + baggageCost.ToString("0.00"));
                    listbox.Items.Add("Final Cost: $" + finalCost.ToString("0.00"));
                    listbox.Items.Add("Booking Approved: " + bookingApproved);
                    listbox.Items.Add(" ");
                }
            }
            else
            {
                // Display an error when numeric input is invalid.
                MessageBox.Show("Please enter valid numbers for age, tickets, and baggage.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            


        }


        private void btnexit_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            // Clear all passenger information.
            txtname.Clear();
            txtage.Clear();
            txttickets.Clear();
            txtweight.Clear();

            // Reset the travel class options.
            radioButtonfirstclass.Checked = false;
            radioButtonnormal.Checked = false;
            radioButtonbussinesclass.Checked = false;

            // Clear the insurance option.
            checkBoxadd.Checked = false;

            // Clear the booking details.
            listbox.Items.Clear();
        }

        private void btnexite_Click(object sender, EventArgs e)
        {
            // Close the application.
            this.Close();
        }
    }
}


    //----------------------------

 

