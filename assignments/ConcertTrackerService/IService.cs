using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract]
public interface ShowsService
{

    [OperationContract]
    List<string> GetVenues();

    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<string> GetShowList();

    [OperationContract]
    List<ShowInfo> GetVenueShows(string venueShows);

    [OperationContract]
    List<ShowInfo> GetArtistShows(string artistName);

    [OperationContract]
    List<ShowInfo> GetShows(string showName);

	
}


[DataContract]
public class ShowInfo
{

	[DataMember]
	public DateTime ShowDate { get; set; }

    [DataMember]
    public string ArtistName { get; set; }

    [DataMember]
    public string ShowName { get; set; }

    [DataMember]
    public TimeSpan ShowTime { get; set; }

    [DataMember]
    public string VenueName { get; set; }
}
