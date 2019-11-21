namespace StringEqualityTaishaun
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
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(51, 93);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(141, 29);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "First String :";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(56, 199);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(177, 29);
            this.lblString2.TabIndex = 1;
            this.lblString2.Text = "Second String :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(171, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(406, 58);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Enter two strings to see if their equal.\r\n(Case doesn\'t matter)";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(317, 292);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(115, 42);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnCheck;
    }
}

