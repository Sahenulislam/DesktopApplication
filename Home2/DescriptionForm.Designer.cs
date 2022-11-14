namespace Home2
{
    partial class DescriptionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Warranty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.waranty = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "a";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(11, 41);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(246, 361);
            this.PictureBox.TabIndex = 9;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Warranty
            // 
            this.Warranty.AutoSize = true;
            this.Warranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warranty.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warranty.ForeColor = System.Drawing.Color.Purple;
            this.Warranty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Warranty.Location = new System.Drawing.Point(277, 188);
            this.Warranty.Name = "Warranty";
            this.Warranty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Warranty.Size = new System.Drawing.Size(145, 27);
            this.Warranty.TabIndex = 12;
            this.Warranty.Text = "Product Price";
            this.Warranty.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(277, 41);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(211, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product Description";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(277, 70);
            this.Description.Margin = new System.Windows.Forms.Padding(2);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(421, 103);
            this.Description.TabIndex = 39;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // waranty
            // 
            this.waranty.Location = new System.Drawing.Point(277, 217);
            this.waranty.Margin = new System.Windows.Forms.Padding(2);
            this.waranty.Name = "waranty";
            this.waranty.Size = new System.Drawing.Size(421, 43);
            this.waranty.TabIndex = 40;
            this.waranty.Text = "";
            // 
            // DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.waranty);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Warranty);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.button1);
            this.Name = "DescriptionForm";
            this.Text = "DescriptionForm";
            this.Load += new System.EventHandler(this.DescriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label Warranty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.RichTextBox waranty;
    }
}