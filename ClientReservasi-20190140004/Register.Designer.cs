
namespace ClientReservasi_20190140004
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.dtRegister = new System.Windows.Forms.DataGridView();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(454, 55);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 3;
            this.btSimpan.Text = "SIMPAN";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(454, 109);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(454, 169);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 5;
            this.btHapus.Text = "HAPUS";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(454, 229);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(337, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(271, 20);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.Text = "TB Ini Hanya Sebagai Penyimpanan ID Sementara";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(176, 58);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(229, 20);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(176, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(229, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // dtRegister
            // 
            this.dtRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegister.Location = new System.Drawing.Point(12, 288);
            this.dtRegister.Name = "dtRegister";
            this.dtRegister.Size = new System.Drawing.Size(596, 150);
            this.dtRegister.TabIndex = 10;
            this.dtRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegister_CellClick);
            this.dtRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegister_CellContentClick);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Items.AddRange(new object[] {
            "Admin",
            "Resepsionis"});
            this.comboBoxKategori.Location = new System.Drawing.Point(176, 209);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(229, 21);
            this.comboBoxKategori.TabIndex = 11;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.dtRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.dtRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DataGridView dtRegister;
        private System.Windows.Forms.ComboBox comboBoxKategori;
    }
}