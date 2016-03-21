namespace InheritanceChallenge
{
    public class Trike : Motorcycle
    {
        public Trike(string make, string model) : base(make, model)
        {

        }

        public int NumOfGears { get; set; } = 4;
        public int NumOfTires { get; set; } = 3;

    }
}