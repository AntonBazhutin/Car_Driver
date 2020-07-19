namespace CarDriver2
{
    partial class Store
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.btnBack = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.labelYourCoins = new System.Windows.Forms.Label();
            this.imageListCars = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCars = new System.Windows.Forms.PictureBox();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.txtBxMyCoins = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(868, 629);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseMove);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.BackColor = System.Drawing.Color.Transparent;
            this.labelStore.Font = new System.Drawing.Font("Palatino Linotype", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStore.ForeColor = System.Drawing.Color.Yellow;
            this.labelStore.Location = new System.Drawing.Point(362, -2);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(257, 131);
            this.labelStore.TabIndex = 4;
            this.labelStore.Text = "Store";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(457, 585);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(95, 46);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.MouseLeave += new System.EventHandler(this.btnBuy_MouseLeave);
            this.btnBuy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuy_MouseMove);
            // 
            // labelYourCoins
            // 
            this.labelYourCoins.AutoSize = true;
            this.labelYourCoins.BackColor = System.Drawing.Color.Indigo;
            this.labelYourCoins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelYourCoins.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourCoins.ForeColor = System.Drawing.Color.Yellow;
            this.labelYourCoins.Location = new System.Drawing.Point(768, 9);
            this.labelYourCoins.Name = "labelYourCoins";
            this.labelYourCoins.Size = new System.Drawing.Size(119, 45);
            this.labelYourCoins.TabIndex = 18;
            this.labelYourCoins.Text = "Coins :";
            // 
            // imageListCars
            // 
            this.imageListCars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCars.ImageStream")));
            this.imageListCars.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCars.Images.SetKeyName(0, "Blue Mustang irl.jpg");
            this.imageListCars.Images.SetKeyName(1, "Green Cabrio irl.jpg");
            this.imageListCars.Images.SetKeyName(2, "Red Porsche irl.jpg");
            this.imageListCars.Images.SetKeyName(3, "Yellow Lambo irl.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbCars
            // 
            this.pbCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCars.Image = ((System.Drawing.Image)(resources.GetObject("pbCars.Image")));
            this.pbCars.Location = new System.Drawing.Point(312, 215);
            this.pbCars.Name = "pbCars";
            this.pbCars.Size = new System.Drawing.Size(372, 293);
            this.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCars.TabIndex = 20;
            this.pbCars.TabStop = false;
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoLeft.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLeft.Location = new System.Drawing.Point(204, 313);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(50, 78);
            this.btnGoLeft.TabIndex = 21;
            this.btnGoLeft.Text = "<";
            this.btnGoLeft.UseVisualStyleBackColor = false;
            this.btnGoLeft.Click += new System.EventHandler(this.btnGoLeft_Click);
            // 
            // btnGoRight
            // 
            this.btnGoRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoRight.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoRight.Location = new System.Drawing.Point(754, 313);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(50, 78);
            this.btnGoRight.TabIndex = 22;
            this.btnGoRight.Text = ">";
            this.btnGoRight.UseVisualStyleBackColor = false;
            this.btnGoRight.Click += new System.EventHandler(this.btnGoRight_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.BackColor = System.Drawing.Color.White;
            this.txtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.HideSelection = false;
            this.txtBxName.Location = new System.Drawing.Point(364, 157);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.ReadOnly = true;
            this.txtBxName.Size = new System.Drawing.Size(271, 38);
            this.txtBxName.TabIndex = 23;
            this.txtBxName.TabStop = false;
            this.txtBxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxName.WordWrap = false;
            // 
            // txtBxCost
            // 
            this.txtBxCost.BackColor = System.Drawing.Color.White;
            this.txtBxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxCost.Location = new System.Drawing.Point(441, 527);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.ReadOnly = true;
            this.txtBxCost.Size = new System.Drawing.Size(121, 38);
            this.txtBxCost.TabIndex = 24;
            this.txtBxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxCost.WordWrap = false;
            // 
            // txtBxMyCoins
            // 
            this.txtBxMyCoins.BackColor = System.Drawing.Color.White;
            this.txtBxMyCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxMyCoins.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMyCoins.Location = new System.Drawing.Point(889, 22);
            this.txtBxMyCoins.Name = "txtBxMyCoins";
            this.txtBxMyCoins.ReadOnly = true;
            this.txtBxMyCoins.Size = new System.Drawing.Size(85, 32);
            this.txtBxMyCoins.TabIndex = 25;
            this.txtBxMyCoins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxMyCoins.WordWrap = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.txtBxMyCoins);
            this.Controls.Add(this.txtBxCost);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.pbCars);
            this.Controls.Add(this.labelYourCoins);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 726);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Store";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label labelYourCoins;
        private System.Windows.Forms.ImageList imageListCars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCars;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.TextBox txtBxMyCoins;
    }
}