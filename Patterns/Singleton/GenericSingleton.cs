using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Patterns.Singleton
{
    public class GenericSingleton<T> where T : class
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => (T)typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null).Invoke(null));
    }
}
