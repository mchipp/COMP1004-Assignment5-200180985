namespace COMP1004_Assignment5_200180985
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ReelTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelThreePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.JackpotLabel = new System.Windows.Forms.Label();
            this.WinningsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::COMP1004_Assignment5_200180985.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(336, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // ReelOnePictureBox
            // 
            this.ReelOnePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelOnePictureBox.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.blank;
            this.ReelOnePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReelOnePictureBox.Location = new System.Drawing.Point(81, 266);
            this.ReelOnePictureBox.Name = "ReelOnePictureBox";
            this.ReelOnePictureBox.Size = new System.Drawing.Size(72, 51);
            this.ReelOnePictureBox.TabIndex = 7;
            this.ReelOnePictureBox.TabStop = false;
            // 
            // ReelTwoPictureBox
            // 
            this.ReelTwoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelTwoPictureBox.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.blank;
            this.ReelTwoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReelTwoPictureBox.Location = new System.Drawing.Point(193, 266);
            this.ReelTwoPictureBox.Name = "ReelTwoPictureBox";
            this.ReelTwoPictureBox.Size = new System.Drawing.Size(72, 51);
            this.ReelTwoPictureBox.TabIndex = 8;
            this.ReelTwoPictureBox.TabStop = false;
            // 
            // ReelThreePictureBox
            // 
            this.ReelThreePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ReelThreePictureBox.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.blank;
            this.ReelThreePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReelThreePictureBox.Location = new System.Drawing.Point(305, 266);
            this.ReelThreePictureBox.Name = "ReelThreePictureBox";
            this.ReelThreePictureBox.Size = new System.Drawing.Size(76, 51);
            this.ReelThreePictureBox.TabIndex = 9;
            this.ReelThreePictureBox.TabStop = false;
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.powerbutton;
            this.ExitPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPictureBox.Location = new System.Drawing.Point(375, 99);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(36, 36);
            this.ExitPictureBox.TabIndex = 10;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.reset;
            this.ResetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetPictureBox.Location = new System.Drawing.Point(46, 99);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(36, 36);
            this.ResetPictureBox.TabIndex = 11;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyLabel.ForeColor = System.Drawing.Color.Gold;
            this.MoneyLabel.Location = new System.Drawing.Point(77, 379);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(0, 16);
            this.MoneyLabel.TabIndex = 12;
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.BackColor = System.Drawing.Color.Transparent;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.Color.Gold;
            this.BetLabel.Location = new System.Drawing.Point(201, 379);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(0, 16);
            this.BetLabel.TabIndex = 13;
            // 
            // JackpotLabel
            // 
            this.JackpotLabel.AutoSize = true;
            this.JackpotLabel.BackColor = System.Drawing.Color.Transparent;
            this.JackpotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackpotLabel.ForeColor = System.Drawing.Color.Gold;
            this.JackpotLabel.Location = new System.Drawing.Point(187, 166);
            this.JackpotLabel.Name = "JackpotLabel";
            this.JackpotLabel.Size = new System.Drawing.Size(0, 16);
            this.JackpotLabel.TabIndex = 14;
            // 
            // WinningsLabel
            // 
            this.WinningsLabel.AutoSize = true;
            this.WinningsLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinningsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningsLabel.ForeColor = System.Drawing.Color.Gold;
            this.WinningsLabel.Location = new System.Drawing.Point(289, 379);
            this.WinningsLabel.Name = "WinningsLabel";
            this.WinningsLabel.Size = new System.Drawing.Size(0, 16);
            this.WinningsLabel.TabIndex = 15;
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::COMP1004_Assignment5_200180985.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.WinningsLabel);
            this.Controls.Add(this.JackpotLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.ReelThreePictureBox);
            this.Controls.Add(this.ReelTwoPictureBox);
            this.Controls.Add(this.ReelOnePictureBox);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox ReelOnePictureBox;
        private System.Windows.Forms.PictureBox ReelTwoPictureBox;
        private System.Windows.Forms.PictureBox ReelThreePictureBox;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label JackpotLabel;
        private System.Windows.Forms.Label WinningsLabel;
    }
}