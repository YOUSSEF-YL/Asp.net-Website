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
    public partial class Mesformation : System.Web.UI.Page
    {
        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(" select * from formations f join suivre  s on f.id_forma=s.id_forma where s.id_salarie = '" + Session["id"].ToString()+ "'", cnx);
            da.Fill(ds, "forma");
            Repeater1.DataSource = ds.Tables["forma"];
            Repeater1.DataBind();

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}