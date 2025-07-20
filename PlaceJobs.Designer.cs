using System;
using System.Windows.Forms;

namespace EShiftApp
{
    partial class PlaceJobs
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.txtEndLocation = new System.Windows.Forms.TextBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnPickStart = new System.Windows.Forms.Button();
            this.btnPickEnd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.cmbEndLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(30, 30);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(91, 16);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Location:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(30, 70);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(88, 16);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Location:";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(30, 110);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(109, 16);
            this.lblTransport.TabIndex = 6;
            this.lblTransport.Text = "Select Transport:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(30, 150);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(114, 16);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Product Category:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(30, 190);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(125, 16);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Special Instructions:";
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(160, 27);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(220, 22);
            this.txtStartLocation.TabIndex = 1;
            // 
            // txtEndLocation
            // 
            this.txtEndLocation.Location = new System.Drawing.Point(160, 67);
            this.txtEndLocation.Name = "txtEndLocation";
            this.txtEndLocation.Size = new System.Drawing.Size(220, 22);
            this.txtEndLocation.TabIndex = 4;
            // 
            // cmbTransport
            // 
            this.cmbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransport.Location = new System.Drawing.Point(160, 107);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(220, 24);
            this.cmbTransport.TabIndex = 7;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Location = new System.Drawing.Point(160, 147);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(220, 24);
            this.cmbProduct.TabIndex = 9;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(160, 187);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(220, 60);
            this.txtInstructions.TabIndex = 11;
            this.txtInstructions.TextChanged += new System.EventHandler(this.txtInstructions_TextChanged);
            // 
            // btnPickStart
            // 
            this.btnPickStart.Location = new System.Drawing.Point(390, 27);
            this.btnPickStart.Name = "btnPickStart";
            this.btnPickStart.Size = new System.Drawing.Size(30, 22);
            this.btnPickStart.TabIndex = 2;
            this.btnPickStart.Text = "📍";
            this.btnPickStart.Click += new System.EventHandler(this.btnPickStart_Click);
            // 
            // btnPickEnd
            // 
            this.btnPickEnd.Location = new System.Drawing.Point(390, 67);
            this.btnPickEnd.Name = "btnPickEnd";
            this.btnPickEnd.Size = new System.Drawing.Size(30, 22);
            this.btnPickEnd.TabIndex = 5;
            this.btnPickEnd.Text = "📍";
            this.btnPickEnd.Click += new System.EventHandler(this.btnPickEnd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.Location = new System.Drawing.Point(160, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(220, 35);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Place Job";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(30, 320);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(63, 16);
            this.lblDistance.TabIndex = 13;
            this.lblDistance.Text = "Distance:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 16);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Total Price:";
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.Location = new System.Drawing.Point(0, 0);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(121, 24);
            this.cmbStartLocation.TabIndex = 0;
            // 
            // cmbEndLocation
            // 
            this.cmbEndLocation.Location = new System.Drawing.Point(0, 0);
            this.cmbEndLocation.Name = "cmbEndLocation";
            this.cmbEndLocation.Size = new System.Drawing.Size(121, 24);
            this.cmbEndLocation.TabIndex = 0;
            // 
            // PlaceJobs
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.btnPickStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtEndLocation);
            this.Controls.Add(this.btnPickEnd);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.cmbTransport);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblPrice);
            this.Name = "PlaceJobs";
            this.Text = "Place New Job";
            this.Load += new System.EventHandler(this.PlaceJobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStart;
        private Label lblEnd;
        private Label lblTransport;
        private Label lblProduct;
        private Label lblInstructions;
        private Label lblDistance;
        private Label lblPrice;
        private TextBox txtStartLocation;
        private TextBox txtEndLocation;
        private ComboBox cmbTransport;
        private ComboBox cmbProduct;
        private TextBox txtInstructions;
        private Button btnPickStart;
        private Button btnPickEnd;
        private Button btnSubmit;
        private ComboBox cmbStartLocation;
        private ComboBox cmbEndLocation;
    }
}
