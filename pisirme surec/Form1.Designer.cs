namespace pisirme_surec
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.GrayText;
            progressBar1.Location = new Point(-6, 39);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(635, 43);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(45, -2);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
            label1.TabIndex = 1;
            label1.Text = "Un ve Yumurta Karistirma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(45, 102);
            label2.Name = "label2";
            label2.Size = new Size(194, 38);
            label2.TabIndex = 3;
            label2.Text = "Cırpma Islemi";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(4, 143);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(625, 43);
            progressBar2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(45, 203);
            label3.Name = "label3";
            label3.Size = new Size(406, 38);
            label3.TabIndex = 5;
            label3.Text = "Malzemeler Eklenip Karistirma";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(4, 244);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(625, 43);
            progressBar3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(48, 309);
            label4.Name = "label4";
            label4.Size = new Size(191, 38);
            label4.TabIndex = 7;
            label4.Text = "Pasta Pisirme";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(-6, 350);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(635, 43);
            progressBar4.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(876, 435);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
    }
}
