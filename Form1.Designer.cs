namespace klientTCP
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
            this.przycisk = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.polaczenie = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(239, 319);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(211, 45);
            this.przycisk.TabIndex = 0;
            this.przycisk.Text = "zamknij";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 12);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(236, 20);
            this.adres.TabIndex = 1;
            this.adres.Text = "adres";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(262, 13);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(188, 20);
            this.port.TabIndex = 2;
            // 
            // polaczenie
            // 
            this.polaczenie.Location = new System.Drawing.Point(12, 319);
            this.polaczenie.Name = "polaczenie";
            this.polaczenie.Size = new System.Drawing.Size(211, 45);
            this.polaczenie.TabIndex = 3;
            this.polaczenie.Text = "połącz";
            this.polaczenie.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 277);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 376);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.polaczenie);
            this.Controls.Add(this.port);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Button polaczenie;
        private System.Windows.Forms.ListBox listBox1;
    }
}

