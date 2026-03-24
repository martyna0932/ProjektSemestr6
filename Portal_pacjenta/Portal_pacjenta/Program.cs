using Portal_pacjenta;
using System;
using System.Windows.Forms;

namespace Portal_pacjenta
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            LoginForm login = new LoginForm();

            
            if (login.ShowDialog() == DialogResult.OK)
            {
               
                Application.Run(new Form1());
            }
            else
            {
               
                Application.Exit();
            }
        }
    }
}