namespace ShopriteInventoryManagement
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxShopriteLogo = new System.Windows.Forms.PictureBox();
            this.labelFname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAttendant = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.textBoxConfirmPword = new System.Windows.Forms.TextBox();
            this.textBoxPword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPword = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelCpword = new System.Windows.Forms.Label();
            this.labelPword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopriteLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(166, 54);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(390, 35);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxShopriteLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 154);
            this.panel1.TabIndex = 5;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkRed;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(950, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(34, 32);
            this.labelClose.TabIndex = 4;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATE A USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxShopriteLogo
            // 
            this.pictureBoxShopriteLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxShopriteLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShopriteLogo.Image")));
            this.pictureBoxShopriteLogo.Location = new System.Drawing.Point(11, 14);
            this.pictureBoxShopriteLogo.Name = "pictureBoxShopriteLogo";
            this.pictureBoxShopriteLogo.Size = new System.Drawing.Size(88, 86);
            this.pictureBoxShopriteLogo.TabIndex = 1;
            this.pictureBoxShopriteLogo.TabStop = false;
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(42, 60);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(94, 24);
            this.labelFname.TabIndex = 6;
            this.labelFname.Text = "Full Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDOB);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelTelephoneNumber);
            this.groupBox1.Controls.Add(this.textBoxPhone);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.textBoxConfirmPword);
            this.groupBox1.Controls.Add(this.textBoxPword);
            this.groupBox1.Controls.Add(this.checkBoxShowPword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.genderGroupBox);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.labelDOB);
            this.groupBox1.Controls.Add(this.labelCpword);
            this.groupBox1.Controls.Add(this.labelPword);
            this.groupBox1.Controls.Add(this.labelFname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 1035);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter All Fields";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAttendant);
            this.groupBox2.Controls.Add(this.radioButtonAdmin);
            this.groupBox2.Location = new System.Drawing.Point(46, 703);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role";
            // 
            // radioButtonAttendant
            // 
            this.radioButtonAttendant.AutoSize = true;
            this.radioButtonAttendant.Location = new System.Drawing.Point(26, 41);
            this.radioButtonAttendant.Name = "radioButtonAttendant";
            this.radioButtonAttendant.Size = new System.Drawing.Size(119, 28);
            this.radioButtonAttendant.TabIndex = 21;
            this.radioButtonAttendant.TabStop = true;
            this.radioButtonAttendant.Text = "Attendant";
            this.radioButtonAttendant.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(264, 41);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(90, 28);
            this.radioButtonAdmin.TabIndex = 22;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.AutoSize = true;
            this.labelTelephoneNumber.Location = new System.Drawing.Point(42, 306);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(103, 24);
            this.labelTelephoneNumber.TabIndex = 35;
            this.labelTelephoneNumber.Text = "Telephone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(166, 303);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(390, 35);
            this.textBoxPhone.TabIndex = 34;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(42, 427);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(107, 24);
            this.labelID.TabIndex = 33;
            this.labelID.Text = "ID Number:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(166, 424);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(390, 35);
            this.textBoxID.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 360);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(166, 357);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(390, 35);
            this.textBoxEmail.TabIndex = 30;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Red;
            this.submitButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(238, 914);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(200, 52);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "ADD";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // textBoxConfirmPword
            // 
            this.textBoxConfirmPword.Location = new System.Drawing.Point(225, 624);
            this.textBoxConfirmPword.Name = "textBoxConfirmPword";
            this.textBoxConfirmPword.Size = new System.Drawing.Size(390, 32);
            this.textBoxConfirmPword.TabIndex = 28;
            this.textBoxConfirmPword.UseSystemPasswordChar = true;
            this.textBoxConfirmPword.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // textBoxPword
            // 
            this.textBoxPword.Location = new System.Drawing.Point(225, 558);
            this.textBoxPword.Name = "textBoxPword";
            this.textBoxPword.Size = new System.Drawing.Size(390, 32);
            this.textBoxPword.TabIndex = 27;
            this.textBoxPword.UseSystemPasswordChar = true;
            this.textBoxPword.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // checkBoxShowPword
            // 
            this.checkBoxShowPword.AutoSize = true;
            this.checkBoxShowPword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxShowPword.Location = new System.Drawing.Point(464, 830);
            this.checkBoxShowPword.Name = "checkBoxShowPword";
            this.checkBoxShowPword.Size = new System.Drawing.Size(168, 28);
            this.checkBoxShowPword.TabIndex = 26;
            this.checkBoxShowPword.Text = "Show Password";
            this.checkBoxShowPword.UseVisualStyleBackColor = true;
            this.checkBoxShowPword.CheckedChanged += new System.EventHandler(this.checkBoxShowPword_CheckedChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(225, 497);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(390, 35);
            this.textBoxUsername.TabIndex = 25;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.radioBtnMale);
            this.genderGroupBox.Controls.Add(this.radioBtnFemale);
            this.genderGroupBox.Location = new System.Drawing.Point(20, 182);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(405, 100);
            this.genderGroupBox.TabIndex = 23;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(26, 41);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(77, 28);
            this.radioBtnMale.TabIndex = 21;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(264, 41);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(95, 28);
            this.radioBtnFemale.TabIndex = 22;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            this.radioBtnFemale.CheckedChanged += new System.EventHandler(this.radioBtnFemale_CheckedChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(47, 500);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 24);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(42, 127);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(118, 24);
            this.labelDOB.TabIndex = 15;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelCpword
            // 
            this.labelCpword.AutoSize = true;
            this.labelCpword.Location = new System.Drawing.Point(47, 627);
            this.labelCpword.Name = "labelCpword";
            this.labelCpword.Size = new System.Drawing.Size(169, 24);
            this.labelCpword.TabIndex = 14;
            this.labelCpword.Text = "Confirm Password:";
            this.labelCpword.Click += new System.EventHandler(this.labelCpword_Click);
            // 
            // labelPword
            // 
            this.labelPword.AutoSize = true;
            this.labelPword.Location = new System.Drawing.Point(47, 558);
            this.labelPword.Name = "labelPword";
            this.labelPword.Size = new System.Drawing.Size(97, 24);
            this.labelPword.TabIndex = 11;
            this.labelPword.Text = "Password:";
            this.labelPword.Click += new System.EventHandler(this.labelPword_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(1, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 77);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(166, 124);
            this.textBoxDOB.Multiline = true;
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(165, 35);
            this.textBoxDOB.TabIndex = 36;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1010, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopriteLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxShopriteLogo;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelCpword;
        private System.Windows.Forms.Label labelPword;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxShowPword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPword;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox textBoxPword;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAttendant;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.TextBox textBoxDOB;
    }
}