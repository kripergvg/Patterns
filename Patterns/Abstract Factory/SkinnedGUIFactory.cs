using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class SkinnedGUIFactory : IGUIFactory
    {
        public IWindow CreateWindow() { return new SkinnedWindow(); }
        public IButton CreateButton() { return new SkinnedButton(); }
        public ITextBox CreateTextbox() { return new SkinnedTextBox(); }
    }
    public class SkinnedWindow : IWindow { }
    public class SkinnedButton : IButton { }
    public class SkinnedTextBox : ITextBox { }
}
