// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Stopwatch
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField HoursField { get; set; }

		[Outlet]
		AppKit.NSTextField MinutesField { get; set; }

		[Outlet]
		AppKit.NSTextField SecondsField { get; set; }

		[Action ("Pause:")]
		partial void Pause (Foundation.NSObject sender);

		[Action ("Reset:")]
		partial void Reset (Foundation.NSObject sender);

		[Action ("Start:")]
		partial void Start (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (HoursField != null) {
				HoursField.Dispose ();
				HoursField = null;
			}

			if (MinutesField != null) {
				MinutesField.Dispose ();
				MinutesField = null;
			}

			if (SecondsField != null) {
				SecondsField.Dispose ();
				SecondsField = null;
			}
		}
	}
}
