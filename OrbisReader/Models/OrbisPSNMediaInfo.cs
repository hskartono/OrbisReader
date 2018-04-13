using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrbisReader.Models
{
    public class OrbisPSNMediaInfo
    {
        public OrbisPSNMediaInfo(string ContentId, string ContentTitle, long ContentSize, string ContentURL, string Platform, bool isPSPlus, string IconURL)
        {
            this.ContentId = ContentId;
            this.ContentTitle = ContentTitle;
            this.ContentSize = ContentSize;
            this.ContentURL = ContentURL;
            this.Platform = Platform;
            this.IsPSPlus = isPSPlus;
            this.IconURL = IconURL;
        }

        public string ContentId { set; get; }
        public string ContentTitle { set; get; }
        public long ContentSize { set; get; }
        public string ContentURL { set; get; }
        public string Platform { set; get; }
        public bool IsPSPlus { set; get; }
        public string IconURL { set; get; }
    }
}