using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace Reasearch_other_methods_using_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //import class
            StreamReader read_existfile;
            //1.open the file-read the file using open text
            read_existfile = File.OpenText("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt");
            //2.process
            String lines;
            while (read_existfile.EndOfStream == false)
            {
                lines = read_existfile.ReadLine();
                listBox_items_from_thefile.Items.Add(lines);

            }
            //3 close function
            read_existfile.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using readallLines method
            //wuxuu sameenaa dhamaan lines ka ku keydinaa array ka hor inta aan lasoo bandhigin
            String[] lines;
            //validation wye path ka aa mesha soo galise inuu jiro iyo in kale la hubinaa
            if (File.Exists("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt"))
            {
                //files ka xogta ku jirta oo dhan soo aqrinaa
                lines = File.ReadAllLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt");
                listBox_items_from_thefile.Items.AddRange(lines);

                //addrange -means wuxuu line kasta u gelinayaa lixtbox ga item gooni ah
                //f.g - hadaa dhahid items.add(means arrayga oo dhan aa hal item ahaan ugu dartay list box ga) waxa kusp baxeso string[]

            }
            else
            {
                MessageBox.Show("file not found");
            }

        }

        private void btn_readlines_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt"))
            {
                //foreach waxay file ka xogta ku jirta u aqrieysaan line kasta si taxane ah
                foreach (string line in File.ReadLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt"))
                {
                    listBox_items_from_thefile.Items.Add(line);

                }

            }
            else
            {
                MessageBox.Show("path not found");

            }
        }

        private void btn_deleteitem_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt"))
            {
                if (listBox_items_from_thefile.SelectedItem != null)

                {
                    string selectedItem = listBox_items_from_thefile.SelectedItem.ToString();

                    var lines = File.ReadAllLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt").ToList();

                    if (lines.Remove(selectedItem))

                    {
                        File.WriteAllLines("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt", lines);

                        listBox_items_from_thefile.Items.Remove(selectedItem);

                        MessageBox.Show("Item deleted successfully.");
                    }

                    else

                    {
                        MessageBox.Show("Item not found in the file.");
                    }
                }

                else

                {

                    MessageBox.Show("Please select an item to delete.");


                }
            }
            else
            {
                MessageBox.Show("path  not found");
            }
        }

        private void btn_deletefile_Click(object sender, EventArgs e)
        {

            if (File.Exists("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt"))

            {
                //qaabkaan fudud waa ku delete di karaa lkn kan butonka hadaba taabatid hore uu ka delete garenaa

                //File.Delete("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt");
                //MessageBox.Show("file deleted suucesfuly");



                //kan jaanis wuxuu kusiinaa yes iyo no ah sabato ah fartaa kaaga dhici karto adoo  rabin file ka inaa delete gareso
                DialogResult result = MessageBox.Show(

                    "Are you sure you want to delete the entire file?",

                    "Confirm Delete",

                    MessageBoxButtons.YesNo,

                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)

                {

                    File.Delete("C:\\Users\\hp\\Documents\\c#(C-SHARP)  folder\\pratical files which i created chapter4\\Home Practice.txt");

                    listBox_items_from_thefile.Items.Clear();

                    MessageBox.Show("File deleted successfully.");
                } 

        }
    

            else

            {

                MessageBox.Show("File not found.");
            }
        }
    }
}
