namespace AddressAllisonC
{
    partial class frmAddress
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtAppartement = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblAppartement = new System.Windows.Forms.Label();
            this.lblbCity = new System.Windows.Forms.Label();
            this.txtprovince = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.lblprovince = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEnter.Location = new System.Drawing.Point(127, 295);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtAppartement
            // 
            this.txtAppartement.Location = new System.Drawing.Point(215, 49);
            this.txtAppartement.Name = "txtAppartement";
            this.txtAppartement.Size = new System.Drawing.Size(100, 20);
            this.txtAppartement.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(215, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(215, 95);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblStreet.Location = new System.Drawing.Point(12, 95);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(157, 16);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Enter your street name";
            // 
            // lblAppartement
            // 
            this.lblAppartement.AutoSize = true;
            this.lblAppartement.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblAppartement.Location = new System.Drawing.Point(12, 49);
            this.lblAppartement.Name = "lblAppartement";
            this.lblAppartement.Size = new System.Drawing.Size(190, 16);
            this.lblAppartement.TabIndex = 5;
            this.lblAppartement.Text = "Enter your Appartement No";
            // 
            // lblbCity
            // 
            this.lblbCity.AutoSize = true;
            this.lblbCity.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblbCity.Location = new System.Drawing.Point(12, 150);
            this.lblbCity.Name = "lblbCity";
            this.lblbCity.Size = new System.Drawing.Size(106, 16);
            this.lblbCity.TabIndex = 6;
            this.lblbCity.Text = "Enter your city";
            // 
            // txtprovince
            // 
            this.txtprovince.Location = new System.Drawing.Point(215, 197);
            this.txtprovince.Name = "txtprovince";
            this.txtprovince.Size = new System.Drawing.Size(100, 20);
            this.txtprovince.TabIndex = 7;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(215, 243);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(100, 20);
            this.txtPostal.TabIndex = 8;
            // 
            // lblprovince
            // 
            this.lblprovince.AutoSize = true;
            this.lblprovince.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblprovince.Location = new System.Drawing.Point(12, 201);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(138, 16);
            this.lblprovince.TabIndex = 9;
            this.lblprovince.Text = "Enter your province";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPostal.Location = new System.Drawing.Point(12, 243);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(154, 16);
            this.lblPostal.TabIndex = 10;
            this.lblPostal.Text = "Enter your postal code";
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(327, 337);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.lblprovince);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.txtprovince);
            this.Controls.Add(this.lblbCity);
            this.Controls.Add(this.lblAppartement);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAppartement);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmAddress";
            this.Text = "Address Program by Allison C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtAppartement;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblAppartement;
        private System.Windows.Forms.Label lblbCity;
        private System.Windows.Forms.TextBox txtprovince;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label lblprovince;
        private System.Windows.Forms.Label lblPostal;
    }
}

