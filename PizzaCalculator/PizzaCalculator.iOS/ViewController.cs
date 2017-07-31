using System;

using UIKit;

namespace PizzaCalculator.iOS
{
	public partial class ViewController : UIViewController
	{
	    private readonly PizzaCalculator _pizzaCalculator;

	    public ViewController (IntPtr handle) : base (handle)
		{
            _pizzaCalculator = new PizzaCalculator(new PhoneDialer(this));
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		    CalculateButton.TouchUpInside += (sender, args) =>
		    {
		        var message = _pizzaCalculator.Calculate(PeopleEntry.Text);
		        PizzaCountLabel.Text = message;
		        PeopleEntry.ResignFirstResponder();
            };
		    CallPizzaParlorButton.TouchUpInside += (sender, args) =>
		    {
		        _pizzaCalculator.CallPizzaParlor();
		    };
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}

