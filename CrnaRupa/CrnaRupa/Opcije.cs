using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrnaRupa
{
    public partial class Opcije : Form
    {
        private int vrijemePrikazivanjaKuglica;
        public Opcije()
        {
            InitializeComponent();
            tbVrijemePrikazivanjaKuglica.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbVrijemePrikazivanjaKuglica.Text, out vrijemePrikazivanjaKuglica))
            {
                CrnaRupa crnaRupa = new CrnaRupa(vrijemePrikazivanjaKuglica);
                crnaRupa.ShowDialog();

                tbVrijemePrikazivanjaKuglica.Clear();
                tbVrijemePrikazivanjaKuglica.Focus();
            }
            else
            {
                MessageBox.Show("U polje mora biti cio broj veći od nule!");
                tbVrijemePrikazivanjaKuglica.Clear();
                tbVrijemePrikazivanjaKuglica.Focus();
            }
        }
    }
}
