using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Klasör_Kilitleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYeri = textBox1.Text;
                string kullaniciAdi = Environment.UserName;
                DirectorySecurity ds = Directory.GetAccessControl(dosyaYeri);
                FileSystemAccessRule fsa = new FileSystemAccessRule(kullaniciAdi, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.AddAccessRule(fsa);
                Directory.SetAccessControl(dosyaYeri, ds);
                MessageBox.Show("Kilitlendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYeri = textBox1.Text;
                string kullaniciAdi = Environment.UserName;
                DirectorySecurity ds = Directory.GetAccessControl(dosyaYeri);
                FileSystemAccessRule fsa = new FileSystemAccessRule(kullaniciAdi, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(dosyaYeri, ds);
                MessageBox.Show("Kilit Kaldırıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
