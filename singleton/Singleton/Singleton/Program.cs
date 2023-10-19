using Singleton;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

static void RunWashingMachine1InCorrect()
{
    var Washer1 = WashingMachineForSingleThread.GetInstance;
    RunWasher(Washer1);
}

static void RunWashingMachine2InCorrect()
{
    var Washer2 = WashingMachineForSingleThread.GetInstance;
    RunWasher(Washer2);
}

static void RunWashingMachine3Correct()
{
    var Washer3 = WashingMachineForMultiThread.GetInstance;
    RunWasher(Washer3);
}

static void RunWashingMachine4Correct()
{
    var Washer4 = WashingMachineForMultiThread.GetInstance;
    RunWasher(Washer4);
}

static void RunWashingMachineEnum()
{
    var Washer = WashingMachineEnum.INSTANCE;
    Washer.PrintInstanceNumber();
    Washer.Fill();
    Washer.Wash();
    Washer.Drain();
}

static void RunWasher(IWashingMachine Washer)
{
    Washer.PrintInstanceNumber();
    Washer.Fill();
    Washer.Wash();
    Washer.Drain();
}

static void RunExample1()
{
    Parallel.Invoke(
        () => RunWashingMachine1InCorrect(),
        () => RunWashingMachine2InCorrect()
        );
    Console.ReadLine();
}

static void RunExample2()
{
    Parallel.Invoke(
        () => RunWashingMachine3Correct(),
        () => RunWashingMachine4Correct()
        );
    Console.ReadLine();

}

static void RunExample3()
{
    Parallel.Invoke(
        () => RunWashingMachineEnum(),
        () => RunWashingMachineEnum()
        );
    Console.ReadLine();
}

static void RunExample4()
{
    RunWashingMachine1InCorrect();
    Console.WriteLine("");
    RunWashingMachine2InCorrect();
    Console.ReadLine();
}

void ClearMemory()
{
    GC.Collect();
    GC.WaitForPendingFinalizers();
}

ClearMemory();
RunExample1();
RunExample2();
RunExample3();
RunExample4();
