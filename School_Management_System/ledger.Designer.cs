﻿namespace School_Management_System
{
    partial class ledger
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
            this.txtledger = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearchforledger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad_id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtledger
            // 
            this.txtledger.Location = new System.Drawing.Point(282, 37);
            this.txtledger.Name = "txtledger";
            this.txtledger.Size = new System.Drawing.Size(100, 20);
            this.txtledger.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 117);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnsearchforledger
            // 
            this.btnsearchforledger.Location = new System.Drawing.Point(413, 35);
            this.btnsearchforledger.Name = "btnsearchforledger";
            this.btnsearchforledger.Size = new System.Drawing.Size(75, 23);
            this.btnsearchforledger.TabIndex = 3;
            this.btnsearchforledger.Text = "Search";
            this.btnsearchforledger.UseVisualStyleBackColor = true;
            this.btnsearchforledger.Click += new System.EventHandler(this.btnsearchforledger_Click);
            // 
            // ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 414);
            this.Controls.Add(this.btnsearchforledger);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtledger);
            this.Controls.Add(this.label1);
            this.Name = "ledger";
            this.Text = "ledger";
            this.Load += new System.EventHandler(this.ledger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtledger;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearchforledger;
    }
}