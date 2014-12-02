using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class DefaultGUIFactory:IGUIFactory
    {
        public IWindow CreateWindow() { return new DefaultWindow(); }
        public IButton CreateButton() { return new DefaultButton(); }
        public ITextBox CreateTextbox() { return new DefaultTextBox(); }
    }
    public class DefaultWindow : IWindow { }
    public class DefaultButton : IButton { }
    public class DefaultTextBox : ITextBox { }
}
