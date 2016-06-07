using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
public partial class _Default : System.Web.UI.Page
{
    ConcertTrackerServiceReference1.ShowsServiceClient ssc = new ConcertTrackerServiceReference1.ShowsServiceClient();
    ConcertServiceReference1.ConcertLoginServiceClient clsc = new ConcertServiceReference1.ConcertLoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateArtistDropDownList();
        }
    }

    protected void PopulateArtistDropDownList()
    {
        string[] artists = ssc.GetArtists();
        int al = artists.Count();        
        ArtistDropDownList.DataSource = artists;      
        ArtistDropDownList.DataBind();
        ArtistDropDownList.Items.Insert(0, "SELECT AN ARTIST");
        ArtistDropDownList.Items.Insert(al + 1, "ADD NEW ARTIST");
    }

    protected void ArtistDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ArtistDropDownList.SelectedItem.Text.Equals("ADD NEW ARTIST"))
        {
            AddArtistPanel.Visible = true;
        }
        else
            AddArtistPanel.Visible = false;

        if (!(ArtistDropDownList.SelectedItem.Text.Equals("ADD NEW ARTIST")) &&
            !(ArtistDropDownList.SelectedItem.Text.Equals("SELECT AN ARTIST")))
        {
            AddShowPanel.Visible = true;
        }
        else
            AddShowPanel.Visible = false;
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {

    }

    protected void AddNewShow()
    {
        ConcertServiceReference1.Show csr = new ConcertServiceReference1.Show();
        

        csr.ShowName = ShowNameBox.Text;
        string parseThisDate = DateBox.Text + ' ' + TimeBox.Text + ' ' + AmPmBox.Text;
        DateTime parsedDateTime = DateTime.Parse(parseThisDate);
        csr.ShowDate = parsedDateTime.Date;
        csr.ShowTime = parsedDateTime.TimeOfDay;
        //csr.ShowDetails = ArtistDropDownList.SelectedItem.Text;
        
        //csr. = Session["UserKey"];

        clsc.AddShow(csr)

    }
}
