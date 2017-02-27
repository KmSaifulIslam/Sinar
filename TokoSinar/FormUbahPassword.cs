using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSinar
{
    public partial class FormUbahPassword : Form
    {
        //string passLama;
        //string passBaru;
        //string konfPassBaru;
        string Username;
        TokoSinarDB db = new TokoSinarDB();

        public FormUbahPassword()
        {
            InitializeComponent();
        }

        public FormUbahPassword(string username)
        {
            InitializeComponent();
            Username = username;

        }

        private void cbRevealPassChar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRevealPassChar.Checked)
            {
                this.tbPasswordBaru.PasswordChar = (char)0;
                this.tbKonfPasswordBaru.PasswordChar = (char)0;
            }
            else
            {
                this.tbPasswordBaru.PasswordChar = '☺';
                this.tbKonfPasswordBaru.PasswordChar = '☺';
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var KaryawanMasuk = db.tbKaryawans.Where(x => x.Username == Username).FirstOrDefault();

                if (tbPasswordLama.Text != string.Empty && tbPasswordBaru.Text != string.Empty && tbKonfPasswordBaru.Text != string.Empty)
                {
                    if (db.tbKaryawans.Where(x => x.Password == tbPasswordLama.Text).Count() > 0)
                    {
                        if (tbPasswordBaru.Text == tbKonfPasswordBaru.Text)
                        {
                            KaryawanMasuk.Password = tbPasswordBaru.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Password anda berhasil dirubah silahkan masukan password baru untuk melakukan login berikutnya.","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password baru anda tidak sesuai dengan konfirmasi password baru, harap periksa kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password lama anda salah, harap periksa kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Data yang anda masukan tidak lengkap, harap periksa kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Password baru TIDAK BERHASIL dirubah.","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
