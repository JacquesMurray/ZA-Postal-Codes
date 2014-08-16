using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Gabric.ZAPostalCodes.ZAPostalCodesWCFService
{
    public class ZAPostalCodes : IZAPostalCodes
    {
        public List<Area> GetAreas()
        {
            throw new NotImplementedException();
        }

        public List<Suburb> GetSuburbs()
        {
            throw new NotImplementedException();
        }

        public List<Area> SearchAreas(string searchArea)
        {
            throw new NotImplementedException();
        }

        public List<Suburb> SearchSuburbs(string searchSuburb)
        {
            throw new NotImplementedException();
        }

        public List<Suburb> SearchPostalCode(string searchPostalCode)
        {
            throw new NotImplementedException();
        }
    }
}
