namespace Observer
{
    public class TotalObserver : Observer
    {
        private long number = 0;

        public TotalObserver(Subject subject) : base(subject) { }

        public override void update()
        {
            number += subject.getNumber();
            Console.WriteLine("Total number: " + number);
        }

        public override long getNumber()
        {
            return number;
        }
    }
}
