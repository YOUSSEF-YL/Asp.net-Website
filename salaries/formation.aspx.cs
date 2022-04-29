using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Formation.salaries
{
    public partial class formation : System.Web.UI.Page
    {
        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from formations", cnx);
            da.Fill(ds, "forma");
            Repeater1.DataSource = ds.Tables["forma"];
            Repeater1.DataBind();
            

           


          
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            //if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            //{
            //    HtmlGenericControl ctrlID = e.Item.FindControl("ctrlID") as HtmlGenericControl;
            //    string id = ctrlID.InnerHtml;  //value here
            //    Session["iddemand"] = id;
            //    Response.Redirect("DemandeF.aspx");

            //}

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Reference the Repeater Item.
                RepeaterItem item = e.Item;
                
                //Reference the Controls.
                string ctrlID = (item.FindControl("ctrlID") as Label).Text;

                Session["iddemand"] = ctrlID;
                //Repeater1.Items[e.Item.ItemIndex].ItemIndex.ToString();
                Response.Redirect("DemandeF.aspx");

            }
        }



       
    }
}