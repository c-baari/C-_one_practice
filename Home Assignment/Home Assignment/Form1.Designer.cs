namespace Home_Assignment
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
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.lbldayoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lbldayofthemonth = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshowoutput = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtyear
            // 
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(503, 208);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(325, 35);
            this.txtyear.TabIndex = 0;
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(503, 79);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(325, 35);
            this.txtdayoftheweek.TabIndex = 1;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(503, 121);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(325, 35);
            this.txtmonth.TabIndex = 2;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdayofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayofthemonth.Location = new System.Drawing.Point(503, 164);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(325, 35);
            this.txtdayofthemonth.TabIndex = 3;
            // 
            // lbldayoftheweek
            // 
            this.lbldayoftheweek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayoftheweek.Location = new System.Drawing.Point(203, 82);
            this.lbldayoftheweek.Name = "lbldayoftheweek";
            this.lbldayoftheweek.Size = new System.Drawing.Size(285, 34);
            this.lbldayoftheweek.TabIndex = 4;
            this.lbldayoftheweek.Text = "Enter the day of the week: ";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(170, 126);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(318, 41);
            this.lblnameofthemonth.TabIndex = 5;
            this.lblnameofthemonth.Text = "Enter the name of the month: ";
            this.lblnameofthemonth.Click += new System.EventHandler(this.lblnameofthemonth_Click);
            // 
            // lbldayofthemonth
            // 
            this.lbldayofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofthemonth.Location = new System.Drawing.Point(79, 169);
            this.lbldayofthemonth.Name = "lbldayofthemonth";
            this.lbldayofthemonth.Size = new System.Drawing.Size(409, 36);
            this.lbldayofthemonth.TabIndex = 6;
            this.lbldayofthemonth.Text = "Enter the numeric name of the month: ";
            // 
            // lblyear
            // 
            this.lblyear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(312, 210);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(176, 44);
            this.lblyear.TabIndex = 7;
            this.lblyear.Text = "Enter the year:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(89, 254);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(853, 64);
            this.lbloutput.TabIndex = 8;
            // 
            // btnshowoutput
            // 
            this.btnshowoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowoutput.Location = new System.Drawing.Point(89, 338);
            this.btnshowoutput.Name = "btnshowoutput";
            this.btnshowoutput.Size = new System.Drawing.Size(229, 41);
            this.btnshowoutput.TabIndex = 9;
            this.btnshowoutput.Text = "Show Date";
            this.btnshowoutput.UseVisualStyleBackColor = true;
            this.btnshowoutput.Click += new System.EventHandler(this.btnshowoutput_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(425, 338);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(229, 41);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(713, 338);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(229, 41);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 574);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowoutput);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lbldayofthemonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbldayoftheweek);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.txtyear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.Label lbldayoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lbldayofthemonth;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshowoutput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

