using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Comments
namespace ASPForm1
{
    public partial class First : System.Web.UI.Page
    {
        int count = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Number.Text = "0";
            }
        }

        protected void OnButtonClicked(object sender, EventArgs e)
        {
            if(ViewState["Click"]!=null)
            {
                count = (int)ViewState["Click"] + 1;
            }

            ViewState["Click"] = count;
            Number.Text = count.ToString();
        }
    }
}