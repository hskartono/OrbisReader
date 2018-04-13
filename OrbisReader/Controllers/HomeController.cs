using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrbisReader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection param)
        {
            String PSNJson = param["psnjson"];
            ViewBag.posted = true;
            ViewBag.error = String.Empty;
            ViewBag.datas = null;
            if (String.IsNullOrEmpty(PSNJson))
            {
                ViewBag.error = "You must paste your PSN Json content into text area before click the process button.";
                return View();
            }

            try
            {
                List<OrbisReader.Models.OrbisPSNMediaInfo> datas = this.ReadJsonContent(PSNJson);
                ViewBag.datas = datas;

                if (datas == null || datas.Count <= 0)
                {
                    ViewBag.error = "Failed to parse JSON or there is no data in your PSN account.";
                    return View();
                }
            } catch(Exception ex)
            {
                ViewBag.error = "Exception - " + ex.Message;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        private List<OrbisReader.Models.OrbisPSNMediaInfo> ReadJsonContent(String jsonContent)
        {
            String[] Platforms = { "-", "PSP/PS3/PSVITA", "-", "-", "PS4" };
            PSNStoreData data = new PSNStoreData();
            data = Newtonsoft.Json.JsonConvert.DeserializeObject<PSNStoreData>(jsonContent);

            List<OrbisReader.Models.OrbisPSNMediaInfo> results = new List<Models.OrbisPSNMediaInfo>();

            foreach (Entitlement item in data.entitlements)
            {
                String PSNContentId;
                String PSNContentTitle;
                long PSNContentSize;
                String PSNPackageSize;
                long platformId;
                bool IsPSPlusContent;
                String PSNPlatform;
                string PSNIconURL;

                if (item.entitlement_type == 2)  // PSP/PS3/PSVITA
                {
                    PSNContentId = item.product_id;
                    if (item.drm_def == null) continue;

                    PSNContentTitle = item.drm_def.contentName;
                    PSNContentSize = (long)item.drm_def.drmContents[0].contentSize;
                    PSNPackageSize = item.drm_def.drmContents[0].contentUrl;
                    platformId = (long)item.drm_def.drmContents[0].platformIds;
                    IsPSPlusContent = item.drm_def.drmContents[0].gracePeriod > 0;

                    switch (platformId.ToString("X"))
                    {
                        case "80000000":// PS3
                            PSNPlatform = "PS3";
                            break;
                        case "80800000":// PS3 Add On
                            PSNPlatform = "PS3 Addon";
                            break;
                        case "08000000": // psm assistant and soul sacrifice demo
                        case "88000000": // ps vita game
                        case "FE100000":
                            PSNPlatform = "PSVITA";
                            break;
                        case "F8100000": // psp game
                        case "F0100000": // demo
                            PSNPlatform = "PSP";
                            break;
                        default:
                            PSNPlatform = "UNKNOWN";
                            break;
                    }
                    PSNPlatform += " - " + platformId.ToString("X");
                    PSNIconURL = item.drm_def.image_url;

                }
                else if (item.entitlement_type == 5)  // PS4
                {
                    PSNContentId = item.product_id;
                    PSNContentTitle = item.game_meta.name;
                    IsPSPlusContent = (!String.IsNullOrEmpty(item.inactive_date));
                    PSNContentSize = (long)item.entitlement_attributes[0].package_file_size;
                    PSNPackageSize = item.entitlement_attributes[0].reference_package_url;
                    PSNPlatform = "PS4 - " + item.game_meta.type;
                    // if (item.game_meta.type == "PS4AL") PSNPlatform = "PS4 Addon";
                    PSNIconURL = item.game_meta.icon_url;
                }
                else
                {
                    continue;
                }
                
                string platform_name = Platforms[item.entitlement_type - 1];

                results.Add(new Models.OrbisPSNMediaInfo(PSNContentId, PSNContentTitle, PSNContentSize, PSNPackageSize, PSNPlatform, IsPSPlusContent, PSNIconURL));
            }

            return results;
        }
    }
}