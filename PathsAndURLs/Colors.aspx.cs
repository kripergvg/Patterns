using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace PathsAndURLs
{
    public partial class Colors : System.Web.UI.Page
    {
        public IEnumerable<string> GetColors()
        {
            return Request.GetFriendlyUrlSegments();
        }
    }
}