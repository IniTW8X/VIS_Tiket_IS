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
    SkupinaService ss;


    protected void Page_Load(object sender, EventArgs e)
    {
        ts = new TiketService();
        ss = new SkupinaService();

        if (!Page.IsPostBack)
        {
            List<String> skupiny = ss.getSkupiny();
            foreach (var v in skupiny)
            {
                skupinaCombo.Items.Add(v);
            }
            skupinaCombo.SelectedIndex = 0;
        }

    }

    protected void zkontrolovatBtn_Click(object sender, EventArgs e)
    {
        nactiListbox();
    }

    protected void priradBtn_Click(object sender, EventArgs e)
    {
        string[] words = listBox1.SelectedItem.ToString().Split('-');
        int t_ID = int.Parse(words[0]);

        if (ts.assignTiketToGroup(t_ID, skupinaCombo.SelectedIndex + 1) == 1)
        {
            string display1 = "Tiket úspěšně přiřazen!";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display1 + "');", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                "alert('Nastala chyba při přiřazení tiketu!'); window.location='" +
                    Request.ApplicationPath + "Prirazeni.aspx';", true);
        }
        nactiListbox();
    }

    public void nactiListbox()
    {
        List<String> data = ts.getListOfAdminTikets();
        listBox1.Items.Clear();
        foreach (var v in data)
        {
            listBox1.Items.Add(v);
        }
    }
}