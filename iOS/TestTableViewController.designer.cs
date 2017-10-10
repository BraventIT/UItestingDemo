// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace UItestCloudExample.iOS
{
    [Register ("TestTableViewController")]
    partial class TestTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGoBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblData { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnGoBack != null) {
                btnGoBack.Dispose ();
                btnGoBack = null;
            }

            if (lblTitle != null) {
                lblTitle.Dispose ();
                lblTitle = null;
            }

            if (tblData != null) {
                tblData.Dispose ();
                tblData = null;
            }
        }
    }
}