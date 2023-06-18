namespace Book_ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            harga = new Label();
            label7 = new Label();
            pesan = new Button();
            tgl_kunjungan = new DateTimePicker();
            pengunjung_ank = new TextBox();
            jml_pengunjung = new TextBox();
            nama = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 115);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(917, 69);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 4;
            label4.Text = "Lainnya";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(465, 69);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 3;
            label3.Text = "Penginapan";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(641, 69);
            label2.Name = "label2";
            label2.Size = new Size(235, 30);
            label2.TabIndex = 2;
            label2.Text = "Aktivitas dan hiburan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 69);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(82, 42);
            button1.Name = "button1";
            button1.Size = new Size(158, 70);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(8, 102, 255);
            panel2.Controls.Add(harga);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pesan);
            panel2.Controls.Add(tgl_kunjungan);
            panel2.Controls.Add(pengunjung_ank);
            panel2.Controls.Add(jml_pengunjung);
            panel2.Controls.Add(nama);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(156, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(1582, 652);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // harga
            // 
            harga.AutoSize = true;
            harga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            harga.ForeColor = Color.White;
            harga.Location = new Point(558, 421);
            harga.Name = "harga";
            harga.Size = new Size(149, 32);
            harga.TabIndex = 18;
            harga.Text = "Total harga:";
            harga.Click += harga_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(82, 357);
            label7.Name = "label7";
            label7.Size = new Size(312, 75);
            label7.TabIndex = 17;
            label7.Text = "*Pengunjung dikategorikan sebagai\r\npengunjung anak apabila berumur \r\nkurang dari 7 tahun";
            // 
            // pesan
            // 
            pesan.Cursor = Cursors.Hand;
            pesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pesan.Location = new Point(86, 515);
            pesan.Name = "pesan";
            pesan.Size = new Size(221, 61);
            pesan.TabIndex = 16;
            pesan.Text = "Pesan";
            pesan.UseVisualStyleBackColor = true;
            pesan.Click += pesan_Click;
            // 
            // tgl_kunjungan
            // 
            tgl_kunjungan.Cursor = Cursors.Hand;
            tgl_kunjungan.CustomFormat = "yyyy-MM-dd";
            tgl_kunjungan.Format = DateTimePickerFormat.Custom;
            tgl_kunjungan.Location = new Point(558, 311);
            tgl_kunjungan.Name = "tgl_kunjungan";
            tgl_kunjungan.Size = new Size(337, 39);
            tgl_kunjungan.TabIndex = 15;
            // 
            // pengunjung_ank
            // 
            pengunjung_ank.Cursor = Cursors.IBeam;
            pengunjung_ank.Location = new Point(86, 315);
            pengunjung_ank.Name = "pengunjung_ank";
            pengunjung_ank.Size = new Size(337, 39);
            pengunjung_ank.TabIndex = 13;
            // 
            // jml_pengunjung
            // 
            jml_pengunjung.Cursor = Cursors.IBeam;
            jml_pengunjung.Location = new Point(558, 193);
            jml_pengunjung.Name = "jml_pengunjung";
            jml_pengunjung.Size = new Size(337, 39);
            jml_pengunjung.TabIndex = 12;
            jml_pengunjung.TextChanged += jml_pengunjung_TextChanged;
            // 
            // nama
            // 
            nama.Cursor = Cursors.IBeam;
            nama.Location = new Point(86, 193);
            nama.Name = "nama";
            nama.Size = new Size(337, 39);
            nama.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(556, 271);
            label8.Name = "label8";
            label8.Size = new Size(95, 30);
            label8.TabIndex = 10;
            label8.Text = "Tanggal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(82, 276);
            label9.Name = "label9";
            label9.Size = new Size(273, 30);
            label9.TabIndex = 9;
            label9.Text = "Jumlah pengunjung anak";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(553, 151);
            label6.Name = "label6";
            label6.Size = new Size(217, 30);
            label6.TabIndex = 6;
            label6.Text = "Jumlah Pengunjung";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 151);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 5;
            label5.Text = "Nama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Jecation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private TextBox pengunjung_ank;
        private TextBox jml_pengunjung;
        private TextBox nama;
        private Label label8;
        private Label label9;
        private Label label6;
        private Button pesan;
        private DateTimePicker tgl_kunjungan;
        private Label label7;
        private Label harga;
    }
}