using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminarska4
{
    public partial class Form1 : Form
    {
        List<string> dogodki = new List<string>();

        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izberi halo!");
                return;
            }

            string vrsta = radioButton1.Checked ? "Sejem" : "Razstava";
            string naziv = textBox1.Text;
            string hala = comboBox1.Text;
            int kolicina = (int)numericUpDown1.Value;

            string zapis = vrsta + " | " + naziv + " | Hala " + hala + " | Količina: " + kolicina;

            listBox1.Items.Add(zapis);
        }
    }
}
