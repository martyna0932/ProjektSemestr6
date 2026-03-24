using System;
using System.Windows.Forms;

namespace Portal_pacjenta
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

           
            btnLogin.Click += BtnLogin_Click;

            // Enter
            this.AcceptButton = btnLogin;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Miejsce na baze
            string login = txtLogin.Text;
            string pass = txtPassword.Text;

            if (login == "pacjent" && pass == "123")
            {
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło! Spróbuj: pacjent / 123", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}