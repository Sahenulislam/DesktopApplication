namespace Home2
{
    partial class Loding
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
            this.Loading = new System.Windows.Forms.Panel();
            this.panelLOAD = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.BackColor = System.Drawing.Color.White;
            this.Loading.Controls.Add(this.panelLOAD);
            this.Loading.Location = new System.Drawing.Point(195, 410);
            this.Loading.Margin = new System.Windows.Forms.Padding(0);
            this.Loading.Name = "Loading";
            this.Loading.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Loading.Size = new System.Drawing.Size(677, 30);
            this.Loading.TabIndex = 4;
            this.Loading.Paint += new System.Windows.Forms.PaintEventHandler(this.Loading_Paint);
            // 
            // panelLOAD
            // 
            this.panelLOAD.BackColor = System.Drawing.Color.Purple;
            this.panelLOAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLOAD.ForeColor = System.Drawing.Color.Thistle;
            this.panelLOAD.Location = new System.Drawing.Point(5, 5);
            this.panelLOAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLOAD.Name = "panelLOAD";
            this.panelLOAD.Size = new System.Drawing.Size(13, 20);
            this.panelLOAD.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(292, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome To ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(268, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 191);
            this.label1.TabIndex = 5;
            this.label1.Text = "#shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Loding";
            this.Text = "Loding";
            this.Loading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Loading;
        private System.Windows.Forms.Panel panelLOAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}