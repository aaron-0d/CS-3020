namespace FixedMidterm
{
    internal abstract class Toy : VendingMachineOption
    {
        public Toy(string name, float price, int quantity, int ageRequirement) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            AgeRequirement = ageRequirement;
        }

        public int AgeRequirement { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public string ToString()
        {
            return Name;
        }
    }
}