using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace PathsAndURLs
{
    public class PathModule : IHttpModule
    {
        private static readonly string[] extensions = { ".aspx", "ashx" };

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) => HandlerRequest(app);
        }

        private void HandlerRequest(HttpApplication app)
        {
            if (app.Request.CurrentExecutionFilePathExtension == string.Empty)
            {
                string target = null;
                string vpath = app.Request.CurrentExecutionFilePath;
                if (vpath == "/")
                {
                    target = "/Default.aspx";
                }
                else
                {
                    foreach (string ext in extensions)
                    {
                        if (File.Exists(app.Request.MapPath(vpath + ext)))
                        {
                            target = vpath + ext;
                            break;
                        }
                    }
                }
                if (target != null)
                {
                    app.Context.RewritePath(target);
                }
            }
        }

        public void Dispose()
        {

        }
    }
}