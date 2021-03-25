using System;
using AppKit;
using Foundation;

namespace Calculator
{
    static class Extensions
    {
        // srgb iec61966-2.1
        public static NSColor Grey { get; private set; } = NSColor.FromRgb(107, 104, 104);
        public static NSColor LightGrey { get; private set; } = NSColor.FromRgb(131, 129, 129);
        public static NSColor DarkGrey { get; private set; } = NSColor.FromRgb(91, 89, 89);
        public static NSColor Yellow { get; private set; } = NSColor.FromRgb(255, 159, 33);

        public static NSColor GetDefaultBG()
        {
            return DarkGrey;
        }

        public static NSColor GetBGColor(this NSView view)
        {
            var colorRef = view.Layer?.BackgroundColor;
            if (colorRef != null)
            {
                return NSColor.FromCGColor(colorRef);
            }
            else
            {
                return null;
            }
        }

        public static void SetBGColor(this NSView view, NSColor newValue)
        {
            view.WantsLayer = true;
            if (view.Layer != null)
            {
                view.Layer.BackgroundColor = newValue.CGColor;
            }
        }

        public static void DarkBG(this NSViewController viewController)
        {
            viewController.View.SetBGColor(GetDefaultBG());
        }

        public static void SmartWindow(this NSWindowController windowController)
        {
            if (windowController.Window is NSWindow window)
            {
                window.StyleMask = NSWindowStyle.UnifiedTitleAndToolbar |
                    NSWindowStyle.FullSizeContentView |
                    NSWindowStyle.Titled;
                if (window.Toolbar != null)
                {
                    window.Toolbar.Visible = false;
                }
                window.TitleVisibility = NSWindowTitleVisibility.Hidden;
                window.TitlebarAppearsTransparent = true;
            }
        }

        public static void ActivateWindowDrag(this NSWindowController windowController)
        {
            if (windowController.Window != null)
            {
                windowController.Window.MovableByWindowBackground = true;
            }
        }

    }
}
