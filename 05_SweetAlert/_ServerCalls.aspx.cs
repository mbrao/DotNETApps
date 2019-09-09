using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05_SweetAlert
{
    public partial class _ServerCalls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _msg = string.Format("clientMessage('{0}')", DateTime.Now.ToString());

            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", _msg, true);
        }
    }
}