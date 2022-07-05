using System;

namespace Log_in
{
    partial class HOMEPAGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOMEPAGE));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.showToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.requestToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.existToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1672, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBankToolStripMenuItem,
            this.addToolStripMenuItem1,
            this.addCustomerToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addBankToolStripMenuItem
            // 
            this.addBankToolStripMenuItem.Name = "addBankToolStripMenuItem";
            this.addBankToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.addBankToolStripMenuItem.Text = "Add Bank";
            this.addBankToolStripMenuItem.Click += new System.EventHandler(this.addBankToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(250, 34);
            this.addToolStripMenuItem1.Text = "Add Bank branch";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfLoanToolStripMenuItem,
            this.listOfCustomerToolStripMenuItem,
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // listOfLoanToolStripMenuItem
            // 
            this.listOfLoanToolStripMenuItem.Name = "listOfLoanToolStripMenuItem";
            this.listOfLoanToolStripMenuItem.Size = new System.Drawing.Size(542, 34);
            this.listOfLoanToolStripMenuItem.Text = "List of Loan";
            this.listOfLoanToolStripMenuItem.Click += new System.EventHandler(this.listOfLoanToolStripMenuItem_Click);
            // 
            // listOfCustomerToolStripMenuItem
            // 
            this.listOfCustomerToolStripMenuItem.Name = "listOfCustomerToolStripMenuItem";
            this.listOfCustomerToolStripMenuItem.Size = new System.Drawing.Size(542, 34);
            this.listOfCustomerToolStripMenuItem.Text = "List of Customer";
            this.listOfCustomerToolStripMenuItem.Click += new System.EventHandler(this.listOfCustomerToolStripMenuItem_Click);
            // 
            // listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem
            // 
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem.Name = "listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem";
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem.Size = new System.Drawing.Size(542, 34);
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem.Text = "List of loans with customer name and employee name";
            this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem.Click += new System.EventHandler(this.listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem_Click_1);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestLoanToolStripMenuItem});
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.requestToolStripMenuItem.Text = "Loan";
            // 
            // requestLoanToolStripMenuItem
            // 
            this.requestLoanToolStripMenuItem.Name = "requestLoanToolStripMenuItem";
            this.requestLoanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.requestLoanToolStripMenuItem.Text = "Request loan";
            this.requestLoanToolStripMenuItem.Click += new System.EventHandler(this.requestLoanToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.existToolStripMenuItem.Text = "Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(450, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome In the Bank System";
            // 
            // HOMEPAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1672, 922);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HOMEPAGE";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HOMEPAGE_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private EventHandler listOfLoansWithCustomerNameAndEmployeeNameToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestLoanToolStripMenuItem;
        private EventHandler requestToolStripMenuItem_Click;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
    }
}