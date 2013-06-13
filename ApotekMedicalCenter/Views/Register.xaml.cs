using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ApotekMedicalCenter.Controllers;

namespace ApotekMedicalCenter.Views
{
    /// <summary>
    /// Register: menampilkan & memvalidasi borang registrasi pengguna
    /// </summary>
    public partial class Register : Window
    {
        private AkunController akunController = new AkunController();

        /// <summary>
        /// Register() dipanggil saat konstruksi form
        /// </summary>
        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validasi data yang diisi
        /// </summary>
        /// <returns>true jika valid</returns>
        private bool IsValid()
        {
            bool validation = true;

            if (textBoxUserName.Text == "" || passwordBoxPassword.Password == "" || passwordBoxConfirmPassword.Password == "")
            {
                textBlockMessage.Text += "- Semua bidang wajib diisi! Isi bidang yang kosong.\n";
                validation = false;
            }

            if (comboBoxHakAkses.SelectedIndex == -1)
            {
                textBlockMessage.Text += "- Anda belum memilih hak akses!\n";
                validation = false;
            }

            if (passwordBoxPassword.Password != passwordBoxConfirmPassword.Password)
            {
                textBlockMessage.Text += "- Password tidak cocok! Isi kembali password Anda.\n";
                passwordBoxPassword.Password = "";
                passwordBoxConfirmPassword.Password = "";
                validation = false;
            }

            return validation;
        }

        /// <summary>
        /// SubmitForm(): Mengirimkan data ke Controller Akun (AkunController)
        /// </summary>
        /// <param name="sender">Object: Form register itu sendiri</param>
        /// <param name="e"></param>
        private void SubmitForm(object sender, RoutedEventArgs e)
        {
            textBlockMessage.Text = "";

            if (!IsValid())
            {
                return;
            }

            Dictionary<string, string> registerData = new Dictionary<string,string>();

            registerData.Add("username", textBoxUserName.Text);
            registerData.Add("password", passwordBoxPassword.Password);
            registerData.Add("hak_akses", Convert.ToString(comboBoxHakAkses.SelectedIndex + 1));

            textBlockMessage.Text = "Harap tunggu. Proses registrasi sedang berlangsung.";

            // Kirim data registrasi
            if (akunController.Register(registerData))
            {
                textBlockMessage.Text = "Selamat! Registrasi berhasil.";
            }
            else
            {
                textBlockMessage.Text = "Registrasi gagal! Username telah digunakan.\n";
            }

            textBoxUserName.Text = "";
            passwordBoxPassword.Password = "";
            passwordBoxConfirmPassword.Password = "";
            comboBoxHakAkses.SelectedIndex = -1;
        }
    }
}
