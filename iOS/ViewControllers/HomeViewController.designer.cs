// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace UItestCloudExample.iOS
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		UIKit.UIButton btnEntrar { get; set; }

		[Outlet]
		UIKit.UILabel lblPass { get; set; }

		[Outlet]
		UIKit.UILabel lblTItle { get; set; }

		[Outlet]
		UIKit.UILabel lblUser { get; set; }

		[Outlet]
		UIKit.UITextField txfPass { get; set; }

		[Outlet]
		UIKit.UITextField txfUser { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTItle != null) {
				lblTItle.Dispose ();
				lblTItle = null;
			}

			if (lblUser != null) {
				lblUser.Dispose ();
				lblUser = null;
			}

			if (lblPass != null) {
				lblPass.Dispose ();
				lblPass = null;
			}

			if (txfUser != null) {
				txfUser.Dispose ();
				txfUser = null;
			}

			if (txfPass != null) {
				txfPass.Dispose ();
				txfPass = null;
			}

			if (btnEntrar != null) {
				btnEntrar.Dispose ();
				btnEntrar = null;
			}
		}
	}
}
