using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanRegistrationForm : System.Web.UI.Page
{
    ConcertServiceReference1.ConcertLoginServiceClient clsc = new ConcertServiceReference1.ConcertLoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FanSubmitButton_Click(object sender, EventArgs e)
    {
        RegisterFan();
    }

    protected void RegisterFan()
    {
        ConcertServiceReference1.FanInfo fi = new ConcertServiceReference1.FanInfo();
        fi.FanEmail = FanEmailTextBox.Text;
        fi.FanName = FanNameTextBox.Text;
        fi.FanUserName = FanUsernameTextBox.Text;
        fi.FanPassword = FanPasswordTextBox.Text;
        
        try
        {
            int result = clsc.FanRegistration(fi);
            if (result != 0)
                Response.Redirect("RegistrationSuccess.aspx");
            else
                ErrorLabel.Text = "Registration not processed";
        }

        catch (Exception ex)
        {
            ErrorLabel.Text = ex.Message;
        }
    }
}
