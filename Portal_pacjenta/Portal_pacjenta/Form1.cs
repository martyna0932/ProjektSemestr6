using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Portal_pacjenta
{
    public partial class Form1 : Form
    {
        //  lista wizyt
        private List<Wizyta> bazaWizyt = new List<Wizyta>();

        public Form1()
        {
            InitializeComponent();
            ZaładujDaneTestowe();

            //Guziczki
            btnNavUpcoming.Click += (s, e) => PokazNadchodzace();
            btnNavHistory.Click += (s, e) => PokazHistorie();
            btnNavBook.Click += (s, e) => PokazFormularzRezerwacji();

            // Widok startowy 
            PokazNadchodzace();
        }

        private void ZaładujDaneTestowe()
        {
            // Miejsce na baze
            bazaWizyt.Add(new Wizyta { Data = DateTime.Now.AddDays(2).AddHours(4), Lekarz = "dr Jan Kowalski", Specjalizacja = "Internista", Status = "Potwierdzona" });
            bazaWizyt.Add(new Wizyta { Data = DateTime.Now.AddDays(-15), Lekarz = "dr Anna Nowak", Specjalizacja = "Kardiolog", Status = "Zakończona" });
        }

        private void PokazNadchodzace()
        {
            lblTitle.Text = "Twoje nadchodzące wizyty";
            WyswietlTabele(bazaWizyt.Where(w => w.Data >= DateTime.Now).OrderBy(w => w.Data).ToList());
        }

        private void PokazHistorie()
        {
            lblTitle.Text = "Historia wizyt i zabiegów";
            WyswietlTabele(bazaWizyt.Where(w => w.Data < DateTime.Now).OrderByDescending(w => w.Data).ToList());
        }

        private void WyswietlTabele(List<Wizyta> dane)
        {
            pnlMainContent.Controls.Clear();
            DataGridView dgv = new DataGridView
            {
                DataSource = dane,
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(244, 247, 246),
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                GridColor = Color.LightGray
            };

            // Nagłowek
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 53, 65);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeight = 40;

            pnlMainContent.Padding = new Padding(30);
            pnlMainContent.Controls.Add(dgv);
        }

        private void PokazFormularzRezerwacji()
        {
            lblTitle.Text = "Zarezerwuj nową wizytę";
            pnlMainContent.Controls.Clear();
            pnlMainContent.Padding = new Padding(30);

          
            Panel card = new Panel { Size = new Size(450, 520), BackColor = Color.White, Location = new Point(30, 10) };
            card.Padding = new Padding(25);

            // Wybór lekarza
            Label l1 = CreateLabel("Wybierz specjalistę:");
            ComboBox cbLekarz = CreateCombo(new string[] { "dr Jan Kowalski (Internista)", "dr Anna Nowak (Kardiolog)", "dr Marek Zięba (Ortopeda)" });

            // Wybór daty
            Label l2 = CreateLabel("Wybierz dzień:");
            DateTimePicker dtp = new DateTimePicker { Dock = DockStyle.Top, Font = new Font("Segoe UI", 12), MinDate = DateTime.Now };

            // Wybór godziny
            Label l3 = CreateLabel("Wybierz godzinę:");
            ComboBox cbGodzina = CreateCombo(null);
            for (int h = 8; h <= 17; h++)
            {
                cbGodzina.Items.Add($"{h:00}:00");
                if (h != 17) cbGodzina.Items.Add($"{h:00}:30");
            }
            cbGodzina.SelectedIndex = 0;

            // Przycisk potwierdzenia
            Button btnSave = new Button
            {
                Text = "POTWIERDZAM REZERWACJĘ",
                Dock = DockStyle.Bottom,
                Height = 60,
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;

            btnSave.Click += (s, e) => {
                if (cbLekarz.SelectedIndex == -1) { MessageBox.Show("Wybierz lekarza!"); return; }

                DateTime termin = dtp.Value.Date.Add(TimeSpan.Parse(cbGodzina.SelectedItem.ToString()));

                // Miejsce na baze
                bazaWizyt.Add(new Wizyta
                {
                    Data = termin,
                    Lekarz = cbLekarz.SelectedItem.ToString(),
                    Specjalizacja = "Wizyta portalowa",
                    Status = "Zaplanowana"
                });

                MessageBox.Show($"Termin zarezerwowany: {termin:dd.MM.yyyy HH:mm}");
                PokazNadchodzace();
            };

            // 
            card.Controls.Add(btnSave);
            card.Controls.Add(CreateSpacer(40));
            card.Controls.Add(cbGodzina);
            card.Controls.Add(l3);
            card.Controls.Add(CreateSpacer(20));
            card.Controls.Add(dtp);
            card.Controls.Add(l2);
            card.Controls.Add(CreateSpacer(20));
            card.Controls.Add(cbLekarz);
            card.Controls.Add(l1);

            pnlMainContent.Controls.Add(card);
        }

      
        private Label CreateLabel(string text) => new Label { Text = text, Dock = DockStyle.Top, Height = 30, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
        private ComboBox CreateCombo(string[] items)
        {
            var cb = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 12) };
            if (items != null) cb.Items.AddRange(items);
            return cb;
        }
        private Panel CreateSpacer(int h) => new Panel { Dock = DockStyle.Top, Height = h };
    }
}