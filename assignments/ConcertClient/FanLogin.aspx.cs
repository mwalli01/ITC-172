using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserLogin();
    }

    protected void UserLogin()
    {
        ConcertServiceReference1.ConcertLoginServiceClient csl =
            new ConcertServiceReference1.ConcertLoginServiceClient();

        int key = csl.FanLogin(UserNameTextBox.Text, PasswordTextBox.Text);
        if (key != 0)
        {
            Session["FanKey"] = key;
            ResultLabel.Text = "Welcome";
            Response.Redirect("FanPage.aspx");
        }
        else
        {
            ResultLabel.Text = "Access DENIED";
        }
    }
}
