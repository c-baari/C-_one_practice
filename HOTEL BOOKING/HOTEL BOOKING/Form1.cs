using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_BOOKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

                // Get the guest information from the textboxes.
                string guestName = txtname.Text;
                int validate;
                int age;
                int numberOfNights;
                int numberOfGuests;

                // Validate all numeric inputs using TryParse.
                if (int.TryParse(txtage.Text, out validate) &&
                    int.TryParse(txtnights.Text, out validate) &&
                    int.TryParse(txtguest.Text, out validate))
                {
                age = int.Parse(txtage.Text);
                numberOfNights = int.Parse(txtnights.Text);
                numberOfGuests = int.Parse(txtguest.Text);

                // Check whether the guest name is empty.
                if (guestName == "")
                    {
                       string bookingApproved = "Rejected!";
                        MessageBox.Show("Please enter the guest name.");
                    }
                    // Check whether the guest age is valid.
                    else if (age < 18 || age > 90)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Guest age must be between 18 and 90.");
                    }
                    // Check whether the number of nights is valid.
                    else if (numberOfNights < 1 || numberOfNights > 30)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Number of nights must be between 1 and 30.");
                    }
                    // Check whether the number of guests is valid.
                    else if (numberOfGuests < 1 || numberOfGuests > 6)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Number of guests must be between 1 and 6.");
                    }
                    // Check the maximum guests allowed for each room type.
                    else if (rdostandard.Checked && numberOfGuests > 2)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Standard rooms allow a maximum of 2 guests.");
                    }
                    else if (rdonormal.Checked && numberOfGuests > 4)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Normal rooms allow a maximum of 4 guests.");
                    }
                    else if (rdohight.Checked && numberOfGuests > 6)
                    {
                    string bookingApproved = "Rejected!";
                    MessageBox.Show("Hight rooms allow a maximum of 6 guests.");
                    }
                    // Make sure the guest selects a room type.
                    else if (!rdostandard.Checked &&
                             !rdonormal.Checked &&
                             !rdohight.Checked)
                    {
                    MessageBox.Show("Please select a room type.");
                    }
                    else
                    {
                    // The booking is approved after all validations pass.
                    string bookingApproved = "Approved";

                    // Determine the room rate using a switch statement.
                    double roomRate = 0;
                        string roomType = "";

                        if (rdostandard.Checked)
                        {
                            roomType = "Standard";
                        }
                        else if (rdonormal.Checked)
                        {
                            roomType = "Normal";
                        }
                        else if (rdohight.Checked)
                        {
                            roomType = "Hight";
                        }

                        switch (roomType)
                        {
                            case "Standard":
                                roomRate = 50;
                                break;

                            case "Normal":
                                roomRate = 80;
                                break;

                            case "Hight":
                                roomRate = 130;
                                break;
                        }

                        // Calculate the basic room cost.
                        double basicCost = roomRate * numberOfNights;

                        // Calculate the discount based on the number of nights.
                        double nightDiscount = 0;

                        if (numberOfNights >= 5 && numberOfNights <= 9)
                        {
                            nightDiscount = basicCost * 0.05;
                        }
                        else if (numberOfNights >= 10)
                        {
                            nightDiscount = basicCost * 0.12;
                        }

                        // Calculate the additional senior discount.
                        double seniorDiscount = 0;

                        if (age >= 60)
                        {
                            seniorDiscount = basicCost * 0.05;
                        }

                        // Calculate the breakfast cost if selected.
                        double breakfastCost = 0;

                        if (checkBoxbreakfast.Checked) 
                        {
                            breakfastCost = 10 * numberOfGuests * numberOfNights;
                        }

                        // Add a 5% service surcharge for more than 4 guests.
                        double serviceCharge = 0;

                        if (numberOfGuests > 4)
                        {
                            serviceCharge = basicCost * 0.05;
                        }

                        // Calculate the total discounts.
                        double totalDiscount = nightDiscount + seniorDiscount;

                        // Calculate the final booking cost.
                        double finalCost = basicCost - totalDiscount
                                           + breakfastCost + serviceCharge;

                    // Display the booking details.
                    listbox.Items.Add("HOTEL BOOKING DETAILS");
                    listbox.Items.Add("---------------------");
                    listbox.Items.Add("Guest Name: " + guestName);
                    listbox.Items.Add("Guest Age: " + age);
                    listbox.Items.Add("Number of Nights: " + numberOfNights);
                    listbox.Items.Add("Number of Guests: " + numberOfGuests);
                    listbox.Items.Add("Room Type: " + roomType);
                    listbox.Items.Add(" ");
                    listbox.Items.Add("Room Rate Per Night: $" + roomRate.ToString("0.00"));
                    listbox.Items.Add("Basic Room Cost: $" + basicCost.ToString("0.00"));
                    listbox.Items.Add("Night Discount: $" + nightDiscount.ToString("0.00"));
                    listbox.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
                    listbox.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0.00"));
                    listbox.Items.Add("Service Charge: $" + serviceCharge.ToString("0.00"));
                    listbox.Items.Add("Total Discount: $" + totalDiscount.ToString("0.00"));
                    listbox.Items.Add("Final Cost: $" + finalCost.ToString("0.00"));
                    listbox.Items.Add("Booking Approved: " + bookingApproved);
                    listbox.Items.Add(" ");
                }
                }
                else
                {
                // Show an error if any numeric input is invalid.
                string bookingApproved = "Rejected!";
                MessageBox.Show("Please enter valid numbers for age, nights, and guests.");
                }
            }

            private void btnclear_Click(object sender, EventArgs e)
            {
            }

            private void btnexit_Click(object sender, EventArgs e)
            {
            }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            // Clear all guest information.
            txtname.Clear();
            txtage.Clear();
            txtnights.Clear();
            txtguest.Clear();

            // Reset the room type selection.
            rdostandard.Checked = false;
            rdonormal.Checked = false;
            rdohight.Checked = false;

            // Uncheck the breakfast option.
            checkBoxbreakfast.Checked = false;

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



