namespace FixedMidterm
{
    internal class Food : Consumable
    {
        public Food(string name, float price, int quantity, int calorieCount, float consistency, int scovilleScale,
            bool isVegetarian) : base(name, price, quantity, calorieCount, isVegetarian)
        {
            Consistency = consistency;
            ScovilleScale = scovilleScale;
            CalorieCount = calorieCount;
            IsVegetarian = isVegetarian;
        }

        public float Consistency { get; }
        public int ScovilleScale { get; }

        public string ToString()
        {
            return Name;
        }
    }
}