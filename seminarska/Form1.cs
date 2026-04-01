using class1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seminarska
{
    public partial class Form1 : Form
    {
        private Sejmisce sejmisce = new Sejmisce();
        private Dogodek trenutniDogodek;

        public Form1()
        {
            InitializeComponent();

            comboTip.Items.Add("Sejem");
            comboTip.Items.Add("Razstava");

            comboElement.Items.Add("Kip");
            comboElement.Items.Add("Slika");
            comboElement.Items.Add("InteraktivniEksponat");
            comboElement.Items.Add("Stojnica");

            listDogodki.SelectedIndexChanged += listDogodki_SelectedIndexChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboTip.SelectedIndex = 0;
            comboElement.SelectedIndex = 0;

            progressBar1.Value = 0;

            listLog.Items.Add("Aplikacija zagnana");
        }
        private void listDogodki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDogodki.SelectedItem == null) return;

            trenutniDogodek = (Dogodek)listDogodki.SelectedItem;

            lblOpis.Text = trenutniDogodek.PodrobenOpis();

            progressBar1.Value = Math.Min(100, trenutniDogodek.ObremenitevHale());

            OsveziElemente();
            OsveziProgram();
        }

        private void PoveziEvente(Dogodek d)
        {
            d.OnElementDodan += (msg) =>
            {
                listLog.Items.Add(msg);
            };

            d.OnElementOdstranjen += (msg) =>
            {
                listLog.Items.Add(msg);
            };

            d.OnZapolnitevSpremenjena += (msg) =>
            {
                progressBar1.Value = Math.Min(100, d.ObremenitevHale());
            };

            d.OnPreobremenitev += (msg) =>
            {
                MessageBox.Show(msg);
            };
        }
        private void OsveziDogodke()
        {
            listDogodki.Items.Clear();

            foreach (var d in sejmisce.Dogodki)
            {
                listDogodki.Items.Add(d);
            }
        }

        private void OsveziElemente()
        {
            listElementi.Items.Clear();

            if (trenutniDogodek is Razstava r)
            {
                for (int i = 0; i < r.SteviloElementov(); i++)
                    listElementi.Items.Add("Eksponat " + (i + 1));
            }
            else if (trenutniDogodek is Sejem s)
            {
                for (int i = 0; i < s.SteviloElementov(); i++)
                    listElementi.Items.Add("Stojnica " + (i + 1));
            }
        }

        private void OsveziProgram()
        {
            listProgram.Items.Clear();

            foreach (var p in trenutniDogodek.Program)
                listProgram.Items.Add(p.ToString());
        }


        private void listProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProgram.Items.Clear();

            foreach (var p in trenutniDogodek.Program)
            {
                listProgram.Items.Add(p.ToString());
            }
        }
        private void btnDodajDogodek_Click(object sender, EventArgs e)
            {
                if (comboTip.SelectedItem == null)
                {
                    MessageBox.Show("Izberi tip dogodka!");
                    return;
                }

                string tip = comboTip.SelectedItem.ToString();

                if (tip == "Sejem")
                {
                    trenutniDogodek = new Sejem(
                        txtNaziv.Text,
                        txtHala.Text,
                        dtOd.Value,
                        (int)(dtDo.Value - dtOd.Value).TotalDays,
                        10,
                        0);
                }
                else
                {
                    trenutniDogodek = new Razstava(
                        txtNaziv.Text,
                        txtHala.Text,
                        dtOd.Value,
                        (int)(dtDo.Value - dtOd.Value).TotalDays + 1,
                        10,
                        false);
                }
                PoveziEvente(trenutniDogodek);

                sejmisce.DodajDogodek(trenutniDogodek);

                OsveziDogodke();

                listDogodki.SelectedItem = trenutniDogodek;
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            var d = sejmisce.Dogodki;

            if (d.Count == 0)
            {
                lblStatistika.Text = "Ni dogodkov";
                return;
            }

            lblStatistika.Text =
                "Število: " + d.Count +
                "\nPovprečje: " + Analitika.Povprecje(d) +
                "\nSkupno: " + Analitika.Skupna(d);
        }

        private void btnDodajElement_Click(object sender, EventArgs e)
        {
            if (trenutniDogodek == null)
            {
                MessageBox.Show("Najprej izberi dogodek!");
                return;
            }

            if (comboElement.SelectedItem == null)
            {
                MessageBox.Show("Izberi tip elementa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNazivElementa.Text))
            {
                MessageBox.Show("Vpiši naziv elementa!");
                return;
            }

            string tip = comboElement.SelectedItem.ToString();

            if (trenutniDogodek is Razstava r)
            {
                if (tip == "Kip")
                    r += new Kip(txtNazivElementa.Text, (int)numPovrsina.Value);
                else if (tip == "Slika")
                    r += new Slika(txtNazivElementa.Text, (int)numPovrsina.Value);
                else if (tip == "InteraktivniEksponat")
                    r += new InteraktivniEksponat(txtNazivElementa.Text, (int)numPovrsina.Value);
                else
                {
                    MessageBox.Show("Stojnica je samo za sejem!");
                    return;
                }
            }
            else if (trenutniDogodek is Sejem s)
            {
                if (tip == "Stojnica")
                    s += new Stojnica(txtNazivElementa.Text, (int)numPovrsina.Value);
                else
                {
                    MessageBox.Show("Eksponati so samo za razstavo!");
                    return;
                }
            }

            OsveziElemente();
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            if (trenutniDogodek == null) return;

            int i = listElementi.SelectedIndex;
            if (i == -1) return;

            if (trenutniDogodek is Razstava r)
                r.Odstrani(i);

            if (trenutniDogodek is Sejem s)
                s.Odstrani(i);

            OsveziElemente();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            trenutniDogodek = null;

            txtNaziv.Clear();
            txtHala.Clear();
            txtNazivElementa.Clear();
            txtProgramNaziv.Clear();
            comboTip.SelectedIndex = -1;
            comboElement.SelectedIndex = -1;
            dtOd.Value = DateTime.Now;
            dtDo.Value = DateTime.Now;
            numPovrsina.Value = 1;
            listDogodki.Items.Clear();
            listElementi.Items.Clear();
            listProgram.Items.Clear();
            listLog.Items.Clear();
            lblOpis.Text = "";
            lblStatistika.Text = "";
            progressBar1.Value = 0;
        }

        private void btnDodajProgram_Click_1(object sender, EventArgs e)
        {
            if (trenutniDogodek == null)
            {
                MessageBox.Show("Najprej izberi dogodek!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProgramNaziv.Text))
            {
                MessageBox.Show("Vpiši naziv programa!");
                return;
            }

            TimeSpan od = new TimeSpan(timeProgramOd.Value.Hour, 0, 0);
            TimeSpan konec = new TimeSpan(timeProgramDo.Value.Hour, 0, 0);

            ProgramDogodka p = new ProgramDogodka(
                txtProgramNaziv.Text,od,konec);

            trenutniDogodek.Program.Add(p);
            listProgram.Items.Add(p.ToString());
        }
    }
}
