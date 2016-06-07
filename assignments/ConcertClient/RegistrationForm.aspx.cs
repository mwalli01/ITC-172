using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterReviewer();
    }
    
    protected void RegisterReviewer()
    {
        ConcertServiceReference1.ConcertLoginServiceClient cls = new ConcertServiceReference1.ConcertLoginServiceClient();
        ConcertServiceReference1.VenueInfo venueInfo = new ConcertServiceReference1.VenueInfo();
        venueInfo.VenueLoginUserName = UserNameTextBox.Text;
        venueInfo.VenueName = VenueNameTextBox.Text;
        venueInfo.VenueEmail = EmailTextBox.Text;
        venueInfo.VenuePasswordPlaintext = ConfirmPasswordTextBox.Text;
        venueInfo.VenueAddress = VenueAddressTextBox.Text;
        venueInfo.VenueCity = VenueCityTextBox.Text;
        venueInfo.VenuePhone = VenuePhoneNumberTextBox.Text;
        venueInfo.VenueZipcode = VenueZipcodeTextBox.Text;
        venueInfo.VenueWebpage = VenueWebpageTextBox.Text;
        venueInfo.VenueState = VenueStateTextBox.Text;
        string AR = VenueAgeRestrictionTextBox.Text;
        int iAR = Convert.ToInt32(AR);
        venueInfo.VenueAgeRestriction = iAR;
        

        try
        {
            int result = cls.VenueRegistration(venueInfo);
            if (result == 1)
                Response.Redirect("ConcertLogin.aspx");
            else
                ErrorLabel.Text = "Registration not processed";
        }

        catch (Exception ex)
        {
            ErrorLabel.Text = ex.Message;
        }

    }

}
