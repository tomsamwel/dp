namespace Observer
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*Subject subject = new Subject();

            new TotalObserver(subject);
            new AverageObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.setNumber(15);
            Console.WriteLine("Second state change: 10");
            subject.setNumber(10);*/

            Subject subject = new Subject();

            new TotalObserver(subject);

            subject.setNumber(15);
            subject.setNumber(15);

            string output = Console.ReadLine();
            string outputNum = output.Substring(output.Length - 2);
            Console.WriteLine(outputNum);
        }
    }
}
