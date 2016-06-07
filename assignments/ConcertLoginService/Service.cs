using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IConcertLoginService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public void AddArtist(Artist p)
    {
        Artist artist = new Artist();
        artist.ArtistName = p.ArtistName;
        artist.ArtistEmail = p.ArtistEmail;
        artist.ArtistWebPage = p.ArtistWebPage;
        artist.ArtistDateEntered = DateTime.Now;

        db.Artists.Add(artist);
        db.SaveChanges();
    }


    public void AddShow(Show k)
    {
        Show show = new Show();
        show.ShowName = k.ShowName;
        show.ShowDate = k.ShowDate;
        show.ShowDateEntered = DateTime.Now;
        show.ShowTime = k.ShowTime;
        show.ShowTicketInfo = k.ShowTicketInfo;
        
        if (k.ShowDetails != null)
        {
            foreach (ShowDetail a in k.ShowDetails)
            {
                ShowDetail sd = db.ShowDetails.FirstOrDefault(x => x.Artist.Equals(a.Artist));
                show.ShowDetails.Add(sd);
                
            }
        }
        
    }

    public int VenueLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_venueLogin(username, password);
        if(pass != -1)
        {
            var ven = from r in db.VenueLogins
                      where r.VenueLoginUserName.Equals(username)
                      select new { r.VenueKey };
            foreach(var k in ven)
            {
                key = (int)k.VenueKey;
            }
        }

        return key;
    }

    public int VenueRegistration(VenueInfo r)
    {
        int worked = db.usp_RegisterVenue(r.VenueName, r.VenueAddress, r.VenueCity,
            r.VenueState, r.VenueZipcode, r.VenuePhone,
            r.VenueEmail, r.VenueWebpage, r.VenueAgeRestriction,
            r.VenueLoginUserName, r.VenuePasswordPlaintext);

        return worked;

    }
}
