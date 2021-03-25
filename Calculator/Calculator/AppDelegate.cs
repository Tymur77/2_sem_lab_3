using AppKit;
using Foundation;
using System;

namespace Calculator
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            NSEvent.AddLocalMonitorForEventsMatchingMask(NSEventMask.KeyDown, (theEvent) =>
            {
                Console.WriteLine(theEvent);
                return theEvent;
            });
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
