using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DatabaseDrivenWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bnLogin_Click(object sender, EventArgs e)
        {
            DataLayer.DataConnector dat = new DataLayer.DataConnector("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= '"+Server.MapPath("MainData.accdb") + "'; Persist Security Info=false;");
            DataTable dt = dat.DateSelect("select UserID from tbl_login where Username = '"+txtUsername.Text.Replace("'","''")+"' and Password = '"+txtPassword.Text.Replace("'","''")+"'");
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}