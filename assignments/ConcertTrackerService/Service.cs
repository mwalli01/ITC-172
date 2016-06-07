using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : ShowsService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
    public List<string> GetArtists()
    {
        var artists = from r in db.Artists
                    orderby r.ArtistName
                    select new { r.ArtistName };

        List<string> listArtists = new List<string>();
        foreach (var r in artists)
        {
            listArtists.Add(r.ArtistName.ToString());
        }

        return listArtists;

    }

    public List<string> GetShowList()
    {
        var shows = from r in db.Shows
                    orderby r.ShowName
                    select new { r.ShowName };

        List<string> listShows = new List<string>();
        foreach(var r in shows)
        {
            listShows.Add(r.ShowName.ToString());
        }

        return listShows;
    }



    public List<string> GetVenues()
    {
        var venues = from r in db.Venues
                     orderby r.VenueName
                     select new { r.VenueName };
        List<string> listVenues = new List<string>();
        foreach(var r in venues)
        {
            listVenues.Add(r.VenueName.ToString());
        }

        return listVenues;
    }

    public List<ShowInfo> GetVenueShows(string selectVenue)
    {
        var shows = from e in db.Venues
                    from p in e.Shows
                    where p.Venue.VenueName.Equals(selectVenue)
                    select new { p.ShowDate, p.ShowTime, p.ShowName, };
        List<ShowInfo> shoInfo = new List<ShowInfo>();
        foreach(var k in shows)
        {
            ShowInfo si = new ShowInfo();
            si.ShowDate = k.ShowDate;
            si.ShowTime = k.ShowTime;
            si.ShowName = k.ShowName.ToString();

            shoInfo.Add(si);
        }
        return shoInfo;
    }
    public List<ShowInfo> GetArtistShows(string artistName)
    {
        var arShows = from e in db.Artists
                      from p in e.ShowDetails
                      where p.Artist.ArtistName.Equals(artistName)
                      select new { p.Show.ShowName, p.Show.ShowDate, p.Show.ShowTime, p.Show.Venue.VenueName, p.Artist.ArtistName };
        List<ShowInfo> artistShows = new List<ShowInfo>();
        foreach(var k in arShows)
        {
            ShowInfo ai = new ShowInfo();
            ai.ArtistName = k.ArtistName.ToString();
            ai.ShowName = k.ShowName.ToString();
            ai.ShowDate = k.ShowDate;
            ai.ShowTime = k.ShowTime;
            ai.VenueName = k.VenueName.ToString();

            artistShows.Add(ai);
        }
        return artistShows;
    }
    
    public List<ShowInfo> GetShows(string showName)
    {
        var dShows = from e in db.Artists
                     from p in e.ShowDetails
                     where p.Show.ShowName.Equals(showName)
                     select new { p.Show.ShowName, p.Show.ShowDate, p.Show.ShowTime, p.Show.Venue.VenueName, p.Artist.ArtistName };
        List<ShowInfo> listShows = new List<ShowInfo>();
        foreach (var k in listShows)
        {
            ShowInfo ai = new ShowInfo();
            ai.ArtistName = k.ArtistName.ToString();
            ai.ShowName = k.ShowName.ToString();
            ai.ShowDate = k.ShowDate;
            ai.ShowTime = k.ShowTime;
            ai.VenueName = k.VenueName.ToString();

            listShows.Add(ai);
        }
        return listShows;
    }
}
