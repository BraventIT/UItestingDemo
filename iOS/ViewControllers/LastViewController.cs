using System;
using Foundation;
using UIKit;

namespace UItestCloudExample.iOS
{
    public partial class LastViewController : UIViewController
    {
        public LastViewController() : base("LastViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Purple;
            table.DataSource = new TestDataSource();


            btnBack.TouchUpInside += delegate {
                this.DismissViewController(true,null);
            };
        }
    }

    internal class TestDataSource : UITableViewDataSource
    {
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell();

            cell.TextLabel.Text = indexPath.Row.ToString();
            cell.AccessibilityIdentifier = indexPath.Row.ToString();
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 30;
        }
    }
}

