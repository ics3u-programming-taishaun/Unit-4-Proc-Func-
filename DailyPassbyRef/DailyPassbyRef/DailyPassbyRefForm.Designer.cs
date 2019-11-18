namespace DailyPassbyRef
{
    partial class frmDailyPassbyRef
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
            this.lblChangeImageR = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChangeImageR
            // 
            this.lblChangeImageR.AutoSize = true;
            this.lblChangeImageR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeImageR.Location = new System.Drawing.Point(155, 39);
            this.lblChangeImageR.Name = "lblChangeImageR";
            this.lblChangeImageR.Size = new System.Drawing.Size(451, 29);
            this.lblChangeImageR.TabIndex = 0;
            this.lblChangeImageR.Text = "Click on the image to change it randomly.";
            // 
            // picCard
            // 
            this.picCard.Location = new System.Drawing.Point(235, 81);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(308, 288);
            this.picCard.TabIndex = 1;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.PicCard_Click);
            // 
            // frmDailyPassbyRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lblChangeImageR);
            this.Name = "frmDailyPassbyRef";
            this.Text = "Pass By Ref by Taishaun.J";
            this.Load += new System.EventHandler(this.DailyPassbyRefForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeImageR;
        private System.Windows.Forms.PictureBox picCard;
    }
}

