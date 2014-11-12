using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Caching
{
    public class PageWrapper : Page
    {
        private IHttpHandler wrappedHandler;
        public PageWrapper(IHttpHandler handler)
        {
            wrappedHandler = handler;
        }

        public override void ProcessRequest(HttpContext context)
        {
            wrappedHandler.ProcessRequest(context);
        }
    }
}