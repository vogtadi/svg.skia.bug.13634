using Foundation;
using Lib_Common;
using System;
using UIKit;

namespace svg.skia.bug._13634
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var svgData = new byte[] { 0, 2, 3, 4, 5, 0 }; // NOT a real SVG Document
            MyConverter.SVGToPNG(svgData); // will crash with this input, but we are interested only in linker for this dummy project
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
