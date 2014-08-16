using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gabric.ZAPostalCodes.DatabaseModel
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Suburb> AreaSuburbs { get; set; }
    }
}
