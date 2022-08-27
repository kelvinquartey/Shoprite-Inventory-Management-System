namespace ShopriteInventoryManagement
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInvent = new System.Windows.Forms.Label();
            this.pictureBoxShopriteLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonManageProducts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopriteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelInvent);
            this.panel1.Controls.Add(this.pictureBoxShopriteLogo);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 137);
            this.panel1.TabIndex = 0;
            // 
            // labelInvent
            // 
            this.labelInvent.AutoSize = true;
            this.labelInvent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvent.ForeColor = System.Drawing.Color.White;
            this.labelInvent.Location = new System.Drawing.Point(416, 96);
            this.labelInvent.Name = "labelInvent";
            this.labelInvent.Size = new System.Drawing.Size(374, 29);
            this.labelInvent.TabIndex = 3;
            this.labelInvent.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.labelInvent.Click += new System.EventHandler(this.labelInvent_Click);
            // 
            // pictureBoxShopriteLogo
            // 
            this.pictureBoxShopriteLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxShopriteLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShopriteLogo.Image")));
            this.pictureBoxShopriteLogo.Location = new System.Drawing.Point(558, 7);
            this.pictureBoxShopriteLogo.Name = "pictureBoxShopriteLogo";
            this.pictureBoxShopriteLogo.Size = new System.Drawing.Size(88, 86);
            this.pictureBoxShopriteLogo.TabIndex = 2;
            this.pictureBoxShopriteLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1043, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.BackColor = System.Drawing.Color.Red;
            this.buttonManageUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonManageUsers.BackgroundImage")));
            this.buttonManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonManageUsers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageUsers.ForeColor = System.Drawing.Color.Black;
            this.buttonManageUsers.Location = new System.Drawing.Point(147, 198);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(187, 193);
            this.buttonManageUsers.TabIndex = 4;
            this.buttonManageUsers.Text = "MANAGE USERS";
            this.buttonManageUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonManageUsers.UseVisualStyleBackColor = false;
            this.buttonManageUsers.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(850, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 193);
            this.button2.TabIndex = 5;
            this.button2.Text = "MANAGE STOCKS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonManageProducts
            // 
            this.buttonManageProducts.BackColor = System.Drawing.Color.Red;
            this.buttonManageProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonManageProducts.BackgroundImage")));
            this.buttonManageProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonManageProducts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageProducts.ForeColor = System.Drawing.Color.Black;
            this.buttonManageProducts.Location = new System.Drawing.Point(509, 453);
            this.buttonManageProducts.Name = "buttonManageProducts";
            this.buttonManageProducts.Size = new System.Drawing.Size(187, 163);
            this.buttonManageProducts.TabIndex = 6;
            this.buttonManageProducts.Text = "MANAGE PRODUCTS";
            this.buttonManageProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonManageProducts.UseVisualStyleBackColor = false;
            this.buttonManageProducts.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 671);
            this.Controls.Add(this.buttonManageProducts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonManageUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShopriteLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInvent;
        private System.Windows.Forms.PictureBox pictureBoxShopriteLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonManageProducts;
    }
}