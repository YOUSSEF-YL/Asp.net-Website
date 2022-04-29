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
    public partial class supprimerFormation : System.Web.UI.Page
    {

        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from formations ", cnx);
            da.Fill(ds, "forma");

            //foreach (DataRow row in ds.Tables["f"].Rows)
            //{
            //    DropDownList1.Items.Add(row[0].ToString());
            //}


        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            Labelerror.Visible = false;
            da = new SqlDataAdapter("select * from formations where id_forma ='" + DropDownList1.Text + "'", cnx);
            da.Fill(ds, "forma");



            nom.Text = ds.Tables["forma"].Rows[0][1].ToString();
            Descrip.Text = ds.Tables["forma"].Rows[0][2].ToString();
            Dure.Text = ds.Tables["forma"].Rows[0][3].ToString();
            DateDebut.Text = ds.Tables["forma"].Rows[0][4].ToString();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {



            try
            {
                da = new SqlDataAdapter("DELETE formations from formations where id_forma ='" + DropDownList1.SelectedValue + "'", cnx);
                da.Fill(ds, "forma");
                SqlCommandBuilder sbuilder = new SqlCommandBuilder(da);
                da.Update(ds, "forma");
                Labelerror.Text = "suppression est réussie".ToUpper();
                Labelerror.Visible = true;

              
            }
            catch (Exception)
            {
                Labelerror.Text = "Ce cours est réservé par les employés".ToUpper();
                Labelerror.Visible = true;
            }
           
           
        }
    }
}