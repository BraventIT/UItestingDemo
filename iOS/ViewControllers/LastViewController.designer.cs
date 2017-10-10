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
	[Register ("LastViewController")]
	partial class LastViewController
	{
		[Outlet]
		UIKit.UIButton btnBack { get; set; }

		[Outlet]
		UIKit.UILabel lblTItle { get; set; }

		[Outlet]
		UIKit.UITableView table { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (table != null) {
				table.Dispose ();
				table = null;
			}

			if (lblTItle != null) {
				lblTItle.Dispose ();
				lblTItle = null;
			}

			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}
		}
	}
}
