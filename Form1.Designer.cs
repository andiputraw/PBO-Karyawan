namespace CrudKaryawan2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pilihFile = new System.Windows.Forms.Button();
            this.pictLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.comboAgama = new System.Windows.Forms.ComboBox();
            this.radioPerempuan = new System.Windows.Forms.RadioButton();
            this.radioLaki = new System.Windows.Forms.RadioButton();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.inputNIK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCari = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tampil_tabel = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tgl_lahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampil_tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tgl_lahir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pilihFile);
            this.groupBox1.Controls.Add(this.pictLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.picture);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonInput);
            this.groupBox1.Controls.Add(this.comboAgama);
            this.groupBox1.Controls.Add(this.radioPerempuan);
            this.groupBox1.Controls.Add(this.radioLaki);
            this.groupBox1.Controls.Add(this.inputNama);
            this.groupBox1.Controls.Add(this.inputNIK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pilihFile
            // 
            this.pilihFile.Location = new System.Drawing.Point(833, 82);
            this.pilihFile.Name = "pilihFile";
            this.pilihFile.Size = new System.Drawing.Size(89, 23);
            this.pilihFile.TabIndex = 16;
            this.pilihFile.Text = "Pilih File";
            this.pilihFile.UseVisualStyleBackColor = true;
            this.pilihFile.Click += new System.EventHandler(this.pilihFile_Click);
            // 
            // pictLabel
            // 
            this.pictLabel.Location = new System.Drawing.Point(659, 18);
            this.pictLabel.Name = "pictLabel";
            this.pictLabel.ReadOnly = true;
            this.pictLabel.Size = new System.Drawing.Size(277, 22);
            this.pictLabel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Foto :";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(659, 46);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(168, 175);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 13;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(546, 163);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(90, 25);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(431, 162);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 25);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(546, 122);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 24);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(431, 120);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(98, 24);
            this.buttonInput.TabIndex = 9;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // comboAgama
            // 
            this.comboAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgama.FormattingEnabled = true;
            this.comboAgama.Items.AddRange(new object[] {
            "Islam",
            "Katolik",
            "Protestan",
            "Hindu",
            "Buddha",
            "Konghuchu"});
            this.comboAgama.Location = new System.Drawing.Point(141, 197);
            this.comboAgama.Name = "comboAgama";
            this.comboAgama.Size = new System.Drawing.Size(200, 24);
            this.comboAgama.TabIndex = 8;
            // 
            // radioPerempuan
            // 
            this.radioPerempuan.AutoSize = true;
            this.radioPerempuan.Location = new System.Drawing.Point(243, 167);
            this.radioPerempuan.Name = "radioPerempuan";
            this.radioPerempuan.Size = new System.Drawing.Size(98, 20);
            this.radioPerempuan.TabIndex = 7;
            this.radioPerempuan.TabStop = true;
            this.radioPerempuan.Text = "Perempuan";
            this.radioPerempuan.UseVisualStyleBackColor = true;
            this.radioPerempuan.CheckedChanged += new System.EventHandler(this.radioPerempuan_CheckedChanged);
            // 
            // radioLaki
            // 
            this.radioLaki.AutoSize = true;
            this.radioLaki.Location = new System.Drawing.Point(141, 166);
            this.radioLaki.Name = "radioLaki";
            this.radioLaki.Size = new System.Drawing.Size(73, 20);
            this.radioLaki.TabIndex = 6;
            this.radioLaki.TabStop = true;
            this.radioLaki.Text = "laki laki";
            this.radioLaki.UseVisualStyleBackColor = true;
            this.radioLaki.CheckedChanged += new System.EventHandler(this.radioLaki_CheckedChanged);
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(141, 85);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(200, 22);
            this.inputNama.TabIndex = 5;
            // 
            // inputNIK
            // 
            this.inputNIK.Location = new System.Drawing.Point(141, 39);
            this.inputNIK.Name = "inputNIK";
            this.inputNIK.Size = new System.Drawing.Size(200, 22);
            this.inputNIK.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIK";
            // 
            // inputCari
            // 
            this.inputCari.Location = new System.Drawing.Point(664, 268);
            this.inputCari.Name = "inputCari";
            this.inputCari.Size = new System.Drawing.Size(233, 22);
            this.inputCari.TabIndex = 6;
            this.inputCari.TextChanged += new System.EventHandler(this.inputCari_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(903, 268);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // tampil_tabel
            // 
            this.tampil_tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampil_tabel.Location = new System.Drawing.Point(13, 297);
            this.tampil_tabel.Name = "tampil_tabel";
            this.tampil_tabel.RowHeadersWidth = 51;
            this.tampil_tabel.RowTemplate.Height = 24;
            this.tampil_tabel.Size = new System.Drawing.Size(1009, 257);
            this.tampil_tabel.TabIndex = 11;
            this.tampil_tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tampil_tabel_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tanggal Lahir";
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.Location = new System.Drawing.Point(141, 130);
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.Size = new System.Drawing.Size(200, 22);
            this.tgl_lahir.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 566);
            this.Controls.Add(this.tampil_tabel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.inputCari);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampil_tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ComboBox comboAgama;
        private System.Windows.Forms.RadioButton radioPerempuan;
        private System.Windows.Forms.RadioButton radioLaki;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.TextBox inputNIK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputCari;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView tampil_tabel;
        private System.Windows.Forms.Button pilihFile;
        private System.Windows.Forms.TextBox pictLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tgl_lahir;
    }
}

