using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    public interface IDocStorage
    {
        void Save(string name,Document document);
        Document Load(string name);
    }
}
