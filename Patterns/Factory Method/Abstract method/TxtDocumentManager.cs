using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    class TxtDocumentManager : DocumentManager
    {
        private class TxtDocStorage : IDocStorage { }
        public override IDocStorage CreateStorage()
        {
            return new TxtDocStorage();
        }
    }
}
