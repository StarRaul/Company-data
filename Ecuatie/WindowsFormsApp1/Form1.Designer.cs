namespace WindowsFormsApp1
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
            this.apasa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.camp_a = new System.Windows.Forms.TextBox();
            this.camp_b = new System.Windows.Forms.TextBox();
            this.camp_c = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apasa
            // 
            this.apasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.apasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.apasa.Location = new System.Drawing.Point(121, 208);
            this.apasa.Name = "apasa";
            this.apasa.Size = new System.Drawing.Size(85, 31);
            this.apasa.TabIndex = 0;
            this.apasa.Text = "Rezolva";
            this.apasa.UseVisualStyleBackColor = false;
            this.apasa.Click += new System.EventHandler(this.apasa_Click);
            // 
            // camp_a
            // 
            this.camp_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.camp_a.ForeColor = System.Drawing.SystemColors.Info;
            this.camp_a.Location = new System.Drawing.Point(37, 77);
            this.camp_a.Name = "camp_a";
            this.camp_a.Size = new System.Drawing.Size(100, 20);
            this.camp_a.TabIndex = 1;
            this.camp_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // camp_b
            // 
            this.camp_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.camp_b.ForeColor = System.Drawing.SystemColors.Info;
            this.camp_b.Location = new System.Drawing.Point(37, 129);
            this.camp_b.Name = "camp_b";
            this.camp_b.Size = new System.Drawing.Size(100, 20);
            this.camp_b.TabIndex = 2;
            this.camp_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // camp_c
            // 
            this.camp_c.BackColor = System.Drawing.Color.Red;
            this.camp_c.ForeColor = System.Drawing.SystemColors.Info;
            this.camp_c.Location = new System.Drawing.Point(37, 182);
            this.camp_c.Name = "camp_c";
            this.camp_c.Size = new System.Drawing.Size(100, 20);
            this.camp_c.TabIndex = 3;
            // 
            // rez
            // 
            this.rez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rez.Location = new System.Drawing.Point(155, 77);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(181, 125);
            this.rez.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "a=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "c=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rezolvare ecuatie:\r\nax^2+bx+c=0\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(348, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.camp_c);
            this.Controls.Add(this.camp_b);
            this.Controls.Add(this.camp_a);
            this.Controls.Add(this.apasa);
            this.Name = "Form1";
            this.Text = "ec_gr_2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apasa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox camp_a;
        private System.Windows.Forms.TextBox camp_b;
        private System.Windows.Forms.TextBox camp_c;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

