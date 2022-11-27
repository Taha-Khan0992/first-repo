namespace School_Management_System
{
    partial class Menu
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
            this.btnmenuadmission = new System.Windows.Forms.Button();
            this.btnmenufees = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmenuadmission
            // 
            this.btnmenuadmission.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmenuadmission.Location = new System.Drawing.Point(70, 126);
            this.btnmenuadmission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenuadmission.Name = "btnmenuadmission";
            this.btnmenuadmission.Size = new System.Drawing.Size(124, 49);
            this.btnmenuadmission.TabIndex = 0;
            this.btnmenuadmission.Text = "Admission";
            this.btnmenuadmission.UseVisualStyleBackColor = false;
            this.btnmenuadmission.Click += new System.EventHandler(this.btnmenuadmission_Click);
            // 
            // btnmenufees
            // 
            this.btnmenufees.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnmenufees.Location = new System.Drawing.Point(267, 126);
            this.btnmenufees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnmenufees.Name = "btnmenufees";
            this.btnmenufees.Size = new System.Drawing.Size(121, 49);
            this.btnmenufees.TabIndex = 1;
            this.btnmenufees.Text = "Fees";
            this.btnmenufees.UseVisualStyleBackColor = false;
            this.btnmenufees.Click += new System.EventHandler(this.btnmenufees_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnmenuadmission);
            this.groupBox1.Controls.Add(this.btnmenufees);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(109, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(465, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(169, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnledger";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmenuadmission;
        private System.Windows.Forms.Button btnmenufees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}