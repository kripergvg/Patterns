using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace Routing.Store
{
    public partial class Cart : System.Web.UI.Page
    {
        protected string GetURLFromRoute()
        {
            //RouteValueDictionary o = new RouteValueDictionary { };
            //o.Add({});
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null)
            {
                return myRoute.Url;
            }
            return "Unkow";
        }
    }
}