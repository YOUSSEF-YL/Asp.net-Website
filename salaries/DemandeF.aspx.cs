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
    public partial class DemandeF : System.Web.UI.Page
    {

        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Labelerror.Visible = false;
            da = new SqlDataAdapter("select * from Demandes", cnx);
            da.Fill(ds, "Demandes");


              idforma.Text = Session["iddemand"].ToString();

            dateDem.Text = DateTime.Now.ToShortDateString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idsala;
            idsala = 1;


            

            try
            {
                DataRow row1 = ds.Tables["Demandes"].NewRow();
               // row1[0] = "";
                row1[1] = dateDem.Text;
                row1[2] = Motif.Text;
                row1[3] = idsala.ToString();
                row1[4] = "encours";
                row1[5] = idforma.Text;
                ds.Tables["Demandes"].Rows.Add(row1);

                SqlCommandBuilder sbuilder = new SqlCommandBuilder(da);
                da.Update(ds, "Demandes");

                Labelerror.Text = " votre demande est en cours de traitement".ToUpper();
                Labelerror.Visible = true;
            }
            catch (Exception)
            {

                Labelerror.Text = "votre demande n'est pas envoyée".ToUpper();
                Labelerror.Visible = true;

            }

        }
    }
}