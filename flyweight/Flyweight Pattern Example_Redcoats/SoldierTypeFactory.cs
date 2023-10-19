using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern_Example_Redcoats
{
    public class SoldierTypeFactory
    {
        private List<SoldierType> _cache = new List<SoldierType>();

        public SoldierType GetSoldierType(string rank, int weaponSkill, int balisiticSkill)
        {
            SoldierType? searchResult = _cache.Where(x => x.WeaponSkill == weaponSkill && x.BalasticSkill == balisiticSkill && x.Rank == rank)
                .ToArray().FirstOrDefault();
            if (searchResult == null) 
            {
                SoldierType type = new SoldierType(rank, weaponSkill, balisiticSkill);
                _cache.Add(type);
                return type;
            }
            return searchResult;
        }
    }
}
