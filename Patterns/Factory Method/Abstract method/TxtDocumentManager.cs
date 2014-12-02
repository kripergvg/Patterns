using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    class TxtDocumentManager : DocumentManager
    {
        private class TxtDocStorage : IDocStorage
        {
            public void Save(string name, Document document)
            {

            }
            public Document Load(string name)
            {
                return new Document();
            }
        }
        public override IDocStorage CreateStorage()
        {
            return new TxtDocStorage();
        }
    }
}
