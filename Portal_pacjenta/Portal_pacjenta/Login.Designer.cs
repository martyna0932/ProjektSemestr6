namespace Portal_pacjenta
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLoginCard = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();

            // LoginForm
            this.ClientSize = new System.Drawing.Size(1150, 750); /
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(41, 53, 65); 
            this.Text = "Logowanie - Portal Pacjenta";

            // Karta logowania 
            this.pnlLoginCard.BackColor = System.Drawing.Color.White;
            this.pnlLoginCard.Size = new System.Drawing.Size(400, 450);
            this.pnlLoginCard.Location = new System.Drawing.Point(375, 150); 

            this.lblWelcome.Text = "Zaloguj się";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Size = new System.Drawing.Size(400, 80);
            this.lblWelcome.Location = new System.Drawing.Point(0, 30);

            // Etykiety i Pola
            this.lblLogin.Text = "Login / E-mail";
            this.lblLogin.Location = new System.Drawing.Point(50, 130);
            this.lblLogin.Size = new System.Drawing.Size(300, 20);

            this.txtLogin.Location = new System.Drawing.Point(50, 155);
            this.txtLogin.Size = new System.Drawing.Size(300, 35);
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblPass.Text = "Hasło";
            this.lblPass.Location = new System.Drawing.Point(50, 210);
            this.lblPass.Size = new System.Drawing.Size(300, 20);

            this.txtPassword.Location = new System.Drawing.Point(50, 235);
            this.txtPassword.Size = new System.Drawing.Size(300, 35);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.UseSystemPasswordChar = true; // Ukrywanie hasła

            // Przycisk logowania
            this.btnLogin.Text = "ZALOGUJ";
            this.btnLogin.Location = new System.Drawing.Point(50, 320);
            this.btnLogin.Size = new System.Drawing.Size(300, 50);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;

           
            this.pnlLoginCard.Controls.Add(this.lblWelcome);
            this.pnlLoginCard.Controls.Add(this.lblLogin);
            this.pnlLoginCard.Controls.Add(this.txtLogin);
            this.pnlLoginCard.Controls.Add(this.lblPass);
            this.pnlLoginCard.Controls.Add(this.txtPassword);
            this.pnlLoginCard.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlLoginCard);
        }
    }
}