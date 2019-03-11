namespace FixedMidterm
{
    internal abstract class Consumable : VendingMachineOption
    {
        protected Consumable(string name, float price, int quantity, int calorieCount, bool isVegetarian) : base(name,
            price, quantity)
        {
            CalorieCount = calorieCount;
            IsVegetarian = isVegetarian;
        }

        public int CalorieCount { get; set; }
        protected bool IsVegetarian { get; set; }

        public string ToString()
        {
            return Name;
        }
    }
}