namespace FixedMidterm
{
    internal class NonElectronic : Toy
    {
        public NonElectronic(string name, float price, int quantity, int ageRequirement, bool chokingHazard) : base(
            name, price, quantity, ageRequirement)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            ChokingHazard = chokingHazard;
            AgeRequirement = ageRequirement;
        }

        public bool ChokingHazard { get; }

        public new string ToString()
        {
            return Name;
        }
    }
}