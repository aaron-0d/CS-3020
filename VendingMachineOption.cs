namespace FixedMidterm
{
    internal abstract class VendingMachineOption
    {
        public VendingMachineOption(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; }
        public float Price { get; }
        public int Quantity { get; }

        public string ToString()
        {
            return Name;
        }
    }
}