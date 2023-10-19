namespace Flyweight_Pattern_Example_Redcoats
{
    class NonFlyweightSoldier
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public string SquadColor { get; set; }
        public string Squad { get; set; }
        public int WeaponSkill { get; set; }
        public int BalasticSkill { get; set; }
        public int Movement { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public bool IsExhausted { get; set; }
        public string Rank { get; set; }

        public bool Shoot()
        {
            int result = ReturnDiceResult();
            if (result >= BalasticSkill)
            {
                return true;
            }
            return false;
        }

        public bool Hit()
        {
            int result = ReturnDiceResult();
            if (result >= WeaponSkill)
            {
                return true;
            }
            return false;
        }

        private int ReturnDiceResult()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
