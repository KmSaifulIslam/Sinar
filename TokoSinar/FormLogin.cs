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
    public partial class FormLogin : Form
    {
        TokoSinarDB db = new TokoSinarDB();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.tbKaryawans.Where(x => x.Username == tbUsername.Text && x.Password == tbPassword.Text).Count() > 0)
            {
                FormMenuUtama fmu = new FormMenuUtama(tbUsername.Text);
                fmu.ShowDialog();
                tbUsername.Text = string.Empty;
                tbPassword.Text = string.Empty;
                tbUsername.Focus();
            }
            else
            {
                MessageBox.Show("Harap isi kolom Username atau Password dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Text = string.Empty;
                tbUsername.Focus();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
