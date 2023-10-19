using Singleton;
using NUnit.Framework;

namespace TestSingleton;

public class Tests
{
    [TestFixture]
    public class TestSingleton
    {
        [Test]
        public void TestInCorrectInstance()
        {
            var s1 = WashingMachineForSingleThread.GetInstance;
            var s2 = WashingMachineForSingleThread.GetInstance;
            
            Assert.AreSame(s1, s2);
        }
        
        [Test]
        public void TestInCorrectMultiThread()
        {
            WashingMachineForSingleThread s1;
            WashingMachineForSingleThread s2;

            string cook1 = new string("");
            string cook2 = new string("1");
            
            Parallel.Invoke(
                () =>
                {
                    s1 = WashingMachineForSingleThread.GetInstance; 
                    cook1 = s1.Message("");
                },
                () =>
                {
                    s2 = WashingMachineForSingleThread.GetInstance;
                    cook2 = s2.Message("");
                }
            );
            
            //This means there are 2 instances when the InCorrect Singleton in ran
            //This is not meant to happen but it is the result expected if we use this method for multi thread
            if (cook1[0] == '1' && cook2[0] == '1')
            {
                Assert.Pass();
            }
            if (cook1[0] == '1' && cook2[0] == '1')
            {
                Assert.Pass();
            }
            Assert.Fail();
            
        }

        [Test]
        public void TestCorrectInstance()
        {
            WashingMachineForMultiThread s1;
            WashingMachineForMultiThread s2;

            string cook1 = new string("1");
            string cook2 = new string("2");
            
            Parallel.Invoke(
                () =>
                {
                    s1 = WashingMachineForMultiThread.GetInstance; 
                    cook1 = s1.Message("cook");
                },
                () =>
                {
                    s2 = WashingMachineForMultiThread.GetInstance;
                    cook2 = s2.Message("cook");
                }
            );

            Assert.AreEqual(cook1, cook2);
        }
    }
}