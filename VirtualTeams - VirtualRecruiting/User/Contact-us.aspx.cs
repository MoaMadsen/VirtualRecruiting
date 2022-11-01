using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirtualTeams___VirtualRecruiting.User
{
    public partial class Contact_us : System.Web.UI.Page
    {
        SqlConnection Con;
        SqlCommand cmd;
        string str = configurationManager.ConnectionString["cs"].ConnectionString
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
           try
            {

            }
        }   
    }
}