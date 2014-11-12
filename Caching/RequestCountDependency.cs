using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{
    public class RequestEventMapModule : IHttpModule
    {
        public event EventHandler BeginRequest;

        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) =>
                {
                    if (BeginRequest != null)
                        BeginRequest(this, EventArgs.Empty);
                };
        }

        public void Dispose()
        {

        }
    }

    public class RequestCountDependency : CacheDependency
    {
        private int requestLimit, requestCount;

        public RequestCountDependency(int limit)
        {
            requestLimit = limit;
            requestCount = 0;
            configreEventHandler(true);
            FinishInit();
        }

        private void configreEventHandler(bool attach)
        {
            if (HttpContext.Current != null)
            {
                RequestEventMapModule module = HttpContext.Current.ApplicationInstance.Modules["RequestEventMap"] as RequestEventMapModule;
                if (module != null)
                {
                    if (attach)
                    {
                        module.BeginRequest += module_BeginRequest;
                    }
                    else
                    {
                        module.BeginRequest -= module_BeginRequest;
                    }
                }
            }
        }

        void module_BeginRequest(object sender, EventArgs e)
        {
            if (++requestCount > requestLimit)
            {
                NotifyDependencyChanged(this, EventArgs.Empty);
            }
        }

        protected override void DependencyDispose()
        {
            configreEventHandler(false);
            base.DependencyDispose();
        }
    }


}