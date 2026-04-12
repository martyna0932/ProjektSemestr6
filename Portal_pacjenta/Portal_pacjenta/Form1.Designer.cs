namespace Portal_pacjenta
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNavUpcoming;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavBook;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();

            // Form1
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(244, 247, 246);

            // Sidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 240;

            this.lblLogo.Text = "MED-Net - Konto pacjenta";
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Size = new System.Drawing.Size(240, 80);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //Guziczki
            this.btnNavUpcoming = CreateMenuBtn("Nadchodzące wizyty", 100);
            this.btnNavHistory = CreateMenuBtn("Historia leczenia", 160);
            this.btnNavBook = CreateMenuBtn("ZAREZERWUJ WIZYTĘ", 220);
            this.btnNavBook.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnNavBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Nagłówek
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;

            this.lblTitle.Text = "Witaj w panelu pacjenta";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(600, 50);

            
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;

            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnNavUpcoming);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavBook);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
        }

        private System.Windows.Forms.Button CreateMenuBtn(string text, int top)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Text = "   " + text;
            btn.Size = new System.Drawing.Size(240, 55);
            btn.Location = new System.Drawing.Point(0, top);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            return btn;
        }
    }
}