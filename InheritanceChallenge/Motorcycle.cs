namespace InheritanceChallenge
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model) : base(make, model)
        {

        }

        public int NumOfGears { get; set; } = 4;
        public int NumOfTires { get; set; } = 2;

        public override string ToString()
        {
            return $"This is a {Make} {Model}";
        }
    }
}