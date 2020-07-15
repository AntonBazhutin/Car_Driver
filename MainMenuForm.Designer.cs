namespace CarDriver2
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnGarage = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVolumeOnOff = new System.Windows.Forms.Button();
            this.pictureBxMainScreen = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(452, 273);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(128, 46);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseMove);
            // 
            // btnGarage
            // 
            this.btnGarage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarage.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarage.Location = new System.Drawing.Point(452, 426);
            this.btnGarage.Name = "btnGarage";
            this.btnGarage.Size = new System.Drawing.Size(128, 46);
            this.btnGarage.TabIndex = 2;
            this.btnGarage.Text = "Garage";
            this.btnGarage.UseVisualStyleBackColor = false;
            this.btnGarage.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnGarage.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnGarage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseMove);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(452, 501);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(128, 46);
            this.btnScore.TabIndex = 3;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            this.btnScore.MouseLeave += new System.EventHandler(this.btnScore_MouseLeave);
            this.btnScore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnScore_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(897, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnVolumeOnOff
            // 
            this.btnVolumeOnOff.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVolumeOnOff.BackgroundImage = global::CarDriver2.Properties.Resources.volumeOn;
            this.btnVolumeOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolumeOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeOnOff.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeOnOff.Location = new System.Drawing.Point(12, 629);
            this.btnVolumeOnOff.Name = "btnVolumeOnOff";
            this.btnVolumeOnOff.Size = new System.Drawing.Size(46, 46);
            this.btnVolumeOnOff.TabIndex = 6;
            this.btnVolumeOnOff.UseVisualStyleBackColor = false;
            this.btnVolumeOnOff.Click += new System.EventHandler(this.btnVolumeOnOff_Click);
            this.btnVolumeOnOff.MouseLeave += new System.EventHandler(this.btnVolumeOnOff_MouseLeave);
            this.btnVolumeOnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVolumeOnOff_MouseMove);
            // 
            // pictureBxMainScreen
            // 
            this.pictureBxMainScreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBxMainScreen.Image")));
            this.pictureBxMainScreen.Location = new System.Drawing.Point(0, 1);
            this.pictureBxMainScreen.Name = "pictureBxMainScreen";
            this.pictureBxMainScreen.Size = new System.Drawing.Size(1008, 687);
            this.pictureBxMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBxMainScreen.TabIndex = 0;
            this.pictureBxMainScreen.TabStop = false;
            this.pictureBxMainScreen.Click += new System.EventHandler(this.pictureBxMainScreen_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Location = new System.Drawing.Point(452, 352);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(128, 46);
            this.btnStore.TabIndex = 7;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            this.btnStore.MouseLeave += new System.EventHandler(this.btnStore_MouseLeave);
            this.btnStore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnStore_MouseMove);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnVolumeOnOff);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnGarage);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBxMainScreen);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 726);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxMainScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBxMainScreen;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnGarage;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVolumeOnOff;
        private System.Windows.Forms.Button btnStore;
    }
}

