using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    public sealed class Singleton
    {
        private Singleton() { }
        public static Singleton Instance { get { return InstanceHolder._instance; } }

        protected class InstanceHolder
        {
            static InstanceHolder() { }

            internal static readonly Singleton _instance = new Singleton();
        }
    }
}
