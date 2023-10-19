namespace Observer
{
    public class AverageObserver : Observer
    {
        private List<int> numbers = new List<int>();
        private int number = 0;

        public AverageObserver(Subject subject) : base(subject) { }

        public override void update()
        {
            this.numbers.Add(subject.getNumber());
            number = this.numbers.Sum() / this.numbers.Count;
            Console.WriteLine("Average number: " + number);
        }

        public override long getNumber()
        {
            return number;
        }
    }
}
