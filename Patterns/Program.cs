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
using Patterns.CompositePattern;

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


            #region Composite

            Composite root = new Composite("root");

            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");

            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);

            // Wait for user
            Console.Read();
            #endregion


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
