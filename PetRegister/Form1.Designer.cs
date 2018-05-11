namespace PetRegister
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.lstPets = new System.Windows.Forms.ListBox();
            this.lstLicence = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(33, 46);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(472, 134);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSize = true;
            this.btnAddCustomer.Location = new System.Drawing.Point(565, 56);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(111, 23);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(565, 98);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(111, 23);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(565, 143);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(111, 23);
            this.btnAddPet.TabIndex = 3;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // lstPets
            // 
            this.lstPets.FormattingEnabled = true;
            this.lstPets.Location = new System.Drawing.Point(33, 212);
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(472, 160);
            this.lstPets.TabIndex = 4;
            this.lstPets.SelectedIndexChanged += new System.EventHandler(this.lstPets_SelectedIndexChanged);
            // 
            // lstLicence
            // 
            this.lstLicence.FormattingEnabled = true;
            this.lstLicence.Location = new System.Drawing.Point(553, 212);
            this.lstLicence.Name = "lstLicence";
            this.lstLicence.Size = new System.Drawing.Size(155, 160);
            this.lstLicence.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 399);
            this.Controls.Add(this.lstLicence);
            this.Controls.Add(this.lstPets);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lstCustomers);
            this.Name = "Form1";
            this.Text = "Pet Registry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.ListBox lstPets;
        private System.Windows.Forms.ListBox lstLicence;
    }
}

