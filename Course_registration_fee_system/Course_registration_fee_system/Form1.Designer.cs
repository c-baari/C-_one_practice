namespace Course_registration_fee_system
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
            this.lblsid = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblncourse = new System.Windows.Forms.Label();
            this.lblslevel = new System.Windows.Forms.Label();
            this.lbltransportoption = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.txtlevels = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.tnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblshow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblshow);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.tnexit);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.txtfee);
            this.groupBox1.Controls.Add(this.txtlevels);
            this.groupBox1.Controls.Add(this.txtcourses);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lbltransportoption);
            this.groupBox1.Controls.Add(this.lblslevel);
            this.groupBox1.Controls.Add(this.lblncourse);
            this.groupBox1.Controls.Add(this.lblsname);
            this.groupBox1.Controls.Add(this.lblsid);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Registration FEE System";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Location = new System.Drawing.Point(70, 68);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(229, 26);
            this.lblsid.TabIndex = 0;
            this.lblsid.Text = "Enter Student Name:";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.Location = new System.Drawing.Point(107, 120);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(192, 26);
            this.lblsname.TabIndex = 1;
            this.lblsname.Text = "Enter Student Id:";
            // 
            // lblncourse
            // 
            this.lblncourse.AutoSize = true;
            this.lblncourse.Location = new System.Drawing.Point(23, 165);
            this.lblncourse.Name = "lblncourse";
            this.lblncourse.Size = new System.Drawing.Size(276, 26);
            this.lblncourse.TabIndex = 2;
            this.lblncourse.Text = "Enter Number of courses:";
            // 
            // lblslevel
            // 
            this.lblslevel.AutoSize = true;
            this.lblslevel.Location = new System.Drawing.Point(102, 214);
            this.lblslevel.Name = "lblslevel";
            this.lblslevel.Size = new System.Drawing.Size(197, 26);
            this.lblslevel.TabIndex = 3;
            this.lblslevel.Text = "Enter Study level:";
            // 
            // lbltransportoption
            // 
            this.lbltransportoption.AutoSize = true;
            this.lbltransportoption.Location = new System.Drawing.Point(93, 272);
            this.lbltransportoption.Name = "lbltransportoption";
            this.lbltransportoption.Size = new System.Drawing.Size(200, 26);
            this.lbltransportoption.TabIndex = 5;
            this.lbltransportoption.Text = "Transport Option:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(314, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(314, 35);
            this.txtname.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(314, 111);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(314, 35);
            this.txtid.TabIndex = 7;
            // 
            // txtcourses
            // 
            this.txtcourses.Location = new System.Drawing.Point(314, 159);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(314, 35);
            this.txtcourses.TabIndex = 8;
            // 
            // txtlevels
            // 
            this.txtlevels.Location = new System.Drawing.Point(314, 205);
            this.txtlevels.Name = "txtlevels";
            this.txtlevels.Size = new System.Drawing.Size(314, 35);
            this.txtlevels.TabIndex = 9;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(314, 269);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(314, 35);
            this.txtfee.TabIndex = 11;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(95, 430);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(159, 68);
            this.btncalculate.TabIndex = 1;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // tnexit
            // 
            this.tnexit.Location = new System.Drawing.Point(487, 430);
            this.tnexit.Name = "tnexit";
            this.tnexit.Size = new System.Drawing.Size(159, 68);
            this.tnexit.TabIndex = 12;
            this.tnexit.Text = "&Exite";
            this.tnexit.UseVisualStyleBackColor = true;
            this.tnexit.Click += new System.EventHandler(this.tnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(274, 430);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(171, 68);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshow.Location = new System.Drawing.Point(43, 322);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(631, 91);
            this.lblshow.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 613);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltransportoption;
        private System.Windows.Forms.Label lblslevel;
        private System.Windows.Forms.Label lblncourse;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.TextBox txtlevels;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button tnexit;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Label lblshow;
    }
}

