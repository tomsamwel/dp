namespace Flyweight_Pattern_Example_Redcoats
{
    public class Soldier
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public string SquadColor { get; set; }
        public string Squad { get; set; }
        public bool IsExhausted { get; set; }
        public SoldierType SoldierType { get; set; }

        public bool Shoot()
        {
            int result = ReturnRandomResult();
            if (result >= SoldierType.BalasticSkill)
            {
                return true;
            }
            return false;
        }

        public bool Hit()
        {
            int result = ReturnRandomResult();
            if (result >= SoldierType.WeaponSkill)
            {
                return true;
            }
            return false;
        }

        private int ReturnRandomResult()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}

