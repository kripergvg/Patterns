using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Generics
{
    public class DocumentManagerGeneric<T> : DocumentManager where T : IDocStorage, new()
    {
        public override IDocStorage CreateStorage()
        {
            IDocStorage storage = new T();
            return storage;
        }
    }
}
