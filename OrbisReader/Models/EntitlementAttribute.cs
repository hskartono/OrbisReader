using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class EntitlementAttribute
    {
        public bool entitlement_key_flag { get; set; }
        public object package_file_size { get; set; }
        public bool placeholder_flag { get; set; }
        public string platform_id { get; set; }
        public string reference_package_url { get; set; }
        public string downloadable_date { get; set; }
    }
}
