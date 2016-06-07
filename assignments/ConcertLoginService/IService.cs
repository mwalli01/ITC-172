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
    int VenueLogin(string username, string password);

    [OperationContract]
    int VenueRegistration(VenueInfo r);

    [OperationContract]
    void AddShow(Show k);

    [OperationContract]
    void AddArtist(Artist p);

	
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
