using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class License
    {
        public string entitlement_id { get; set; }
        public int feature_type { get; set; }
        public bool infinite_duration { get; set; }
        public string start_date { get; set; }
        public string expiration { get; set; }
    }
}
