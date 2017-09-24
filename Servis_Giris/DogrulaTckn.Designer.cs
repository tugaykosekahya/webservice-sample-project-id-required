namespace Servis_Giris
{
    partial class DogrulaTckn
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskdTcknTxt = new System.Windows.Forms.MaskedTextBox();
            this.İsim = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.Soyisim = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdDgmYili = new System.Windows.Forms.MaskedTextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskdTcknTxt
            // 
            this.mskdTcknTxt.Location = new System.Drawing.Point(168, 49);
            this.mskdTcknTxt.Mask = "00000000000";
            this.mskdTcknTxt.Name = "mskdTcknTxt";
            this.mskdTcknTxt.Size = new System.Drawing.Size(100, 20);
            this.mskdTcknTxt.TabIndex = 1;
            // 
            // İsim
            // 
            this.İsim.AutoSize = true;
            this.İsim.Location = new System.Drawing.Point(62, 98);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(25, 13);
            this.İsim.TabIndex = 2;
            this.İsim.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(168, 98);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(100, 20);
            this.txtisim.TabIndex = 3;
            // 
            // Soyisim
            // 
            this.Soyisim.AutoSize = true;
            this.Soyisim.Location = new System.Drawing.Point(62, 145);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(42, 13);
            this.Soyisim.TabIndex = 4;
            this.Soyisim.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(168, 145);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyisim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dogum Yılı";
            // 
            // mskdDgmYili
            // 
            this.mskdDgmYili.Location = new System.Drawing.Point(168, 186);
            this.mskdDgmYili.Mask = "0000";
            this.mskdDgmYili.Name = "mskdDgmYili";
            this.mskdDgmYili.Size = new System.Drawing.Size(100, 20);
            this.mskdDgmYili.TabIndex = 7;
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(168, 258);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(100, 23);
            this.btnDogrula.TabIndex = 8;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // DogrulaTckn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 516);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.mskdDgmYili);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.İsim);
            this.Controls.Add(this.mskdTcknTxt);
            this.Controls.Add(this.label1);
            this.Name = "DogrulaTckn";
            this.Text = "DogrulaTckn";
            this.Load += new System.EventHandler(this.DogrulaTckn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdTcknTxt;
        private System.Windows.Forms.Label İsim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label Soyisim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdDgmYili;
        private System.Windows.Forms.Button btnDogrula;
    }
}