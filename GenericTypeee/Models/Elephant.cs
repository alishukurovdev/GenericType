

namespace GenericTypeee.Models
{
    public class Elephant:Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }

        public override void Hunt<T>(T animal)
        {
            throw new NotImplementedException();
        }
    }
}
