using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Globalization;

namespace CrudKaryawan2
{
    public partial class Form1 : Form
    {
        OdbcConnection conn;
        OdbcCommand cmd;
        OdbcDataAdapter dataadapter;
        DataSet dataset;
        string sql, gender, pictName;
        string location = "C:\\Users\\LENOVO\\OneDrive\\Gambar";

        public Form1()
        {

            InitializeComponent();
        }

        void koneksi()
        {
            sql = "DRIVER={MySQL ODBC 8.0 Unicode Driver};Database=db_karyawan;uid=root";
            conn = new OdbcConnection(sql);
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void radioLaki_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki Laki";
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            koneksi();

            if (inputValidation())
            {
                return;
            }
            
            sql = $"INSERT INTO karyawan VALUES('{inputNIK.Text}','{inputNama.Text}','{tgl_lahir.Value.ToString("yyyy-MM-dd")}','{gender}','{comboAgama.Text}','{pictLabel.Text}')";
            cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diinput");
            tampil();
            bersih();
        }

        void tampil()
        {
            koneksi();
            dataadapter = new OdbcDataAdapter("SELECT * FROM karyawan ", conn);
            dataset = new DataSet();
            dataadapter.Fill(dataset, "karyawan");
            tampil_tabel.DataSource = dataset.Tables[0];
        }
        void tampilSearch(string nama)
        {
            koneksi()
;           dataadapter = new OdbcDataAdapter($"SELECT * FROM karyawan WHERE nama = '{nama}'",conn);
            dataset = new DataSet();
            dataadapter.Fill(dataset, "karyawan");
            tampil_tabel.DataSource= dataset.Tables[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            koneksi();
            if (inputValidation()) return;
            sql = $"UPDATE karyawan SET nama='{inputNama.Text}', jenis_kelamin = '{gender}', agama = '{comboAgama.Text}', foto = '{pictName}', tgl_lahir = {tgl_lahir.Value.ToString("yyyy-MM-dd")} WHERE nik = {inputNIK.Text}";
            cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Berhasil di edit");
            tampil();
            bersih();
        }

        void bersih()
        {
            inputNIK.Text = "";
            inputNama.Text = "";
            radioLaki.Checked = false;
            radioPerempuan.Checked = false;
            gender = null;
            pictName = null;
            comboAgama.SelectedIndex = -1;
            picture.ImageLocation = "";
            pictLabel.Text = "";
            
        }


        private void tampil_tabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow baris = tampil_tabel.Rows[e.RowIndex];
                inputNIK.Text = baris.Cells[0].Value.ToString();
                inputNama.Text = baris.Cells[1].Value.ToString();


                DateTime date = getDataFromString(baris.Cells[2].Value.ToString());

                tgl_lahir.Value = date;


                if (baris.Cells[3].Value.ToString() == "Laki Laki")
                {
                    radioLaki.Checked = true;
                }
                else
                {
                    radioPerempuan.Checked = true;
                }
                comboAgama.Text = baris.Cells[4].Value.ToString();

                pictName = filterFileLocation(baris.Cells[5].Value.ToString());
                pictLabel.Text = pictName;
                getPhotoFromFile(pictName);

                inputNIK.ReadOnly = true;

            }
            catch (Exception err)
            {

            }
                
        
           
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            koneksi();
            sql = $"DELETE FROM KARYAWAN where NIK='{inputNIK.Text}'";
            cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil dihapus");
            tampil();
            bersih();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = inputCari.Text;
            tampilSearch(inputCari.Text);


            //DataTable table = new DataTable();
            //DataView dv = new DataView(table);
            //dv.RowFilter = $"nama like '%{search}%'";
            //tampil_tabel.DataSource = dv;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bersih();
            inputNIK.ReadOnly = false;
        }

        private void inputCari_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void pilihFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();

            photo.Filter = "Image FIles (*.jpg;*.jpeg;*.gif;)|*.jpg;*.jpeg;*.gif";
            
            photo.InitialDirectory = "C:\\Users\\LENOVO\\OneDrive\\Gambar\\";
            if (photo.ShowDialog() == DialogResult.OK)
            {
                 string[] pictArr = photo.FileName.Split('\\');

                 pictName = pictArr[pictArr.Length - 1];
                pictLabel.Text = pictName;
                getPhotoFromFile(pictName);
            }

        }

        void getPhotoFromFile(string pictName)
        {
            picture.ImageLocation = $"{location}\\{pictName}";
        }

        string filterFileLocation(string fileLocation)
        {
            string[] arr = fileLocation.Split('\\');
            return arr[arr.Length - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private DateTime getDataFromString(string DateInString)
        {
            //21/11/1995

            Console.WriteLine(DateInString);

            string[] arr = DateInString.Split('/');

            foreach (string str in arr)
            {
                Console.WriteLine(str);

            }
            
            DateTime date = new DateTime(int.Parse(arr[2].Substring(0, 4)),int.Parse(arr[1]),int.Parse(arr[0]));

            return date;

        }

        bool inputValidation()
        {
            if(inputNIK.Text == "")
            {
                MessageBox.Show("Nik belum diisi");
                return true;
            }else if(inputNama.Text == "")
            {
                MessageBox.Show("Nama Belum diisi");
                return true;
            }else if(gender == null)
            {
                MessageBox.Show("Gender belum di checklist");
                return true;
            }else if(comboAgama.Text == "")
            {
                MessageBox.Show("Agama belum di pilih");
                return true; 
            }else if(pictName == null)
            {
                MessageBox.Show("Foto belum di pilih");
                return true;
            }
            return false;
        }
    }
}
