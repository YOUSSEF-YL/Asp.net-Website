using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formation
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["typelogin"].ToString() == "salarie")
            {
                // SiteMapDataSource1.EnableViewState = true;
                TreeView1.Visible = true;
                TreeView1.DataSourceID = "SiteMapDataSource1";
                NAVsalarie.Visible = true;
            }
            else
            {
                TreeView1.DataSourceID = "SiteMapDataSource2";
                NAVRH.Visible = true;
            }

            nom.Text = "NOM: " + Session["nom"].ToString().ToUpper();
            Prenom.Text = "PRENOM: " + Session["prenom"].ToString().ToUpper();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}