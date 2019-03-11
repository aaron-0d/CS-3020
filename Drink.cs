namespace FixedMidterm
{
    internal class Drink : Consumable
    {
        public Drink(string name, float price, int quantity, int calorieCount, int sizeInOunces, bool isVegetarian) :
            base(name, price, quantity, calorieCount, isVegetarian)
        {
            SizeInOunces = sizeInOunces;
            CalorieCount = calorieCount;
            IsVegetarian = isVegetarian;
        }

        private int SizeInOunces { get; }

        public string ToString()
        {
            return Name;
        }
    }
}