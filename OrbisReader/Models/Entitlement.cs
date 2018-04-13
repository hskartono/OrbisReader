using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class Entitlement
    {
        public string active_date { get; set; }
        public bool active_flag { get; set; }
        public DrmDef drm_def { get; set; }
        public int entitlement_type { get; set; }
        public int feature_type { get; set; }
        public GameMeta game_meta { get; set; }
        public string id { get; set; }
        public string inactive_date { get; set; }
        public bool is_consumable { get; set; }
        public License license { get; set; }
        public bool preorder_flag { get; set; }
        public bool preorder_placeholder_flag { get; set; }
        public string product_id { get; set; }
        public object revision_id { get; set; }
        public string sku_id { get; set; }
        public bool subs_flag { get; set; }
        public int use_count { get; set; }
        public int use_limit { get; set; }
        public List<EntitlementAttribute> entitlement_attributes { get; set; }
        public string subscription_product_id { get; set; }
    }
}
