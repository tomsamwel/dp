using Façade;

//Façade
Facade _facade = new Facade();

Console.WriteLine("Turn up TV volume:");
_facade.TurnVolumeTvUp();

MakeBreak();

Console.WriteLine("Switch the TV on and start vacuming");
_facade.SwitchTvPower();
_facade.StartVacuuming();

MakeBreak();

Console.WriteLine("Turn up TV volume by 30:");
int realisticVolume = 500;
for (int i = 0; i < 30; i++) { _facade.TurnVolumeTvUp(); Thread.Sleep(realisticVolume / (i > 0 ? i : 1)); }


MakeBreak();

Console.WriteLine("Thats too loud, turn it down by 5 and stop vacuming");
for (int i = 0; i < 5; i++) { _facade.TurnVolumeTvDown(); Thread.Sleep(realisticVolume / (i > 0 ? i : 1)); }

_facade.StopVacuuming();

MakeBreak();

Console.WriteLine("Play with speaker volume");
_facade.TurnVolumeSpeakerDown();
Thread.Sleep(realisticVolume / 2);
_facade.TurnVolumeSpeakerUp();
Thread.Sleep(realisticVolume / 3);
_facade.TurnVolumeSpeakerUp();
Thread.Sleep(realisticVolume / 4);
_facade.TurnVolumeSpeakerUp();
Thread.Sleep(realisticVolume / 5);
_facade.TurnVolumeSpeakerUp();

MakeBreak();

Console.WriteLine("Mom is home, turn everything down before she starts getting mad!");
_facade.TurnEverythingDown();

MakeBreak();

Console.WriteLine("Time to watch a movie, turn the speaker down, TV volume up by 20, dim the lights and make sure the vacuum cleaner is at its base");
_facade.MovieTime();

void MakeBreak()
{
    Console.WriteLine("======================");
    Console.ReadKey();
}
