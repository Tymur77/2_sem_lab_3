using System;

using AppKit;
using Foundation;

namespace Stopwatch
{
    public partial class ViewController : NSViewController
    {
        private NSTimer timer;
        private byte hours = 0;
        private byte mins = 0;
        private byte sec = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void Start(NSObject sender)
        {
            timer = NSTimer.CreateScheduledTimer(1, true, _ =>
            {
                if (++sec >= 60)
                {
                    mins++;
                    sec = 0;
                }
                if (mins >= 60)
                {
                    hours++;
                    mins = 0;
                }
                HoursField.StringValue = $"{hours}".PadLeft(2, '0');
                MinutesField.StringValue = $"{mins}".PadLeft(2, '0');
                SecondsField.StringValue = $"{sec}".PadLeft(2, '0');
            });
        }

        partial void Reset(NSObject sender)
        {
            timer?.Invalidate();
            timer = null;
            hours = 0;
            HoursField.StringValue = "00";
            mins = 0;
            MinutesField.StringValue = "00";
            sec = 0;
            SecondsField.StringValue = "00";
        }

        partial void Pause(NSObject sender)
        {
            timer?.Invalidate();
            timer = null;
        }

    }
}
