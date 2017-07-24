using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PizzaCalculator.Droid
{
	[Activity (Label = "PizzaCalculator.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

		    var peopleEntry = FindViewById<EditText>(Resource.Id.peopleEntry);
		    var calculate = FindViewById<Button>(Resource.Id.calculateButton);
		    var pizzaCount = FindViewById<TextView>(Resource.Id.pizzaCountLabel);

            calculate.Click += (sender, args) =>
            {
                var message = PizzaCalculator.Calculate(peopleEntry.Text);
                pizzaCount.Text = message;
            };
		}
	}
}


