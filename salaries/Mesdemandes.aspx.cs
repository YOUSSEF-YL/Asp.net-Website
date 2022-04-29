using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Formation.salaries
{
    public partial class Mesdemandes : System.Web.UI.Page
    {

        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Demandes where id_salarie = '" + Session["id"].ToString()+ "'", cnx);
            da.Fill(ds, "Demandes");
            Repeater1.DataSource = ds.Tables["Demandes"];
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}