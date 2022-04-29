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
    public partial class ÉditerFormation : System.Web.UI.Page
    {
        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)

        {

            //da = new SqlDataAdapter("select * from formations ", cnx);
            //da.Fill(ds, "f");

            //foreach (DataRow row in ds.Tables["f"].Rows)
            //{
            //    DropDownList1.Items.Add(row[0].ToString());
            //}
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from formations where id_forma ='" + DropDownList1.Text + "'", cnx);
            da.Fill(ds, "forma");

            

            nom.Text = ds.Tables["forma"].Rows[0][1].ToString();
            Descrip.Text = ds.Tables["forma"].Rows[0][2].ToString();
            Dure.Text = ds.Tables["forma"].Rows[0][3].ToString();
            DateDebut.Text = ds.Tables["forma"].Rows[0][4].ToString();
          
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from formations where id_forma ='" + DropDownList1.Text + "'", cnx);
            da.Fill(ds, "forma");



            ds.Tables["forma"].Rows[0][1] = nom.Text;

            ds.Tables["forma"].Rows[0][2] = Descrip.Text;

            ds.Tables["forma"].Rows[0][3] = Dure.Text;

            ds.Tables["forma"].Rows[0][4] = DateDebut.Text;

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            da.Update(ds, "forma");
        }
    }
}