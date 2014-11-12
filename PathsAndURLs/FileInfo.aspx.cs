using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PathsAndURLs
{
    public partial class FileInfo : System.Web.UI.Page
    {
        protected string GetFileContent()
        {
            string path = "/Content/Colors.html";
            string file = Request.MapPath(path);
            return File.ReadAllText(file);
        }
    }
}