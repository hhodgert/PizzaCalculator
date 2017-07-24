using System;

using UIKit;

namespace PizzaCalculator.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		    CalculateButton.TouchUpInside += (sender, args) =>
		    {
		        var message = PizzaCalculator.Calculate(PeopleEntry.Text);
		        PizzaCountLabel.Text = message;
		        PeopleEntry.ResignFirstResponder();
		    };
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}

