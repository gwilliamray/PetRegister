namespace PetRegister
{
    partial class PetForm
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
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtPetBreed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.chkVaccinated = new System.Windows.Forms.CheckBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnPetAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoDog = new System.Windows.Forms.RadioButton();
            this.rdoCat = new System.Windows.Forms.RadioButton();
            this.pnlDog = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSchool = new System.Windows.Forms.CheckBox();
            this.txtDogsJob = new System.Windows.Forms.TextBox();
            this.pnlCat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFurType = new System.Windows.Forms.ComboBox();
            this.chkDeclawed = new System.Windows.Forms.CheckBox();
            this.chkIsFixed = new System.Windows.Forms.CheckBox();
            this.pnlDog.SuspendLayout();
            this.pnlCat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(122, 80);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(100, 20);
            this.txtPetName.TabIndex = 0;
            // 
            // txtPetBreed
            // 
            this.txtPetBreed.Location = new System.Drawing.Point(122, 117);
            this.txtPetBreed.Name = "txtPetBreed";
            this.txtPetBreed.Size = new System.Drawing.Size(100, 20);
            this.txtPetBreed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pet Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboSex.Location = new System.Drawing.Point(278, 79);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(100, 21);
            this.cboSex.TabIndex = 8;
            // 
            // chkVaccinated
            // 
            this.chkVaccinated.AutoSize = true;
            this.chkVaccinated.Location = new System.Drawing.Point(250, 123);
            this.chkVaccinated.Name = "chkVaccinated";
            this.chkVaccinated.Size = new System.Drawing.Size(80, 17);
            this.chkVaccinated.TabIndex = 9;
            this.chkVaccinated.Text = "Vaccinated";
            this.chkVaccinated.UseVisualStyleBackColor = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(31, 24);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(35, 13);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "label4";
            // 
            // btnPetAction
            // 
            this.btnPetAction.Location = new System.Drawing.Point(386, 347);
            this.btnPetAction.Name = "btnPetAction";
            this.btnPetAction.Size = new System.Drawing.Size(75, 23);
            this.btnPetAction.TabIndex = 11;
            this.btnPetAction.Text = "Add Pet";
            this.btnPetAction.UseVisualStyleBackColor = true;
            this.btnPetAction.Click += new System.EventHandler(this.btnPetAction_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(86, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoDog
            // 
            this.rdoDog.AutoSize = true;
            this.rdoDog.Location = new System.Drawing.Point(457, 80);
            this.rdoDog.Name = "rdoDog";
            this.rdoDog.Size = new System.Drawing.Size(45, 17);
            this.rdoDog.TabIndex = 13;
            this.rdoDog.TabStop = true;
            this.rdoDog.Text = "Dog";
            this.rdoDog.UseVisualStyleBackColor = true;
            this.rdoDog.CheckedChanged += new System.EventHandler(this.rdoDog_CheckedChanged);
            // 
            // rdoCat
            // 
            this.rdoCat.AutoSize = true;
            this.rdoCat.Location = new System.Drawing.Point(457, 123);
            this.rdoCat.Name = "rdoCat";
            this.rdoCat.Size = new System.Drawing.Size(41, 17);
            this.rdoCat.TabIndex = 14;
            this.rdoCat.TabStop = true;
            this.rdoCat.Text = "Cat";
            this.rdoCat.UseVisualStyleBackColor = true;
            // 
            // pnlDog
            // 
            this.pnlDog.Controls.Add(this.label4);
            this.pnlDog.Controls.Add(this.chkSchool);
            this.pnlDog.Controls.Add(this.txtDogsJob);
            this.pnlDog.Location = new System.Drawing.Point(300, 175);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(200, 100);
            this.pnlDog.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dogs Job";
            // 
            // chkSchool
            // 
            this.chkSchool.AutoSize = true;
            this.chkSchool.Location = new System.Drawing.Point(41, 59);
            this.chkSchool.Name = "chkSchool";
            this.chkSchool.Size = new System.Drawing.Size(114, 17);
            this.chkSchool.TabIndex = 1;
            this.chkSchool.Text = "Obediance School";
            this.chkSchool.UseVisualStyleBackColor = true;
            // 
            // txtDogsJob
            // 
            this.txtDogsJob.Location = new System.Drawing.Point(79, 19);
            this.txtDogsJob.Name = "txtDogsJob";
            this.txtDogsJob.Size = new System.Drawing.Size(100, 20);
            this.txtDogsJob.TabIndex = 0;
            // 
            // pnlCat
            // 
            this.pnlCat.Controls.Add(this.label5);
            this.pnlCat.Controls.Add(this.cboFurType);
            this.pnlCat.Controls.Add(this.chkDeclawed);
            this.pnlCat.Location = new System.Drawing.Point(300, 175);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(200, 100);
            this.pnlCat.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fur type";
            // 
            // cboFurType
            // 
            this.cboFurType.FormattingEnabled = true;
            this.cboFurType.Items.AddRange(new object[] {
            "Short hair",
            "Long hair",
            "Hairless"});
            this.cboFurType.Location = new System.Drawing.Point(64, 18);
            this.cboFurType.Name = "cboFurType";
            this.cboFurType.Size = new System.Drawing.Size(121, 21);
            this.cboFurType.TabIndex = 1;
            this.cboFurType.SelectedIndexChanged += new System.EventHandler(this.cboFurType_SelectedIndexChanged);
            // 
            // chkDeclawed
            // 
            this.chkDeclawed.AutoSize = true;
            this.chkDeclawed.Location = new System.Drawing.Point(48, 59);
            this.chkDeclawed.Name = "chkDeclawed";
            this.chkDeclawed.Size = new System.Drawing.Size(74, 17);
            this.chkDeclawed.TabIndex = 0;
            this.chkDeclawed.Text = "Declawed";
            this.chkDeclawed.UseVisualStyleBackColor = true;
            // 
            // chkIsFixed
            // 
            this.chkIsFixed.AutoSize = true;
            this.chkIsFixed.Location = new System.Drawing.Point(348, 124);
            this.chkIsFixed.Name = "chkIsFixed";
            this.chkIsFixed.Size = new System.Drawing.Size(81, 17);
            this.chkIsFixed.TabIndex = 17;
            this.chkIsFixed.Text = "Is Neutered";
            this.chkIsFixed.UseVisualStyleBackColor = true;
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 406);
            this.Controls.Add(this.chkIsFixed);
            this.Controls.Add(this.pnlCat);
            this.Controls.Add(this.pnlDog);
            this.Controls.Add(this.rdoCat);
            this.Controls.Add(this.rdoDog);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPetAction);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.chkVaccinated);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPetBreed);
            this.Controls.Add(this.txtPetName);
            this.Name = "PetForm";
            this.Text = "PetForm";
            this.pnlDog.ResumeLayout(false);
            this.pnlDog.PerformLayout();
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtPetBreed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.CheckBox chkVaccinated;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnPetAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoDog;
        private System.Windows.Forms.RadioButton rdoCat;
        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSchool;
        private System.Windows.Forms.TextBox txtDogsJob;
        private System.Windows.Forms.Panel pnlCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFurType;
        private System.Windows.Forms.CheckBox chkDeclawed;
        private System.Windows.Forms.CheckBox chkIsFixed;
    }
}