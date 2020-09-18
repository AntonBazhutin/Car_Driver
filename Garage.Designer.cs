namespace CarDriver2
{
    partial class Garage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garage));
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.pbCars = new System.Windows.Forms.PictureBox();
            this.btnEquip = new System.Windows.Forms.Button();
            this.imageListCars = new System.Windows.Forms.ImageList(this.components);
            this.imageListNonBought = new System.Windows.Forms.ImageList(this.components);
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
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseMove);
            // 
            // txtBxName
            // 
            this.txtBxName.BackColor = System.Drawing.Color.White;
            this.txtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.HideSelection = false;
            this.txtBxName.Location = new System.Drawing.Point(363, 147);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.ReadOnly = true;
            this.txtBxName.Size = new System.Drawing.Size(271, 38);
            this.txtBxName.TabIndex = 29;
            this.txtBxName.TabStop = false;
            this.txtBxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxName.WordWrap = false;
            // 
            // btnGoRight
            // 
            this.btnGoRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoRight.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoRight.Location = new System.Drawing.Point(746, 303);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(50, 78);
            this.btnGoRight.TabIndex = 28;
            this.btnGoRight.Text = ">";
            this.btnGoRight.UseVisualStyleBackColor = false;
            this.btnGoRight.Click += new System.EventHandler(this.btnGoRight_Click);
            this.btnGoRight.MouseLeave += new System.EventHandler(this.btnGoRight_MouseLeave);
            this.btnGoRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGoRight_MouseMove);
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoLeft.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLeft.Location = new System.Drawing.Point(203, 303);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(50, 78);
            this.btnGoLeft.TabIndex = 27;
            this.btnGoLeft.Text = "<";
            this.btnGoLeft.UseVisualStyleBackColor = false;
            this.btnGoLeft.Click += new System.EventHandler(this.btnGoLeft_Click);
            this.btnGoLeft.MouseLeave += new System.EventHandler(this.btnGoLeft_MouseLeave);
            this.btnGoLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGoLeft_MouseMove);
            // 
            // pbCars
            // 
            this.pbCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCars.Image = ((System.Drawing.Image)(resources.GetObject("pbCars.Image")));
            this.pbCars.Location = new System.Drawing.Point(311, 205);
            this.pbCars.Name = "pbCars";
            this.pbCars.Size = new System.Drawing.Size(372, 293);
            this.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCars.TabIndex = 26;
            this.pbCars.TabStop = false;
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquip.Location = new System.Drawing.Point(447, 515);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(95, 46);
            this.btnEquip.TabIndex = 25;
            this.btnEquip.Text = "Equip";
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            this.btnEquip.MouseLeave += new System.EventHandler(this.btnEquip_MouseLeave);
            this.btnEquip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEquip_MouseMove);
            // 
            // imageListCars
            // 
            this.imageListCars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCars.ImageStream")));
            this.imageListCars.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCars.Images.SetKeyName(0, "Blue Mustang irl.jpg");
            this.imageListCars.Images.SetKeyName(1, "Green Cabrio irl.jpg");
            this.imageListCars.Images.SetKeyName(2, "Yellow Lambo irl.jpg");
            this.imageListCars.Images.SetKeyName(3, "Red Porsche irl.jpg");
            // 
            // imageListNonBought
            // 
            this.imageListNonBought.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNonBought.ImageStream")));
            this.imageListNonBought.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNonBought.Images.SetKeyName(0, "Blue Mustang irl.jpg");
            this.imageListNonBought.Images.SetKeyName(1, "XRa38Mowv48.jpg");
            this.imageListNonBought.Images.SetKeyName(2, "lpOgS6b9P88.jpg");
            this.imageListNonBought.Images.SetKeyName(3, "dnVVLbR_0Mw.jpg");
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.pbCars);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 726);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Garage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Garage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.PictureBox pbCars;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.ImageList imageListCars;
        private System.Windows.Forms.ImageList imageListNonBought;
    }
}