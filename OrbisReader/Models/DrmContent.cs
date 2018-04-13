using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class DrmContent
    {
        public int bitrate { get; set; }
        public string contentId { get; set; }
        public string contentName { get; set; }
        public object contentSize { get; set; }
        public string contentUrl { get; set; }
        public int downloadType { get; set; }
        public int drmContentType { get; set; }
        public int drmType { get; set; }
        public int gracePeriod { get; set; }
        public object platformIds { get; set; }
        public int position { get; set; }
        public string spName { get; set; }
        public string titleName { get; set; }
    }
}
