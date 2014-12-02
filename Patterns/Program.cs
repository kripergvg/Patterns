using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory_Method;
using Patterns.Factory_Method.Generics;
using Patterns.Factory_Method.Abstract_method.GenericMethod;
using Patterns.Singleton;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentManager docManager = new TxtDocumentManager();
            docManager.Save(new Document());

            DocumentManager genericDocManager = new DocumentManagerGeneric<TxtStorage>();
            genericDocManager.Save(new Document());

            ProductManager productManager = new ProductManager();
            productManager.SetStorage<TxtStorage>();
            productManager.Save(new Document());

            Singleton.Singleton singleton = Singleton.Singleton.Instance;

            LazySingleton lazySingleton = LazySingleton.Instance;
        }
    }
}
