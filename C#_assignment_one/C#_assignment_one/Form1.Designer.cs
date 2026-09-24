namespace C__assignment_one
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbldepartmet = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(68, 57);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(265, 26);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name: ";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(121, 179);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(212, 26);
            this.lblsemester.TabIndex = 1;
            this.lblsemester.Text = "Enter the semester:";
            this.lblsemester.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldepartmet
            // 
            this.lbldepartmet.AutoSize = true;
            this.lbldepartmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartmet.Location = new System.Drawing.Point(91, 139);
            this.lbldepartmet.Name = "lbldepartmet";
            this.lbldepartmet.Size = new System.Drawing.Size(242, 26);
            this.lbldepartmet.TabIndex = 2;
            this.lbldepartmet.Text = "Enter the department:";
            this.lbldepartmet.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(103, 98);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(230, 26);
            this.lblstudentid.TabIndex = 3;
            this.lblstudentid.Text = "Enter the student ID:";
            this.lblstudentid.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(73, 229);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(610, 57);
            this.lbloutput.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(339, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(307, 35);
            this.txtname.TabIndex = 5;
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemester.Location = new System.Drawing.Point(339, 181);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(307, 35);
            this.txtsemester.TabIndex = 6;
            // 
            // txtdept
            // 
            this.txtdept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdept.Location = new System.Drawing.Point(339, 139);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(307, 35);
            this.txtdept.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(339, 98);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(307, 35);
            this.txtid.TabIndex = 8;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(73, 306);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(186, 39);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "show information";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(500, 306);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(183, 39);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(297, 306);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(169, 39);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lbldepartmet);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbldepartmet;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
    }
}

