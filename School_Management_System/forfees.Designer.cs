namespace School_Management_System
{
    partial class forfees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadid = new System.Windows.Forms.TextBox();
            this.txtfamount = new System.Windows.Forms.TextBox();
            this.txtfdate = new System.Windows.Forms.TextBox();
            this.txtfby = new System.Windows.Forms.TextBox();
            this.txtftype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadnameforsearch = new System.Windows.Forms.TextBox();
            this.txtadclassforupdat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Updates";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admission ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fees Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fees Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fees Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fees Recieved By :";
            // 
            // txtadid
            // 
            this.txtadid.Location = new System.Drawing.Point(137, 68);
            this.txtadid.Name = "txtadid";
            this.txtadid.Size = new System.Drawing.Size(121, 23);
            this.txtadid.TabIndex = 8;
            // 
            // txtfamount
            // 
            this.txtfamount.Location = new System.Drawing.Point(137, 326);
            this.txtfamount.Name = "txtfamount";
            this.txtfamount.Size = new System.Drawing.Size(121, 23);
            this.txtfamount.TabIndex = 9;
            // 
            // txtfdate
            // 
            this.txtfdate.Location = new System.Drawing.Point(585, 280);
            this.txtfdate.Name = "txtfdate";
            this.txtfdate.Size = new System.Drawing.Size(121, 23);
            this.txtfdate.TabIndex = 10;
            // 
            // txtfby
            // 
            this.txtfby.Location = new System.Drawing.Point(585, 326);
            this.txtfby.Name = "txtfby";
            this.txtfby.Size = new System.Drawing.Size(121, 23);
            this.txtfby.TabIndex = 11;
            // 
            // txtftype
            // 
            this.txtftype.FormattingEnabled = true;
            this.txtftype.Items.AddRange(new object[] {
            "Monthly",
            "Annual"});
            this.txtftype.Location = new System.Drawing.Point(137, 280);
            this.txtftype.Name = "txtftype";
            this.txtftype.Size = new System.Drawing.Size(121, 23);
            this.txtftype.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(358, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // txtadnameforsearch
            // 
            this.txtadnameforsearch.Location = new System.Drawing.Point(505, 68);
            this.txtadnameforsearch.Name = "txtadnameforsearch";
            this.txtadnameforsearch.Size = new System.Drawing.Size(171, 23);
            this.txtadnameforsearch.TabIndex = 15;
            this.txtadnameforsearch.TextChanged += new System.EventHandler(this.txtadnameforsearch_TextChanged);
            // 
            // txtadclassforupdat
            // 
            this.txtadclassforupdat.Location = new System.Drawing.Point(137, 122);
            this.txtadclassforupdat.Name = "txtadclassforupdat";
            this.txtadclassforupdat.Size = new System.Drawing.Size(121, 23);
            this.txtadclassforupdat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Class :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // forfees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 418);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtadclassforupdat);
            this.Controls.Add(this.txtadnameforsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtftype);
            this.Controls.Add(this.txtfby);
            this.Controls.Add(this.txtfdate);
            this.Controls.Add(this.txtfamount);
            this.Controls.Add(this.txtadid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "forfees";
            this.Text = "forfees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadid;
        private System.Windows.Forms.TextBox txtfamount;
        private System.Windows.Forms.TextBox txtfdate;
        private System.Windows.Forms.TextBox txtfby;
        private System.Windows.Forms.ComboBox txtftype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadnameforsearch;
        private System.Windows.Forms.TextBox txtadclassforupdat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}