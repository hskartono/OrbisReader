using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class PSNStoreData
    {
        public List<Entitlement> entitlements { get; set; }
        public long revision_id { get; set; }
        public int start { get; set; }
        public int total_results { get; set; }
    }
}
