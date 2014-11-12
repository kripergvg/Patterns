using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Caching
{
    public partial class CitiesForm : System.Web.UI.Page
    {
        private static readonly string filename = "/CitiesList.html";
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AddFileDependency(MapPath(filename));
        }

        protected string GetCities()
        {
            return File.ReadAllText(MapPath(filename));
        }
    }
}