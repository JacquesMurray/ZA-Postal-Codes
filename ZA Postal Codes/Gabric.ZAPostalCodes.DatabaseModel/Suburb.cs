using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gabric.ZAPostalCodes.DatabaseModel
{
    public class Suburb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BoxCode { get; set; }
        public string StreetCode { get; set; }
        public Area SuburbArea { get; set; }
    }
}
