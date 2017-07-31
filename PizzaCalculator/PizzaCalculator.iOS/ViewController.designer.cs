// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PizzaCalculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CallPizzaParlorButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PeopleEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PizzaCountLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CalculateButton != null) {
                CalculateButton.Dispose ();
                CalculateButton = null;
            }

            if (CallPizzaParlorButton != null) {
                CallPizzaParlorButton.Dispose ();
                CallPizzaParlorButton = null;
            }

            if (PeopleEntry != null) {
                PeopleEntry.Dispose ();
                PeopleEntry = null;
            }

            if (PizzaCountLabel != null) {
                PizzaCountLabel.Dispose ();
                PizzaCountLabel = null;
            }
        }
    }
}