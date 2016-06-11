using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IConcertLoginService
{
    [OperationContract]
    int FanLogin(string username, string password);

    [OperationContract]
    int VenueLogin(string username, string password);

    [OperationContract]
    int VenueRegistration(VenueInfo r);

    [OperationContract]
    int FanRegistration(FanInfo n);

    [OperationContract]
    void AddShow(Show k, ShowDetail p);

    [OperationContract]
    void AddArtist(Artist p);

    [OperationContract]
    int AddFanArtist(int fanKey, string artistName);

    [OperationContract]
    int RemoveFanArtist(int fanKey, string artistName);

    [OperationContract]
    List<ShowInfo> GetShowsForFanArtists(int fanKey);

}



[DataContract]
public class ShowInfo
{
    [DataMember]
    public string ShowName { get; set; }

    [DataMember]
    public DateTime ShowDate { get; set; }

    [DataMember]
    public string ShowVenue { get; set; }

    [DataMember]
    public string ShowArtist { get; set; }

    [DataMember]
    public DateTime ShowDateEntered { get; set; }

    [DataMember]
    public string ShowTicketInfo { get; set; }

    [DataMember]
    public TimeSpan ShowTime { get; set; }
}

[DataContract]
public class FanInfo
{
    [DataMember]
    public string FanName { get; set; }

    [DataMember]
    public string FanUserName { get; set; }

    [DataMember]
    public string FanEmail { get; set; }

    [DataMember]
    public string FanPassword { get; set; }
}

[DataContract]
public class FanFollow
{
    [DataMember]
    public int ArtistKey { get; set; }

    [DataMember]
    public int FanKey { get; set; }
}

[DataContract]
public class VenueInfo
{
	[DataMember]
    public string VenueName { get; set; }

    [DataMember]
    public string VenueAddress { get; set; }

    [DataMember]
    public string VenueCity { get; set; }

    [DataMember]
    public string VenueState { get; set; }

    [DataMember]
    public string VenueZipcode { get; set; }

    [DataMember]
    public string VenuePhone { get; set; }

    [DataMember]
    public string VenueEmail { get; set; }

    [DataMember]
    public string VenueWebpage { get; set; }

    [DataMember]
    public int VenueAgeRestriction { get; set; }

    [DataMember]
    public string VenueLoginUserName { get; set; }

    [DataMember]
    public string VenuePasswordPlaintext { get; set; }


}
