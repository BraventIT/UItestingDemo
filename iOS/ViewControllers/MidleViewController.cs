using System;

using UIKit;

namespace UItestCloudExample.iOS
{
    public partial class MidleViewController : UIViewController
    {
        public MidleViewController() : base("MidleViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.DarkGray;
            btnIrTabla.TouchUpInside += delegate {
                this.PresentViewController(new LastViewController(),true,null);
            };
        }
    }
}

