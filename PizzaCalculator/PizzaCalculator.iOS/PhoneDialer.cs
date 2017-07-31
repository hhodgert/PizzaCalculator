using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace PizzaCalculator.iOS
{
    public class PhoneDialer : IPhoneDialer
    {
        private readonly UIViewController _viewController;

        public PhoneDialer(UIViewController viewController)
        {
            _viewController = viewController;
        }

        public void Call(string phoneNumber)
        {
            var url = new NSUrl($"tel:{phoneNumber}");

            if (!UIApplication.SharedApplication.OpenUrl(url))
            {
                var okAlertController = UIAlertController.Create("Not supported",
                    "Scheme 'tel:' is not supported on this device", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                _viewController.PresentViewController(okAlertController, true, null);
            }
        }
    }
}