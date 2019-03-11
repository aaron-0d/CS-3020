namespace FixedMidterm
{
    public enum Genre
    {
        Action,
        Shooter,
        Puzzle,
        Story
    }

    internal class Electronic : Toy
    {
        public Electronic(string name, float price, int quantity, int ageRequirement, bool batteriesIncluded,
            Genre genre) : base(name, price, quantity, ageRequirement)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            BatteriesIncluded = batteriesIncluded;
            Genre = genre;
            AgeRequirement = ageRequirement;
        }

        public bool BatteriesIncluded { get; }
        public Genre Genre { get; }

        public string ToString()
        {
            return Name;
        }
    }
}