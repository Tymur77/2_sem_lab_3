// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ResultsField { get; set; }

		[Action ("_0:")]
		partial void _0 (Foundation.NSObject sender);

		[Action ("_1:")]
		partial void _1 (Foundation.NSObject sender);

		[Action ("_2:")]
		partial void _2 (Foundation.NSObject sender);

		[Action ("_3:")]
		partial void _3 (Foundation.NSObject sender);

		[Action ("_4:")]
		partial void _4 (Foundation.NSObject sender);

		[Action ("_5:")]
		partial void _5 (Foundation.NSObject sender);

		[Action ("_6:")]
		partial void _6 (Foundation.NSObject sender);

		[Action ("_7:")]
		partial void _7 (Foundation.NSObject sender);

		[Action ("_8:")]
		partial void _8 (Foundation.NSObject sender);

		[Action ("_9:")]
		partial void _9 (Foundation.NSObject sender);

		[Action ("clear:")]
		partial void clear (Foundation.NSObject sender);

		[Action ("coma:")]
		partial void coma (Foundation.NSObject sender);

		[Action ("divide:")]
		partial void divide (Foundation.NSObject sender);

		[Action ("equals:")]
		partial void equals (Foundation.NSObject sender);

		[Action ("minus:")]
		partial void minus (Foundation.NSObject sender);

		[Action ("multiply:")]
		partial void multiply (Foundation.NSObject sender);

		[Action ("plus:")]
		partial void plus (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ResultsField != null) {
				ResultsField.Dispose ();
				ResultsField = null;
			}
		}
	}
}
