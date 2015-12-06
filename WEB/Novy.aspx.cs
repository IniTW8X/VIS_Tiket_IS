using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class About : Page
    {
        TiketService ts;

        protected void Page_Load(object sender, EventArgs e)
        {
            ts = new TiketService();
            if (!Page.IsPostBack)
            {
                
                idTxt.Text = ts.getNewTiketID().ToString();
                vytvorenoTxt.Text = ts.getDateTimeNow().ToString();
                vytvorenoTxt.Enabled = false;
                lhutaTxt.Enabled = false;

                kategorieCombo.SelectedIndex = 0;
                prioritaCombo.SelectedIndex = 1;

                lhutaTxt.Text = ts.calculateDeadline(DateTime.Parse(vytvorenoTxt.Text), prioritaCombo.SelectedIndex + 1).ToString();
        }
        }

    protected void vytvorBtn_Click(object sender, EventArgs e)
    {
        if (ts.createNewTicket(nazevTxt.Text, popisTxt.Text, prioritaCombo.SelectedIndex + 1, kategorieCombo.SelectedIndex + 1) == 1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
            "alert('Tiket úspěšně vytvořen!'); window.location='" +
            Request.ApplicationPath + "Novy.aspx';", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
            "alert('Při vytváření tiketu nastala chyba!'); window.location='" +
            Request.ApplicationPath + "Novy.aspx';", true);
        }
    }

    protected void prioritaCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
        lhutaTxt.Text = ts.calculateDeadline(DateTime.Parse(vytvorenoTxt.Text), prioritaCombo.SelectedIndex + 1).ToString();
    }

    protected void Reload()
    {
        Response.Redirect(Request.RawUrl);
    }
}