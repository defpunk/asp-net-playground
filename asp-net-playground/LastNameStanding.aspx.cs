using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net_playground
{
    public partial class LastNameStanding : System.Web.UI.Page
    {
        protected string selectedName = "Felix";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnInit(EventArgs e)
        {
            this.Load += new System.EventHandler(this.Page_Load);
            this.btnDone.ServerClick += new System.EventHandler(BtnDone_Click);
            this.btnUpdate.ServerClick += new System.EventHandler(BtnUpdate_Click);
            base.OnInit(e);
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            this.selectedName = txtName.Value;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Results.aspx?winner=" + Server.UrlEncode(txtName.Value));
        }
    }
}