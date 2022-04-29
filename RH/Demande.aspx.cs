using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formation.RH
{
    public partial class Demande : System.Web.UI.Page
    {
        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Demandes", cnx);
            da.Fill(ds, "Demandes");
            Repeater1.DataSource = ds.Tables["Demandes"];
            Repeater1.DataBind();

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string statut = "";

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                
                if (e.CommandName== "Refuse")
                {
                    statut = "refuse";
                }


                if (e.CommandName == "Accepte")
                {
                    statut = "accepte";
                }

                //Reference the Repeater Item.
                RepeaterItem item = e.Item;

                //Reference the Controls.
                string ctrlID = (item.FindControl("ctrlID") as Label).Text;

                foreach (DataRow row in ds.Tables["Demandes"].Rows)
                {
                    if (row[0].ToString() == ctrlID)
                    {
                        
                        ds.Tables["Demandes"].Rows[0][4] = statut;


                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Update(ds, "Demandes");
                    }
                }
            }
        }

       
    }
}