namespace Airline_Ticket_Booking_Systems
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
            this.lblweight = new System.Windows.Forms.Label();
            this.lbltickets = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonbussinesclass = new System.Windows.Forms.RadioButton();
            this.radioButtonnormal = new System.Windows.Forms.RadioButton();
            this.radioButtonfirstclass = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxadd = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblweight);
            this.groupBox1.Controls.Add(this.lbltickets);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txttickets);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(21, 200);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(259, 29);
            this.lblweight.TabIndex = 10;
            this.lblweight.Text = "Baggage Weight(gk):";
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Location = new System.Drawing.Point(41, 146);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(239, 29);
            this.lbltickets.TabIndex = 9;
            this.lbltickets.Text = "Number Of Tickets:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(82, 92);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(198, 29);
            this.lblage.TabIndex = 8;
            this.lblage.Text = "Passenger Age:";
            // 
            // txtweight
            // 
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweight.Location = new System.Drawing.Point(328, 194);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(262, 35);
            this.txtweight.TabIndex = 7;
            // 
            // txttickets
            // 
            this.txttickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttickets.Location = new System.Drawing.Point(328, 140);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(262, 35);
            this.txttickets.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Location = new System.Drawing.Point(328, 90);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(262, 35);
            this.txtage.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(328, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(262, 35);
            this.txtname.TabIndex = 4;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(59, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(221, 29);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Passenger Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonbussinesclass);
            this.groupBox2.Controls.Add(this.radioButtonnormal);
            this.groupBox2.Controls.Add(this.radioButtonfirstclass);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Travel Classes";
            // 
            // radioButtonbussinesclass
            // 
            this.radioButtonbussinesclass.AutoSize = true;
            this.radioButtonbussinesclass.Location = new System.Drawing.Point(453, 43);
            this.radioButtonbussinesclass.Name = "radioButtonbussinesclass";
            this.radioButtonbussinesclass.Size = new System.Drawing.Size(216, 33);
            this.radioButtonbussinesclass.TabIndex = 2;
            this.radioButtonbussinesclass.TabStop = true;
            this.radioButtonbussinesclass.Text = "Business Class";
            this.radioButtonbussinesclass.UseVisualStyleBackColor = true;
            // 
            // radioButtonnormal
            // 
            this.radioButtonnormal.AutoSize = true;
            this.radioButtonnormal.Location = new System.Drawing.Point(214, 43);
            this.radioButtonnormal.Name = "radioButtonnormal";
            this.radioButtonnormal.Size = new System.Drawing.Size(195, 33);
            this.radioButtonnormal.TabIndex = 1;
            this.radioButtonnormal.TabStop = true;
            this.radioButtonnormal.Text = "Normal Class";
            this.radioButtonnormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonfirstclass
            // 
            this.radioButtonfirstclass.AutoSize = true;
            this.radioButtonfirstclass.Location = new System.Drawing.Point(9, 43);
            this.radioButtonfirstclass.Name = "radioButtonfirstclass";
            this.radioButtonfirstclass.Size = new System.Drawing.Size(162, 33);
            this.radioButtonfirstclass.TabIndex = 0;
            this.radioButtonfirstclass.TabStop = true;
            this.radioButtonfirstclass.Text = "First Class";
            this.radioButtonfirstclass.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxadd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(51, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Option";
            // 
            // checkBoxadd
            // 
            this.checkBoxadd.AutoSize = true;
            this.checkBoxadd.Location = new System.Drawing.Point(51, 37);
            this.checkBoxadd.Name = "checkBoxadd";
            this.checkBoxadd.Size = new System.Drawing.Size(473, 33);
            this.checkBoxadd.TabIndex = 0;
            this.checkBoxadd.Text = "Add Travel Insurance($25 Per Ticket)";
            this.checkBoxadd.UseVisualStyleBackColor = true;
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 29;
            this.listbox.Location = new System.Drawing.Point(718, 23);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(515, 497);
            this.listbox.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(718, 537);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(116, 52);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(907, 537);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 52);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnexite
            // 
            this.btnexite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexite.Location = new System.Drawing.Point(1080, 537);
            this.btnexite.Name = "btnexite";
            this.btnexite.Size = new System.Drawing.Size(116, 52);
            this.btnexite.TabIndex = 8;
            this.btnexite.Text = "&Exit";
            this.btnexite.UseVisualStyleBackColor = true;
            this.btnexite.Click += new System.EventHandler(this.btnexite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 673);
            this.Controls.Add(this.btnexite);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.RadioButton radioButtonbussinesclass;
        private System.Windows.Forms.RadioButton radioButtonnormal;
        private System.Windows.Forms.RadioButton radioButtonfirstclass;
        private System.Windows.Forms.CheckBox checkBoxadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexite;
    }
}

