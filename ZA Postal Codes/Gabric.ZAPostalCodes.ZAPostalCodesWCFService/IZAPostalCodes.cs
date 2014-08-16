using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Gabric.ZAPostalCodes.ZAPostalCodesWCFService
{
    [ServiceContract]
    public interface IZAPostalCodes
    {
        [OperationContract]
        List<Area> GetAreas();

        [OperationContract]
        List<Suburb> GetSuburbs();

        [OperationContract]
        List<Area> SearchAreas(string searchArea);

        [OperationContract]
        List<Suburb> SearchSuburbs(string searchSuburb);

        [OperationContract]
        List<Suburb> SearchPostalCode(string searchPostalCode);
    }

    [DataContract]
    public class Area
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public virtual ICollection<Suburb> AreaSuburbs { get; set; }
    }

    [DataContract]
    public class Suburb
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string BoxCode { get; set; }
        [DataMember]
        public string StreetCode { get; set; }
        [DataMember]
        public virtual Area SuburbArea { get; set; }
    }
}
