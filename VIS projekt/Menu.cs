using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIS_projekt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void novyTiketBtn_Click(object sender, EventArgs e)
        {
            var novyTiket = new novyTiketForm();
            this.Hide();
            novyTiket.Show();
        }

        private void prirazeniBtn_Click(object sender, EventArgs e)
        {
            var prirazeni = new PrirazeniForm();
            this.Hide();
            prirazeni.Show();
        }
    }
}
