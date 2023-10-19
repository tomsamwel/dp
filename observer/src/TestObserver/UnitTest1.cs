using NuGet.Frameworks;

namespace TestObserver
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AllOverserversGetCalled()
        {
            Subject subject = new Subject();
            AverageObserver observer1 = new AverageObserver(subject);
            TotalObserver observer2 = new TotalObserver(subject);

            long averageNumberBefore = observer1.getNumber();
            long totalNumberBefore = observer2.getNumber();

            Assert.AreEqual(0, averageNumberBefore);
            Assert.AreEqual(0, totalNumberBefore);

            subject.setNumber(100);
            averageNumberBefore = observer1.getNumber();
            totalNumberBefore = observer2.getNumber();

            subject.setNumber(50);

            Assert.AreNotEqual(averageNumberBefore, observer1.getNumber());
            Assert.AreNotEqual(totalNumberBefore, observer2.getNumber());
        }

        [TestCase(10, 12)]
        [TestCase(-10, 10)]
        [TestCase(-15, 2)]
        [TestCase(2, -25)]
        public void TestTotalObserver(int a, int b)
        {
            Subject subject = new Subject();

            TotalObserver observer = new TotalObserver(subject);

            subject.setNumber(a);
            subject.setNumber(b);

            long output = observer.getNumber();

            Assert.AreEqual(a+b, output);
        }

        [TestCase(120, 180, 10000)]
        [TestCase(2, -25, 81)]
        [TestCase(-24, -25, -26)]
        [TestCase(2, -25, 1000)]
        public void TestTotalObserverMoreNumbers(int a, int b, int c)
        {
            Subject subject = new Subject();
            TotalObserver observer = new TotalObserver(subject);

            subject.setNumber(a);
            subject.setNumber(b);
            subject.setNumber(c);

            long output = observer.getNumber();

            Assert.AreEqual(a+b+c, output);
        }

        [TestCase(10, 10)]
        [TestCase(-10, 10)]
        [TestCase(-15, 2)]
        [TestCase(2, -25)]
        public void TestAverageObserver(int a, int b)
        {
            Subject subject = new Subject();
            AverageObserver observer = new AverageObserver(subject);

            subject.setNumber(a);
            subject.setNumber(b);

            long output = observer.getNumber();

            Assert.AreEqual((a + b) / 2, output);
        }

        [TestCase(120, 180, 10000)]
        [TestCase(2, -25, 81)]
        [TestCase(-24, -25, -26)]
        [TestCase(2, -25, 1000)]
        public void TestAverageObserverMoreNumbers(int a, int b, int c)
        {
            Subject subject = new Subject();
            AverageObserver observer = new AverageObserver(subject);

            subject.setNumber(a);
            subject.setNumber(b);
            subject.setNumber(c);

            long output = observer.getNumber();

            Assert.AreEqual((a+b+c)/3, output);
        }
    }
}