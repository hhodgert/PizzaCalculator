using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PizzaCalculator.Droid
{
    [Activity(Label = "Pizza to Calc", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private PizzaCalculator _pizzaCalculator;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var peopleEntry = FindViewById<EditText>(Resource.Id.peopleEntry);
            var calculate = FindViewById<Button>(Resource.Id.calculateButton);
            var pizzaCount = FindViewById<TextView>(Resource.Id.pizzaCountLabel);
            var callParlor = FindViewById<Button>(Resource.Id.callPizzaParlorButton);
            
            _pizzaCalculator = new PizzaCalculator(new PhoneDialer(this));
            calculate.Click += (sender, args) =>
            {
                var message = _pizzaCalculator.Calculate(peopleEntry.Text);
                pizzaCount.Text = message;
            };
            callParlor.Click += (sender, args) =>
            {
                _pizzaCalculator.CallPizzaParlor();
            };
        }
    }
}

