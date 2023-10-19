namespace Flyweight_Pattern_Example_Redcoats
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<NonFlyweightSoldier>> NFPlatoon = new List<List<NonFlyweightSoldier>>();
            List<List<Soldier>> Platoon = new List<List<Soldier>>();


            var NFStorageSnapshot = GC.GetTotalMemory(true);
            for (int i = 0; i < 1000; i++)
            {
                NFPlatoon.Add(GenerateNFWSquad(i.ToString(), "black"));
            }
            Console.WriteLine($"Amount of Gigabytes Being Used without flyweight for 1 million {(GC.GetTotalMemory(true) - NFStorageSnapshot) * 1000 / Math.Pow(10, 9)}GB");

            var StorageSnapshot = GC.GetTotalMemory(true);
            for (int i = 0; i < 1000; i++)
            {
                Platoon.Add(GenerateSquad(i.ToString(), "black"));
            }
            Console.WriteLine($"Amount of Gigabytes Being Used with flyweight for 1 million  = {(GC.GetTotalMemory(true) - StorageSnapshot) * 1000 / Math.Pow(10, 9)}GB");
        }

        public static List<Soldier> GenerateSquad(string squadName, string squadColor)
        {
            List<Soldier> squad = new List<Soldier>();
            SoldierTypeFactory factory = new SoldierTypeFactory();

            for (int i = 0; i < 10; i++)
            {
                squad.Add(new Soldier() { Hitpoints = 3, Squad = "1", SquadColor = "black", SoldierType = factory.GetSoldierType("Private", 4, 4) });
            }
            squad.Add(new Soldier() { Hitpoints = 4, Squad = squadName, SquadColor = squadColor, SoldierType = factory.GetSoldierType("Sergeant", 3, 4) });
            squad.Add(new Soldier() { Hitpoints = 5, Squad = squadName, SquadColor = squadColor, SoldierType = factory.GetSoldierType("Captain", 3, 3) });
            return squad;
        }



        public static List<NonFlyweightSoldier> GenerateNFWSquad(string squadName, string squadColor)
        {
            List<NonFlyweightSoldier> squad = new List<NonFlyweightSoldier>();
            for (int i = 0; i < 10; i++)
            {
                squad.Add(new NonFlyweightSoldier()
                {
                    Rank = "Private",
                    Weight = 75,
                    Length = 170,
                    Movement = 6,
                    BalasticSkill = 4,
                    WeaponSkill = 5,
                    Hitpoints = 3,
                    Squad = squadName,
                    SquadColor = squadColor
                });
            }
            squad.Add(new NonFlyweightSoldier()
            {
                Rank = "Sergeant",
                Weight = 90,
                Length = 180,
                Movement = 6,
                BalasticSkill = 3,
                WeaponSkill = 4,
                Hitpoints = 4,
                Squad = squadName,
                SquadColor = squadColor
            });
            squad.Add(new NonFlyweightSoldier()
            {
                Rank = "Captain",
                Weight = 100,
                Length = 180,
                Movement = 6,
                BalasticSkill = 3,
                WeaponSkill = 3,
                Hitpoints = 5,
                Squad = squadName,
                SquadColor = squadColor
            });
            return squad;
        }

    }
}
