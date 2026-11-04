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
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace file_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Haddii user-ku doorto file-ka
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Append wuxuu xogta cusub ku darayaa xogtii hore
                // mana tirtirayo xogtii ku jirtay file-ka
                StreamWriter outputFile;
                outputFile= File.AppendText(saveFileDialog.FileName);

                // Xogta cusub ku qor file-ka
                outputFile.WriteLine(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
               

                // Xir file-ka marka qoristu dhammaato
                outputFile.Close();
                textBox1.Text="";

                
            }




 

        }
    }
}
