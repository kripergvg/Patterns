using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    public abstract class DocumentManager
    {
        public abstract IDocStorage CreateStorage();

        public bool Save(Document document)
        {
            if (false)
            {
                return false;
            }

            IDocStorage storage = this.CreateStorage();

            storage.Save("name", document);

            return true;
        }
    }
}
