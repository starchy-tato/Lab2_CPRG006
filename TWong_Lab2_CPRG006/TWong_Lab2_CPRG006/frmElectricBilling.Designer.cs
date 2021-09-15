
namespace TWong_Lab2_CPRG006
{
    partial class frmElectricBilling
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.grpboxCust = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKWHUsed = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblBillAmt = new System.Windows.Forms.Label();
            this.lblAcctNoDisplay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxStats = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvgBillAmt = new System.Windows.Forms.Label();
            this.lblKWHUsed = new System.Windows.Forms.Label();
            this.lblCustAmt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpboxCust.SuspendLayout();
            this.grpboxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.Color.Thistle;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 20;
            this.lstCustomer.Location = new System.Drawing.Point(352, 48);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(367, 364);
            this.lstCustomer.TabIndex = 0;
            this.lstCustomer.Click += new System.EventHandler(this.lstCustomer_Click);
            // 
            // grpboxCust
            // 
            this.grpboxCust.Controls.Add(this.btnClear);
            this.grpboxCust.Controls.Add(this.btnAdd);
            this.grpboxCust.Controls.Add(this.txtKWHUsed);
            this.grpboxCust.Controls.Add(this.txtLname);
            this.grpboxCust.Controls.Add(this.txtFname);
            this.grpboxCust.Controls.Add(this.lblBillAmt);
            this.grpboxCust.Controls.Add(this.lblAcctNoDisplay);
            this.grpboxCust.Controls.Add(this.label7);
            this.grpboxCust.Controls.Add(this.label3);
            this.grpboxCust.Controls.Add(this.label2);
            this.grpboxCust.Controls.Add(this.label4);
            this.grpboxCust.Controls.Add(this.label1);
            this.grpboxCust.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpboxCust.Location = new System.Drawing.Point(12, 12);
            this.grpboxCust.Name = "grpboxCust";
            this.grpboxCust.Size = new System.Drawing.Size(319, 304);
            this.grpboxCust.TabIndex = 1;
            this.grpboxCust.TabStop = false;
            this.grpboxCust.Text = "New Customer";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(207, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(105, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKWHUsed
            // 
            this.txtKWHUsed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKWHUsed.Location = new System.Drawing.Point(105, 166);
            this.txtKWHUsed.Name = "txtKWHUsed";
            this.txtKWHUsed.Size = new System.Drawing.Size(121, 27);
            this.txtKWHUsed.TabIndex = 3;
            this.txtKWHUsed.Tag = "kWh amount";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLname.Location = new System.Drawing.Point(105, 124);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(200, 27);
            this.txtLname.TabIndex = 2;
            this.txtLname.Tag = "Last name";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFname.Location = new System.Drawing.Point(105, 80);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(200, 27);
            this.txtFname.TabIndex = 1;
            this.txtFname.Tag = "First name";
            // 
            // lblBillAmt
            // 
            this.lblBillAmt.BackColor = System.Drawing.Color.Thistle;
            this.lblBillAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBillAmt.Location = new System.Drawing.Point(105, 208);
            this.lblBillAmt.Name = "lblBillAmt";
            this.lblBillAmt.Size = new System.Drawing.Size(121, 29);
            this.lblBillAmt.TabIndex = 0;
            this.lblBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcctNoDisplay
            // 
            this.lblAcctNoDisplay.BackColor = System.Drawing.Color.Thistle;
            this.lblAcctNoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAcctNoDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcctNoDisplay.Location = new System.Drawing.Point(116, 36);
            this.lblAcctNoDisplay.Name = "lblAcctNoDisplay";
            this.lblAcctNoDisplay.Size = new System.Drawing.Size(75, 29);
            this.lblAcctNoDisplay.TabIndex = 0;
            this.lblAcctNoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bill Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "kWh Used:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // grpboxStats
            // 
            this.grpboxStats.Controls.Add(this.label11);
            this.grpboxStats.Controls.Add(this.label5);
            this.grpboxStats.Controls.Add(this.label6);
            this.grpboxStats.Controls.Add(this.lblAvgBillAmt);
            this.grpboxStats.Controls.Add(this.lblKWHUsed);
            this.grpboxStats.Controls.Add(this.lblCustAmt);
            this.grpboxStats.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpboxStats.Location = new System.Drawing.Point(12, 322);
            this.grpboxStats.Name = "grpboxStats";
            this.grpboxStats.Size = new System.Drawing.Size(319, 164);
            this.grpboxStats.TabIndex = 1;
            this.grpboxStats.TabStop = false;
            this.grpboxStats.Text = "Statistics";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(17, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Average bill amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total # kWh Used:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "# Customers Processed:";
            // 
            // lblAvgBillAmt
            // 
            this.lblAvgBillAmt.BackColor = System.Drawing.Color.Thistle;
            this.lblAvgBillAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgBillAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvgBillAmt.Location = new System.Drawing.Point(196, 124);
            this.lblAvgBillAmt.Name = "lblAvgBillAmt";
            this.lblAvgBillAmt.Size = new System.Drawing.Size(109, 29);
            this.lblAvgBillAmt.TabIndex = 0;
            this.lblAvgBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKWHUsed
            // 
            this.lblKWHUsed.BackColor = System.Drawing.Color.Thistle;
            this.lblKWHUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKWHUsed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKWHUsed.Location = new System.Drawing.Point(196, 78);
            this.lblKWHUsed.Name = "lblKWHUsed";
            this.lblKWHUsed.Size = new System.Drawing.Size(109, 29);
            this.lblKWHUsed.TabIndex = 0;
            this.lblKWHUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustAmt
            // 
            this.lblCustAmt.BackColor = System.Drawing.Color.Thistle;
            this.lblCustAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustAmt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustAmt.Location = new System.Drawing.Point(196, 34);
            this.lblCustAmt.Name = "lblCustAmt";
            this.lblCustAmt.Size = new System.Drawing.Size(109, 29);
            this.lblCustAmt.TabIndex = 0;
            this.lblCustAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(352, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Data:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(644, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmElectricBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(745, 504);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpboxStats);
            this.Controls.Add(this.grpboxCust);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmElectricBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electric Billing";
            this.Load += new System.EventHandler(this.frmElectricBilling_Load);
            this.grpboxCust.ResumeLayout(false);
            this.grpboxCust.PerformLayout();
            this.grpboxStats.ResumeLayout(false);
            this.grpboxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.GroupBox grpboxCust;
        private System.Windows.Forms.TextBox txtKWHUsed;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblAcctNoDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxStats;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAvgBillAmt;
        private System.Windows.Forms.Label lblKWHUsed;
        private System.Windows.Forms.Label lblCustAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBillAmt;
        private System.Windows.Forms.Button btnClear;
    }
}

