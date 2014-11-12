using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Caching;

namespace Caching
{
    public partial class CietiesControl : System.Web.UI.UserControl
    {
        private static readonly string fileName = "/CitiesList.html";
        private static readonly string HTML_CACHE_KEY = "cities_html";
        private static readonly string TIME_CACHE_KEY = "cities_time";
        private bool cached = false;

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    cityInfo = Cache[CACHE_KEY] as CityListInfo;
        //    if (cityInfo == null)
        //    {
        //        cityInfo = new CityListInfo
        //        {
        //            Timestamp = DateTime.Now.ToLongTimeString(),
        //            Html = File.ReadAllText(MapPath(fileName))
        //        };
        //        Cache.Insert(CACHE_KEY, cityInfo, new CacheDependency(MapPath(fileName)));
        //    }
        //    else
        //    {
        //        cached = true;
        //    }
        //}

        public string GetCities()
        {
            string html = (string)Cache[HTML_CACHE_KEY];
            if (html == null)
            {
                AggregateCacheDependency aggDep = new AggregateCacheDependency();
                aggDep.Add(new CacheDependency(MapPath(fileName)));
                aggDep.Add(new RequestCountDependency(3));
                html = File.ReadAllText(MapPath(fileName));
                Cache.Insert(HTML_CACHE_KEY, html, aggDep
                    //new CacheDependency(MapPath(fileName))
                    );
            }
            else
            {
                cached = true;
            }
            return html;
        }

        public string GetTimeStamp()
        {
            string timeStamp = (string)Cache[TIME_CACHE_KEY];
            if(timeStamp==null)
            {
                timeStamp = DateTime.Now.ToLongTimeString();
                Cache.Insert(TIME_CACHE_KEY, timeStamp, new CacheDependency(null, new string[] { HTML_CACHE_KEY }));
            }
            return timeStamp + (cached ? "<b>Cached</b>" : "");
        }


    }
}