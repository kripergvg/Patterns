using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory_Method;
using Patterns.Factory_Method.Generics;
using Patterns.Factory_Method.Abstract_method.GenericMethod;
using Patterns.Singleton;
using Patterns.Abstract_Factory;

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

        public static string GetUserInput(IGUIFactory guiFactory)
        {
            IWindow wndInput = guiFactory.CreateWindow();
            IButton btnOk = guiFactory.CreateButton();
            ITextBox txtBx = guiFactory.CreateTextbox();
            return "";
        }
    }
}
