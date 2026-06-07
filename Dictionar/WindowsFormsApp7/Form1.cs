using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        List<Cuvant> RO;//lista cuvinte romana
        List<Cuvant> EN;//lista cuvinte engleza
        List<Cuvant> RO_EN;//lista cuvinte traduse din romana
        List<Cuvant> EN_RO;//lista cuvinte traduse din engleza
        List<Cuvant> rezultat_cautare;
        List<Cuvant> rezultat_traducere;
        void citeste_cuvinte()
        {
            RO = Cuvant.citeste_cuvinte("RO.txt");
            EN = Cuvant.citeste_cuvinte("EN.txt");
            RO_EN = Cuvant.citeste_cuvinte("RO_EN.txt");
            EN_RO = Cuvant.citeste_cuvinte("EN_RO.txt");
        }
        void cauta(String text)
        {
            rezultat_cautare = new List<Cuvant>();
            if (ROtoEN.Checked)
            {
                foreach (Cuvant cuv in RO)
                {
                    if (cuv.Text.StartsWith(text))
                        rezultat_cautare.Add(cuv);
                }
            }
            else
            {
                foreach (Cuvant cuv in EN)
                {
                    if (cuv.Text.StartsWith(text))
                        rezultat_cautare.Add(cuv);
                }
            }
            scrie_rezultat_cautare();
        }
        void scrie_rezultat_cautare()
        {
            l1.Items.Clear();
            l2.Items.Clear();
            foreach (Cuvant cuv in rezultat_cautare)
                l1.Items.Add(cuv.Text);
            if (l1.Items.Count > 0)
                l1.SelectedIndex = 0;
            l1.Refresh();
            l2.Refresh();
        }
        void cauta_traducere(Cuvant cuv)
        {
            rezultat_traducere = new List<Cuvant>();
            if (ROtoEN.Checked)
            {
                foreach (Cuvant cuvant in RO_EN)
                {
                    if (cuvant.Id == cuv.Id)
                        rezultat_traducere.Add(cuvant);
                }
            }
            else
            {
                foreach (Cuvant cuvant in EN_RO)
                {
                    if (cuvant.Id == cuv.Id)
                        rezultat_traducere.Add(cuvant);
                }
            }
            afiseaza_traducere();
        }
        void afiseaza_traducere()
        {
            l2.Items.Clear();
            foreach (Cuvant cuv in rezultat_traducere)
                l2.Items.Add(cuv.Text);
            l2.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            citeste_cuvinte();
            rezultat_cautare = new List<Cuvant>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cuvant.Text.Trim().Length > 0) cauta(cuvant.Text);
        }

        private void l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (l1.SelectedIndex >= 0)
                cauta_traducere(rezultat_cautare[l1.SelectedIndex]);
        }

        private void ENtoRO_Click(object sender, EventArgs e)
        {
            ENtoRO.Checked = true;
            ROtoEN.Checked = false;
        }

        private void ROtoEN_Click(object sender, EventArgs e)
        {
            ROtoEN.Checked = true;
            ENtoRO.Checked = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Versiunea 1.0");
        }

        private void cuvant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                button1.PerformClick();//simulează apăsarea butonului button1
        }
    }
}
