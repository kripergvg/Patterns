using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public interface IGUIFactory
    {
        IWindow CreateWindow();
        IButton CreateButton();
        ITextBox CreateTextbox();
    }
    public interface IWindow { }
    public interface IButton { }
    public interface ITextBox { }
}
