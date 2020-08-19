namespace height_meme
{
    partial class height_cal
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
            this.labelText1 = new System.Windows.Forms.Label();
            this.inputHeightBox = new System.Windows.Forms.TextBox();
            this.labelCM = new System.Windows.Forms.Label();
            this.okBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.BackColor = System.Drawing.Color.Transparent;
            this.labelText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText1.Location = new System.Drawing.Point(12, 38);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(128, 20);
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Input your height";
            // 
            // inputHeightBox
            // 
            this.inputHeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputHeightBox.Location = new System.Drawing.Point(146, 35);
            this.inputHeightBox.Name = "inputHeightBox";
            this.inputHeightBox.Size = new System.Drawing.Size(97, 26);
            this.inputHeightBox.TabIndex = 1;
            this.inputHeightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.BackColor = System.Drawing.Color.Transparent;
            this.labelCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM.Location = new System.Drawing.Point(249, 38);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(30, 20);
            this.labelCM.TabIndex = 2;
            this.labelCM.Text = "cm";
            // 
            // okBtn1
            // 
            this.okBtn1.Location = new System.Drawing.Point(192, 80);
            this.okBtn1.Name = "okBtn1";
            this.okBtn1.Size = new System.Drawing.Size(87, 27);
            this.okBtn1.TabIndex = 3;
            this.okBtn1.Text = "Xem";
            this.okBtn1.UseVisualStyleBackColor = true;
            this.okBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // height_cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 119);
            this.Controls.Add(this.okBtn1);
            this.Controls.Add(this.labelCM);
            this.Controls.Add(this.inputHeightBox);
            this.Controls.Add(this.labelText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "height_cal";
            this.Text = "Height calculator tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.TextBox inputHeightBox;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Button okBtn1;
    }
}

