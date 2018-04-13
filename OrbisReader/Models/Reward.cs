using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisReader
{
    public class Reward
    {
        public int available_count { get; set; }
        public int count_until_expiration { get; set; }
        public string expiration_date { get; set; }
        public int price_after_discount { get; set; }
        public string promo_sku_id { get; set; }
        public int rewardType { get; set; }
        public string reward_id { get; set; }
        public int reward_status { get; set; }
        public string sku_name { get; set; }
        public int time_until_expiration { get; set; }
    }
}
