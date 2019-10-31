namespace ConvertToFarenTaishaunJohnson
{
    partial class ConvertToFarenForm
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
            this.lblEnterTemperature = new System.Windows.Forms.Label();
            this.txtDegreesC = new System.Windows.Forms.TextBox();
            this.btnConvertToFar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterTemperature
            // 
            this.lblEnterTemperature.AutoSize = true;
            this.lblEnterTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTemperature.Location = new System.Drawing.Point(28, 121);
            this.lblEnterTemperature.Name = "lblEnterTemperature";
            this.lblEnterTemperature.Size = new System.Drawing.Size(464, 29);
            this.lblEnterTemperature.TabIndex = 0;
            this.lblEnterTemperature.Text = "Enter the temperature in degrees Celsius :";
            // 
            // txtDegreesC
            // 
            this.txtDegreesC.Location = new System.Drawing.Point(571, 130);
            this.txtDegreesC.Name = "txtDegreesC";
            this.txtDegreesC.Size = new System.Drawing.Size(100, 20);
            this.txtDegreesC.TabIndex = 1;
            // 
            // btnConvertToFar
            // 
            this.btnConvertToFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToFar.Location = new System.Drawing.Point(326, 187);
            this.btnConvertToFar.Name = "btnConvertToFar";
            this.btnConvertToFar.Size = new System.Drawing.Size(182, 95);
            this.btnConvertToFar.TabIndex = 2;
            this.btnConvertToFar.Text = "Convert to Farenheit";
            this.btnConvertToFar.UseVisualStyleBackColor = true;
            this.btnConvertToFar.Click += new System.EventHandler(this.BtnConvertToFar_Click);
            // 
            // ConvertToFarenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertToFar);
            this.Controls.Add(this.txtDegreesC);
            this.Controls.Add(this.lblEnterTemperature);
            this.Name = "ConvertToFarenForm";
            this.Text = "Convert To Farenheit by Taishaun Johnson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTemperature;
        private System.Windows.Forms.TextBox txtDegreesC;
        private System.Windows.Forms.Button btnConvertToFar;
    }
}

