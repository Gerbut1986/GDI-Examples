namespace Fifty_Squares
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
            this.colorBtn = new System.Windows.Forms.Button();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colorBtn
            // 
            this.colorBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBtn.Location = new System.Drawing.Point(230, 9);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(60, 23);
            this.colorBtn.TabIndex = 7;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // reverseBtn
            // 
            this.reverseBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverseBtn.Location = new System.Drawing.Point(295, 9);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(64, 23);
            this.reverseBtn.TabIndex = 6;
            this.reverseBtn.Text = "Reverse";
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawBtn.Location = new System.Drawing.Point(161, 9);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(64, 23);
            this.drawBtn.TabIndex = 5;
            this.drawBtn.Text = "Drawing";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(8, 2);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(503, 492);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 497);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

