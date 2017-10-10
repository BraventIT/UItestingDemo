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
	[Register ("MidleViewController")]
	partial class MidleViewController
	{
		[Outlet]
		UIKit.UIButton btnIrTabla { get; set; }

		[Outlet]
		UIKit.UILabel lbliPhone { get; set; }

		[Outlet]
		UIKit.UILabel lblTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblTitle != null) {
				lblTitle.Dispose ();
				lblTitle = null;
			}

			if (lbliPhone != null) {
				lbliPhone.Dispose ();
				lbliPhone = null;
			}

			if (btnIrTabla != null) {
				btnIrTabla.Dispose ();
				btnIrTabla = null;
			}
		}
	}
}
