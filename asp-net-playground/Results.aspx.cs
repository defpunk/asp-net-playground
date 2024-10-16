using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net_playground
{
    public partial class Results : System.Web.UI.Page
    {
        protected string winner = "what no winner!";

        protected void Page_Load(object sender, EventArgs e)
        {
            winner = Request.QueryString["winner"];
        }
    }
}