using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Abstract_Factory
{
    public class GUIFactoryGeneric<TWindow, TButton, TTextBox> : IGUIFactory
        where TWindow : IWindow, new()
        where TButton : IButton, new()
        where TTextBox : ITextBox, new()
    {
        public IWindow CreateWindow() { return new TWindow(); }
        public IButton CreateButton() { return new TButton(); }
        public ITextBox CreateTextbox() { return new TTextBox(); }
    }

    public class DefaultGUIFactoryGeneric : GUIFactoryGeneric<DefaultWindow, DefaultButton, DefaultTextBox> { }

    public class SkinnedGUIFactoryGeneric : GUIFactoryGeneric<SkinnedWindow, SkinnedButton, SkinnedTextBox> { }
}
