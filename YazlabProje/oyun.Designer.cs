
namespace YazlabProje
{
    partial class oyun
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
            this.yanitla = new System.Windows.Forms.Button();
            this.sıfır = new System.Windows.Forms.Label();
            this.verisoru = new System.Windows.Forms.TextBox();
            this.cubuk = new System.Windows.Forms.ProgressBar();
            this.hesappuan = new System.Windows.Forms.Label();
            this.puanınız = new System.Windows.Forms.Label();
            this.harfal = new System.Windows.Forms.Button();
            this.girilencevap = new System.Windows.Forms.TextBox();
            this.cevap = new System.Windows.Forms.Label();
            this.soru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttoplam = new System.Windows.Forms.Label();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // yanitla
            // 
            this.yanitla.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.yanitla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yanitla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yanitla.Location = new System.Drawing.Point(408, 28);
            this.yanitla.Name = "yanitla";
            this.yanitla.Size = new System.Drawing.Size(135, 27);
            this.yanitla.TabIndex = 36;
            this.yanitla.Text = "YANITLA";
            this.yanitla.UseVisualStyleBackColor = false;
            this.yanitla.Click += new System.EventHandler(this.yanitla_Click);
            // 
            // sıfır
            // 
            this.sıfır.AutoSize = true;
            this.sıfır.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sıfır.Location = new System.Drawing.Point(127, 105);
            this.sıfır.Name = "sıfır";
            this.sıfır.Size = new System.Drawing.Size(16, 17);
            this.sıfır.TabIndex = 35;
            this.sıfır.Text = "0";
            // 
            // verisoru
            // 
            this.verisoru.Enabled = false;
            this.verisoru.Location = new System.Drawing.Point(112, 14);
            this.verisoru.Multiline = true;
            this.verisoru.Name = "verisoru";
            this.verisoru.Size = new System.Drawing.Size(290, 53);
            this.verisoru.TabIndex = 34;
            // 
            // cubuk
            // 
            this.cubuk.Enabled = false;
            this.cubuk.Location = new System.Drawing.Point(19, 137);
            this.cubuk.Name = "cubuk";
            this.cubuk.Size = new System.Drawing.Size(775, 21);
            this.cubuk.TabIndex = 32;
            this.cubuk.Value = 100;
            this.cubuk.Click += new System.EventHandler(this.cubuk_Click);
            // 
            // hesappuan
            // 
            this.hesappuan.AutoSize = true;
            this.hesappuan.Location = new System.Drawing.Point(207, 292);
            this.hesappuan.Name = "hesappuan";
            this.hesappuan.Size = new System.Drawing.Size(0, 17);
            this.hesappuan.TabIndex = 31;
            // 
            // puanınız
            // 
            this.puanınız.AutoSize = true;
            this.puanınız.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.puanınız.Location = new System.Drawing.Point(16, 105);
            this.puanınız.Name = "puanınız";
            this.puanınız.Size = new System.Drawing.Size(70, 17);
            this.puanınız.TabIndex = 30;
            this.puanınız.Text = "Puanınız :";
            // 
            // harfal
            // 
            this.harfal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.harfal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.harfal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.harfal.Location = new System.Drawing.Point(549, 27);
            this.harfal.Name = "harfal";
            this.harfal.Size = new System.Drawing.Size(130, 28);
            this.harfal.TabIndex = 29;
            this.harfal.Text = "Harf Al";
            this.harfal.UseVisualStyleBackColor = false;
            this.harfal.Click += new System.EventHandler(this.harfal_Click);
            // 
            // girilencevap
            // 
            this.girilencevap.Location = new System.Drawing.Point(112, 73);
            this.girilencevap.Name = "girilencevap";
            this.girilencevap.Size = new System.Drawing.Size(100, 22);
            this.girilencevap.TabIndex = 28;
            this.girilencevap.TextChanged += new System.EventHandler(this.girilencevap_TextChanged);
            // 
            // cevap
            // 
            this.cevap.AutoSize = true;
            this.cevap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cevap.Location = new System.Drawing.Point(16, 78);
            this.cevap.Name = "cevap";
            this.cevap.Size = new System.Drawing.Size(77, 17);
            this.cevap.TabIndex = 27;
            this.cevap.Text = "Cevabınız :";
            this.cevap.Click += new System.EventHandler(this.cevap_Click);
            // 
            // soru
            // 
            this.soru.AutoSize = true;
            this.soru.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.soru.Location = new System.Drawing.Point(44, 17);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(42, 17);
            this.soru.TabIndex = 26;
            this.soru.Text = "Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txttoplam
            // 
            this.txttoplam.AutoSize = true;
            this.txttoplam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttoplam.Location = new System.Drawing.Point(532, 78);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(16, 17);
            this.txttoplam.TabIndex = 38;
            this.txttoplam.Text = "0";
            this.txttoplam.Click += new System.EventHandler(this.txttoplam_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltoplam.Location = new System.Drawing.Point(405, 78);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(121, 17);
            this.lbltoplam.TabIndex = 37;
            this.lbltoplam.Text = "Toplam Puanınız :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(806, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(408, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Tahmin Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(685, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 41;
            this.button2.Text = "Süreyi Duraklat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(651, 76);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 17);
            this.label.TabIndex = 42;
            this.label.Text = "0";
            this.label.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 4000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(827, 173);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.yanitla);
            this.Controls.Add(this.sıfır);
            this.Controls.Add(this.verisoru);
            this.Controls.Add(this.cubuk);
            this.Controls.Add(this.hesappuan);
            this.Controls.Add(this.puanınız);
            this.Controls.Add(this.harfal);
            this.Controls.Add(this.girilencevap);
            this.Controls.Add(this.cevap);
            this.Controls.Add(this.soru);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oyun";
            this.Text = "oyun";
            this.Load += new System.EventHandler(this.oyun_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oyun_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oyun_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.oyun_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yanitla;
        private System.Windows.Forms.Label sıfır;
        private System.Windows.Forms.TextBox verisoru;
        private System.Windows.Forms.ProgressBar cubuk;
        private System.Windows.Forms.Label hesappuan;
        private System.Windows.Forms.Label puanınız;
        private System.Windows.Forms.Button harfal;
        private System.Windows.Forms.TextBox girilencevap;
        private System.Windows.Forms.Label cevap;
        private System.Windows.Forms.Label soru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txttoplam;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer3;
    }
}