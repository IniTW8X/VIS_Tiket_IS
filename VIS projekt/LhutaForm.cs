using BLL;
using BLL.Services;
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
    public partial class LhutaForm: Form
    {
        TiketService ts;
        NotifikaceService ns;
        public LhutaForm()
        {
            InitializeComponent();
            ts = new TiketService();
            ns = new NotifikaceService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menu = new Menu();
            menu.Show();
        }

        public void nactiListbox()
        {
            List<String> data = ts.getListOfExpiredTikets();
            listBox1.Items.Clear();
            foreach (var v in data)
            {
                listBox1.Items.Add(v);
            }
        }

        private void kontrolaBtn_Click(object sender, EventArgs e)
        {
            nactiListbox();
        }

        private void notifikovatBtn_Click(object sender, EventArgs e)
        {
            string[] words = listBox1.SelectedItem.ToString().Split('-');
            int t_ID = int.Parse(words[0]);

            if (ns.createNewNotification("Vasemu tiketu expirovala lhuta!", int.Parse(words[2]), int.Parse(words[0])) == 1)
            {
                MessageBox.Show("Uživatel notifikován!",
                    "Notifikace");
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nastala chyba při notifikaci!",
                    "Notifikace");
            }
            //nactiListbox();
        }
    }
}
