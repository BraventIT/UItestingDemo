using System;

using UIKit;

namespace UItestCloudExample.iOS
{
    public partial class HomeViewController : UIViewController
    {
        bool pass;
        public HomeViewController() : base("HomeViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            btnEntrar.TintColor = UIColor.Black;
            this.View.BackgroundColor = UIColor.Blue;

            txfUser.AccessibilityIdentifier = "txfUser";
            txfPass.AccessibilityIdentifier = "txfPass";

            btnEntrar.TouchUpInside += delegate {
                if (txfPass.Text == "123")
                {
                    if (txfUser.Text == "123")
                    {
                        this.PresentViewController(new MidleViewController(), true, null);
                        pass = true;
                    }
                        
                }
                if (!pass)
                {
                    UIAlertView alert = new UIAlertView("Error", "Usuario o/y contraseña incorrecto", null, "OK", null);
                    alert.Show();
                }
            };
        }
    }
}

