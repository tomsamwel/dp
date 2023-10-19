namespace Flyweight_Pattern_Example_Redcoats
{
    public class SoldierType
    {
        public string Rank { get; set; }
        public int WeaponSkill { get; set; }
        public int BalasticSkill { get; set; }
        public int Movement { get; set; } = 6;
        public double Length { get; set; } = 180;
        public double Weight { get; set; } = 80;

        public SoldierType(string rank, int weaponsSkill, int balisticSkill)
        {
            this.Rank = rank;
            this.WeaponSkill = weaponsSkill;
            this.BalasticSkill = balisticSkill;
        }
    }
}

