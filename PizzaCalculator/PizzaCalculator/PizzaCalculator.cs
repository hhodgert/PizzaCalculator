namespace PizzaCalculator
{
    public class PizzaCalculator
    {
        private readonly IPhoneDialer _phoneDialer;

        public PizzaCalculator(IPhoneDialer phoneDialer)
        {
            _phoneDialer = phoneDialer;
        }
        public string Calculate(string peopleString)
        {
            int people;
            if (int.TryParse(peopleString, out people))
            {
                var pizzas = people / 3;
                return $"Pizzas needed {pizzas}";
            }
            return "No people entered";
        }

        public void CallPizzaParlor()
        {
            _phoneDialer.Call("5035551212");
        }
    }
}
