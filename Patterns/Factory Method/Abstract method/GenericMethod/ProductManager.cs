using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Abstract_method.GenericMethod
{
    public class ProductManager
    {
        private IDocStorage _storage;

        public void SetStorage<T>() where T : IDocStorage, new()
        {
            this._storage = new T();
        }

        public bool Save(Document document)
        {
            if (false)
            {
                return false;
            }

            IDocStorage storage = this._storage;

            storage.Save("name", document);

            return true;
        }
    }
}
