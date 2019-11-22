using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * From [employee]";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                table.Append("<table border='1'>");
                table.Append("<tr><th> Employee ID </th> <th> First Name </th> <th> Last Name</th> <th> Address 1 </th> <th> Address 2 </th> <th> City </th> <th> State </th> <th> zip</th>");
                table.Append("</tr");


                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        table.Append("<br>");
                        table.Append("<tr>");
                        table.Append("<td>" + rd[0] + "</td>");
                        table.Append("<td>" + rd[1] + "</td>");
                        table.Append("<td>" + rd[2] + "</td>");
                        table.Append("<td>" + rd[4] + "</td>");
                        table.Append("<td>" + rd[5] + "</td>");
                        table.Append("<td>" + rd[6] + "</td>");
                        table.Append("<td>" + rd[7] + "</td>");
                        table.Append("<td>" + rd[8] + "</td>");
                        table.Append("</tr>");
                    }
                }
            
            table.Append("</table>");
            PlaceHolder1.Controls.Add(new Literal { Text = table.ToString() });
                rd.Close();
                

        }       
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}