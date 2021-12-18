
namespace ClientReservasi_20190140004
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
            this.components = new System.ComponentModel.Container();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNotlf = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbIDLokasi = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(175, 19);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(302, 20);
            this.tbID.TabIndex = 0;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(175, 58);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(302, 20);
            this.tbNama.TabIndex = 1;
            // 
            // tbNotlf
            // 
            this.tbNotlf.Location = new System.Drawing.Point(175, 102);
            this.tbNotlf.Name = "tbNotlf";
            this.tbNotlf.Size = new System.Drawing.Size(302, 20);
            this.tbNotlf.TabIndex = 2;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(175, 148);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(302, 20);
            this.tbJumlah.TabIndex = 3;
            // 
            // tbIDLokasi
            // 
            this.tbIDLokasi.Location = new System.Drawing.Point(175, 194);
            this.tbIDLokasi.Name = "tbIDLokasi";
            this.tbIDLokasi.Size = new System.Drawing.Size(302, 20);
            this.tbIDLokasi.TabIndex = 4;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(599, 19);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(599, 58);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 7;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(599, 102);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 8;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(599, 148);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID RESERVASI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "NAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "NO TELEPON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "JUMLAH PEMESANAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID LOKASI";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgPemesanan
            // 
            this.dgPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPemesanan.Location = new System.Drawing.Point(45, 238);
            this.dgPemesanan.Name = "dgPemesanan";
            this.dgPemesanan.Size = new System.Drawing.Size(699, 210);
            this.dgPemesanan.TabIndex = 16;
            this.dgPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPemesanan_CellClick);
            this.dgPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPemesanan_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPemesanan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbIDLokasi);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbNotlf);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNotlf;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbIDLokasi;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgPemesanan;
    }
}

