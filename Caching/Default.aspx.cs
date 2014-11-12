using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

namespace Caching
{
    public partial class Default : System.Web.UI.Page
    {
        private static readonly string CACHE_KEY = "codebehind_ts";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string GetTime()
        {
            string ts;
            STCacheObject<string> stObject = Cache[CACHE_KEY] as STCacheObject<string>;
            if (stObject == null)
            {
                ts = new STCacheObject<string>(CACHE_KEY, () => { return DateTime.Now.ToLongTimeString(); }).Data;
            }
            else
            {
                ts = stObject.Data + "<b>(Cached)</b>";
            }
            return ts;
        }

        //private string UpdateCache()
        //{
        //    string ts = DateTime.Now.ToLongTimeString();
        //    Cache.Insert(CACHE_KEY, ts, null, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(10),
        //            (string key, CacheItemUpdateReason reason, out object data, out CacheDependency dependency, out DateTime absoluteExpiry, out TimeSpan slidingExpiry) =>
        //            {
        //                data = dependency = null;
        //                slidingExpiry = Cache.NoSlidingExpiration;
        //                absoluteExpiry = Cache.NoAbsoluteExpiration;
        //                if (reason == CacheItemUpdateReason.Expired)
        //                {
        //                    data = DateTime.Now.ToLongTimeString();
        //                    slidingExpiry = TimeSpan.FromSeconds(10);
        //                    System.Diagnostics.Debug.WriteLine("Item {0} updated", key);
        //                }
        //            });
        //    return ts;
        //}
    }
}