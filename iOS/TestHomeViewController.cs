using Foundation;
using System;
using UIKit;

namespace UItestCloudExample.iOS
{
    public partial class TestHomeViewController : UIViewController
    {
        public TestHomeViewController()
        { 
            var storyboard = UIStoryboard.FromName ("Main", null);
            var controller = storyboard.InstantiateViewController("TestHome");

            this.ShowViewController(controller,null);
        }

        public TestHomeViewController (IntPtr handle) : base (handle)
        {
            var storyboard = UIStoryboard.FromName("Main", null);
            var controller = storyboard.InstantiateViewController("TestHome");

            this.ShowViewController(controller, null);
        }
    }
}