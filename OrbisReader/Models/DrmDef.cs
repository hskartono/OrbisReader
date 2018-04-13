using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class DrmDef
    {
        public bool active_flag { get; set; }
        public bool autoDownload { get; set; }
        public string availableDate { get; set; }
        public string contentName { get; set; }
        public string downloadableStatus { get; set; }
        public List<DrmContent> drmContents { get; set; }
        public int duration { get; set; }
        public string entitlementId { get; set; }
        public int firstPlayExpiration { get; set; }
        public int firstPlayExpirationHours { get; set; }
        public string image_url { get; set; }
        public int media_type { get; set; }
        public string productId { get; set; }
        public int release_date { get; set; }
        public int runtime { get; set; }
        public string salesType { get; set; }
        public bool startedStreaming { get; set; }
        public int year_release { get; set; }
        public List<Reward> rewards { get; set; }
        public string expiration { get; set; }
    }
}
