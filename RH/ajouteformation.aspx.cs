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
    public partial class ajouteformation : System.Web.UI.Page
    {

        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from formations", cnx);
            da.Fill(ds, "forma");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataRow row1 = ds.Tables["forma"].NewRow();
           
            row1[1] = nom.Text;
            row1[2] = Descrip.Text;
            row1[3] = Dure.Text;
            row1[4] = DateDebut.Text;
            ds.Tables["forma"].Rows.Add(row1);
            SqlCommandBuilder sbuilder = new SqlCommandBuilder(da);
            da.Update(ds, "forma");
        }
    }
}