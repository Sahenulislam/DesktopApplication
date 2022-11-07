namespace Home2
{
    partial class user_msgform
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Panel();
            this.User_msg = new System.Windows.Forms.Panel();
            this.User_name.SuspendLayout();
            this.User_msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(44, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message";
            // 
            // User_name
            // 
            this.User_name.BackColor = System.Drawing.Color.White;
            this.User_name.Controls.Add(this.label2);
            this.User_name.Location = new System.Drawing.Point(48, 2);
            this.User_name.Margin = new System.Windows.Forms.Padding(2);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(161, 42);
            this.User_name.TabIndex = 4;
            // 
            // User_msg
            // 
            this.User_msg.BackColor = System.Drawing.Color.White;
            this.User_msg.Controls.Add(this.label3);
            this.User_msg.Location = new System.Drawing.Point(303, 2);
            this.User_msg.Margin = new System.Windows.Forms.Padding(2);
            this.User_msg.Name = "User_msg";
            this.User_msg.Size = new System.Drawing.Size(273, 42);
            this.User_msg.TabIndex = 5;
            // 
            // user_msgform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.User_msg);
            this.Controls.Add(this.User_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "user_msgform";
            this.Size = new System.Drawing.Size(579, 48);
            this.User_name.ResumeLayout(false);
            this.User_name.PerformLayout();
            this.User_msg.ResumeLayout(false);
            this.User_msg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel User_name;
        private System.Windows.Forms.Panel User_msg;
    }
}
