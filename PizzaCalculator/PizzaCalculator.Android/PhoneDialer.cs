using Android.Content;

namespace PizzaCalculator.Droid
{
    public class PhoneDialer : IPhoneDialer
    {
        private readonly Context _context;

        public PhoneDialer(Context context)
        {
            _context = context;
        }
        public void Call(string phoneNumber)
        {
            var uri = Android.Net.Uri.Parse($"tel:{phoneNumber}");
            var intent = new Intent(Intent.ActionDial, uri);
            _context.StartActivity(intent);
        }
    }
}