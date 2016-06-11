using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanPage : System.Web.UI.Page
{
    ConcertTrackerServiceReference1.ShowsServiceClient ssc = new ConcertTrackerServiceReference1.ShowsServiceClient();
    ConcertServiceReference1.ConcertLoginServiceClient clsc = new ConcertServiceReference1.ConcertLoginServiceClient();
    

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string[] artists = ssc.GetArtists();
            ArtistDropDownList.DataSource = artists;
            ArtistDropDownList.DataBind();
            ArtistDropDownList.Items.Insert(0, "Select An Artist");


            string[] venues = ssc.GetVenues();
            VenueDropDownList.DataSource = venues;
            VenueDropDownList.DataBind();
            VenueDropDownList.Items.Insert(0, "Select A Venue");

            string[] shows = ssc.GetShowList();
            ShowDropDownList.DataSource = shows;
            ShowDropDownList.DataBind();
            ShowDropDownList.Items.Insert(0, "Select A Show");

            FillFanShowGridView();
        }
    }

    
    protected void ArtistDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillArtistGridView();
    }

    protected void VenueDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillVenueGridView();
    }

    protected void ShowDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillShowGridView();
    }
    protected void FillArtistGridView()
    {
        string artist = ArtistDropDownList.SelectedItem.ToString();
        ConcertTrackerServiceReference1.ShowInfo[] showsList = ssc.GetArtistShows(artist);
        GridView1.DataSource = showsList;
        GridView1.DataBind();
    }

    protected void FillVenueGridView()
    {
        string venue = VenueDropDownList.SelectedItem.ToString();
        ConcertTrackerServiceReference1.ShowInfo[] showsList = ssc.GetVenueShows(venue);
        GridView1.DataSource = showsList;
        GridView1.DataBind();
    }

    protected void FillShowGridView()
    {
        string show = ShowDropDownList.SelectedItem.ToString();
        ConcertTrackerServiceReference1.ShowInfo[] showsList = ssc.GetShows(show);
        GridView1.DataSource = showsList;
        GridView1.DataBind();
    }


    protected void FollowArtistButton_Click(object sender, EventArgs e)
    {
        int fKey = (int)Session["FanKey"];
        string selArtist = ArtistDropDownList.SelectedItem.Text;
        clsc.AddFanArtist(fKey, selArtist);
        ConfirmedLabel.Text = "You are now following " + ArtistDropDownList.SelectedItem.Text;
        FillFanShowGridView();
    }
    
    protected void FillFanShowGridView()
    {
        int fKey = (int)Session["FanKey"];        
        ConcertServiceReference1.ShowInfo[] showsList = clsc.GetShowsForFanArtists(fKey);
        GridView2.DataSource = showsList;
        GridView2.DataBind();
    }

    protected void UnfollowArtistButton_Click(object sender, EventArgs e)
    {
        int fKey = (int)Session["FanKey"];
        string selArtist = ArtistDropDownList.SelectedItem.Text;
        clsc.RemoveFanArtist(fKey, selArtist);
        ConfirmedLabel.Text = "You have unfollowed " + ArtistDropDownList.SelectedItem.Text;
        FillFanShowGridView();
    }
}
