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

    public int AddFanArtist(int fanKey, string artistName)
    {
        /*********************************
         * This method will add an artist to the artistFan
         * table. First we have to find the fan
         * and then the particular artist
         * Then we add the artist to the Fan's list
         * of artists to follow
         * **********************************/
        int result = 1;

        //get the fan. the key can come from their login
        Fan myFan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        //get the artist by name
        Artist myArtist = (from a in db.Artists
                           where a.ArtistName.Equals(artistName)
                           select a).First();

        //add the artist to the fan;'s collection of artists
        myFan.Artists.Add(myArtist);

        //save the changes
        db.SaveChanges();

        return result;
    }

    public int RemoveFanArtist(int fanKey, string artistName)
    {
 
        int result = 1;

        Fan fan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        Artist artist = (from a in db.Artists
                           where a.ArtistName.Equals(artistName)
                           select a).First();

        fan.Artists.Remove(artist);       
        db.SaveChanges();
        return result;
    }

    public List<ShowInfo> GetShowsForFanArtists(int fanKey)
    {
        //get the fan
        Fan myFan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        List<ShowInfo> shows = new List<ShowInfo>();

        //this loop within a loop is very inefficient
        foreach (Artist a in myFan.Artists)
        {
            //get all the shows for the fan
            var shws = from s in db.Shows
                       from sd in s.ShowDetails
                       where sd.ArtistKey == a.ArtistKey
                       select new
                       {
                           s.ShowName,
                           s.ShowTime,
                           s.ShowDate,
                           s.ShowTicketInfo,
                           s.Venue.VenueName,
                           sd.Artist.ArtistName
                       };

            //loop through the shows and write them to 
            //ShowInfo objects then add those objects
            //to the list
            foreach (var sh in shws)
            {
                ShowInfo info = new ShowInfo();
                info.ShowName = sh.ShowName;
                info.ShowDate = sh.ShowDate;
                info.ShowTime = sh.ShowTime;
                info.ShowTicketInfo = sh.ShowTicketInfo;
                info.ShowVenue = sh.VenueName;
                info.ShowArtist = sh.ArtistName;

                shows.Add(info);
            }


        }
        return shows;

    }


    public void AddShow(Show k, ShowDetail p)
    {
        Show show = new Show();
        ShowDetail showDetail = new ShowDetail();
        show.ShowName = k.ShowName;
        show.ShowDate = k.ShowDate;
        show.ShowDateEntered = DateTime.Now;
        show.ShowTime = k.ShowTime;
        show.ShowTicketInfo = k.ShowTicketInfo;
        show.VenueKey = k.VenueKey;

        showDetail.Show = show;
        showDetail.Artist = db.Artists.FirstOrDefault(x => x.ArtistName == p.Artist.ArtistName);
        showDetail.ShowDetailAdditional = p.ShowDetailAdditional;
        showDetail.ShowDetailArtistStartTime = p.ShowDetailArtistStartTime;
        

        //if (k.ShowDetails != null)
        //{
        //    foreach (ShowDetail a in k.ShowDetails)
        //    {
        //        ShowDetail sd = db.ShowDetails.FirstOrDefault(x => x.Artist.Equals(a.Artist)); 
        //        show.ShowDetails.Add(sd);
                
        //    }
        //}


        db.ShowDetails.Add(showDetail);
        db.Shows.Add(show);
        db.SaveChanges();

    }

    public int FanLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_FanLogin(username, password);
        if(pass != -1)
        {
            var fan = from r in db.FanLogins
                      where r.FanLoginUserName.Equals(username)
                      select new { r.FanKey };
            foreach(var k  in fan)
            {
                key = (int)k.FanKey;
            }            
        }
        return key;
    }

    
    public int FanRegistration(FanInfo n)
    {
        int worked = db.usp_RegisterFan(n.FanName, n.FanEmail, n.FanUserName, n.FanPassword);
        return worked;
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
