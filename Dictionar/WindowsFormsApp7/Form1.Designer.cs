namespace WindowsFormsApp7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ROtoEN = new System.Windows.Forms.ToolStripButton();
            this.ENtoRO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cuvant = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.ListBox();
            this.l2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.ROtoEN,
            this.toolStripSeparator2,
            this.ENtoRO,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Închide";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ROtoEN
            // 
            this.ROtoEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ROtoEN.Image = ((System.Drawing.Image)(resources.GetObject("ROtoEN.Image")));
            this.ROtoEN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ROtoEN.Name = "ROtoEN";
            this.ROtoEN.Size = new System.Drawing.Size(44, 44);
            this.ROtoEN.Text = "toolStripButton2";
            this.ROtoEN.ToolTipText = "RO->EN";
            this.ROtoEN.Click += new System.EventHandler(this.ROtoEN_Click);
            // 
            // ENtoRO
            // 
            this.ENtoRO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ENtoRO.Image = ((System.Drawing.Image)(resources.GetObject("ENtoRO.Image")));
            this.ENtoRO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ENtoRO.Name = "ENtoRO";
            this.ENtoRO.Size = new System.Drawing.Size(44, 44);
            this.ENtoRO.Text = "toolStripButton3";
            this.ENtoRO.ToolTipText = "EN->RO";
            this.ENtoRO.Click += new System.EventHandler(this.ENtoRO_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Despre";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // cuvant
            // 
            this.cuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuvant.Location = new System.Drawing.Point(12, 50);
            this.cuvant.Multiline = true;
            this.cuvant.Name = "cuvant";
            this.cuvant.Size = new System.Drawing.Size(154, 26);
            this.cuvant.TabIndex = 1;
            this.cuvant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cuvant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cuvant_KeyDown);
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.Location = new System.Drawing.Point(12, 82);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(120, 225);
            this.l1.TabIndex = 2;
            this.l1.SelectedIndexChanged += new System.EventHandler(this.l1_SelectedIndexChanged);
            // 
            // l2
            // 
            this.l2.FormattingEnabled = true;
            this.l2.Location = new System.Drawing.Point(139, 82);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(120, 225);
            this.l2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp7.Properties.Resources.cauta;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(173, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cauta\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.cuvant);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dictionar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ROtoEN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ENtoRO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox cuvant;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.ListBox l2;
        private System.Windows.Forms.Button button1;
    }
}

