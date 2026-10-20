namespace HOTEL_BOOKING
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtguest = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdostandard = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdohight = new System.Windows.Forms.RadioButton();
            this.checkBoxbreakfast = new System.Windows.Forms.CheckBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGuest);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblNights);
            this.groupBox1.Controls.Add(this.txtguest);
            this.groupBox1.Controls.Add(this.txtnights);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(601, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(68, 48);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(164, 29);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Guest Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(258, 42);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(317, 35);
            this.txtname.TabIndex = 1;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(258, 97);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(317, 35);
            this.txtage.TabIndex = 2;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(258, 157);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(317, 35);
            this.txtnights.TabIndex = 3;
            // 
            // txtguest
            // 
            this.txtguest.Location = new System.Drawing.Point(258, 208);
            this.txtguest.Name = "txtguest";
            this.txtguest.Size = new System.Drawing.Size(317, 35);
            this.txtguest.TabIndex = 4;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(3, 163);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(229, 29);
            this.lblNights.TabIndex = 5;
            this.lblNights.Text = "Number Of Nights:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(91, 103);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(141, 29);
            this.lblage.TabIndex = 6;
            this.lblage.Text = "Guest Age:";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Location = new System.Drawing.Point(10, 214);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(222, 29);
            this.lblGuest.TabIndex = 7;
            this.lblGuest.Text = "Number Of Guest:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdohight);
            this.groupBox2.Controls.Add(this.rdonormal);
            this.groupBox2.Controls.Add(this.rdostandard);
            this.groupBox2.Location = new System.Drawing.Point(24, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxbreakfast);
            this.groupBox3.Location = new System.Drawing.Point(24, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Option";
            // 
            // rdostandard
            // 
            this.rdostandard.AutoSize = true;
            this.rdostandard.Location = new System.Drawing.Point(66, 39);
            this.rdostandard.Name = "rdostandard";
            this.rdostandard.Size = new System.Drawing.Size(143, 33);
            this.rdostandard.TabIndex = 0;
            this.rdostandard.TabStop = true;
            this.rdostandard.Text = "Standard";
            this.rdostandard.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(258, 42);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(123, 33);
            this.rdonormal.TabIndex = 1;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdohight
            // 
            this.rdohight.AutoSize = true;
            this.rdohight.Location = new System.Drawing.Point(472, 42);
            this.rdohight.Name = "rdohight";
            this.rdohight.Size = new System.Drawing.Size(99, 33);
            this.rdohight.TabIndex = 2;
            this.rdohight.TabStop = true;
            this.rdohight.Text = "Hight";
            this.rdohight.UseVisualStyleBackColor = true;
            // 
            // checkBoxbreakfast
            // 
            this.checkBoxbreakfast.AutoSize = true;
            this.checkBoxbreakfast.Location = new System.Drawing.Point(96, 34);
            this.checkBoxbreakfast.Name = "checkBoxbreakfast";
            this.checkBoxbreakfast.Size = new System.Drawing.Size(463, 33);
            this.checkBoxbreakfast.TabIndex = 0;
            this.checkBoxbreakfast.Text = "BreakFast( 10 Per Guest Per Nights)";
            this.checkBoxbreakfast.UseVisualStyleBackColor = true;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 29;
            this.listbox.Location = new System.Drawing.Point(636, 44);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(566, 468);
            this.listbox.TabIndex = 3;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(192, 546);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(125, 42);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(395, 546);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 42);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexite
            // 
            this.btnexite.Location = new System.Drawing.Point(626, 546);
            this.btnexite.Name = "btnexite";
            this.btnexite.Size = new System.Drawing.Size(125, 42);
            this.btnexite.TabIndex = 6;
            this.btnexite.Text = "&Exite";
            this.btnexite.UseVisualStyleBackColor = true;
            this.btnexite.Click += new System.EventHandler(this.btnexite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1924, 887);
            this.Controls.Add(this.btnexite);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.TextBox txtguest;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdohight;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdostandard;
        private System.Windows.Forms.CheckBox checkBoxbreakfast;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexite;
    }
}

