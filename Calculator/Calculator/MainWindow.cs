// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;

namespace Calculator
{
	public partial class MainWindow : NSWindowController
	{
        private NSViewController viewController;

		public MainWindow (IntPtr handle) : base (handle)
		{
		}

        public override void WindowDidLoad()
        {
            base.WindowDidLoad();

            this.ActivateWindowDrag();

            viewController = this.ContentViewController;

        }

    }
}
