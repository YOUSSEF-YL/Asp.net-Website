using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Formation
{
    public partial class Login : System.Web.UI.Page
    {
        string cnx = "Data Source=.;Initial Catalog=formation_catalog;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("select * from salaries", cnx);
            da.Fill(ds, "t");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ds.Tables["t"].Rows)
            {
                if (row[5].ToString() == nomut.Value && row[3].ToString() == pass.Text)
                {
                    Session["nom"] = row[1].ToString();
                    Session["prenom"] = row[2].ToString();
                    Session["id"] = row[0].ToString();

                    if (row[4].ToString() =="RH")
                    {
                        
                        Session["typelogin"] = "RH";
                        Response.Redirect("RH/Dashboard.aspx"); 
                    }
                    else
                    {
                       
                        //System.Threading.Thread.Sleep(6000);
                        Session["typelogin"] = "salarie";

                        Response.Redirect("salaries/formation.aspx");
                    }
                    break;

                }
                else
                {

                    //userinpt.Style.Add("class", "form-group has-danger");

                    nomut.Attributes["class"] = "form-control is-invalid"; 




                    //HtmlGenericControl div = new HtmlGenericControl("div");
                    ////<div class="invalid-feedback">Sorry, that username's taken. Try another?</div>
                    //div.Attributes["class"] = "invalid-feedback";
                    //userinpt.Controls.Add(div);
                }
            }
        }
    }
}