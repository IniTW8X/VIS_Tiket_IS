using BLL;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{

    TiketService ts;
    NotifikaceService ns;

    protected void Page_Load(object sender, EventArgs e)
    {
        ts = new TiketService();
        ns = new NotifikaceService();

    }

    protected void zkontrolovatBtn_Click(object sender, EventArgs e)
    {
        nactiListbox();
    }

    protected void priradBtn_Click(object sender, EventArgs e)
    {
        string[] words = listBox1.SelectedItem.ToString().Split('-');
        int t_ID = int.Parse(words[0]);

        if (ns.createNewNotification("Vasemu tiketu expirovala lhuta!", int.Parse(words[2]), int.Parse(words[0])) == 1)
        {
            string display1 = "Uživatel úspěšně notifikován!";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display1 + "');", true);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        else
        {
            string display1 = "Nastala chyba při vytváření notifikace!";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display1 + "');", true);
        }
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
}