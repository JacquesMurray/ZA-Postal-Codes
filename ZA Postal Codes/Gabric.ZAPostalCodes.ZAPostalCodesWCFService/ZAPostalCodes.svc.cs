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
            List<Area> returnAreas;
            
            using (ZAPostalCodesModel dataModel = new ZAPostalCodesModel())
            {
                returnAreas = dataModel.Areas.ToList<Area>();
            }

            return returnAreas;
        }

        public List<Suburb> GetSuburbs()
        {
            List<Suburb> returnSuburbs;

            using (ZAPostalCodesModel dataModel = new ZAPostalCodesModel())
            {
                returnSuburbs = dataModel.Suburbs.ToList<Suburb>();
            }

            return returnSuburbs;
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
