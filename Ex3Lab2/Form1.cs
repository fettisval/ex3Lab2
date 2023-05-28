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

namespace Ex3Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int numar1 = int.Parse(txtNr1.Text);
            int numar2 = int.Parse(txtNr2.Text);

            int rezultat = numar1 + numar2;
            txtRez.Text = rezultat.ToString();
        }

        private void menuScadere_Click(object sender, EventArgs e)
        {
            int numar1 = int.Parse(txtNr1.Text);
            int numar2 = int.Parse(txtNr2.Text);

            int rezultat = numar1 - numar2;
            txtRez.Text = rezultat.ToString();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int numar1 = int.Parse(txtNr1.Text);
            int numar2 = int.Parse(txtNr2.Text);

            int rezultat = numar1 * numar2;
            txtRez.Text = rezultat.ToString();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int numar1 = int.Parse(txtNr1.Text);
            int numar2 = int.Parse(txtNr2.Text);

            int rezultat = numar1 / numar2;
            txtRez.Text = rezultat.ToString();
        }
    }
}
