namespace Decorator
{
    public class Armor : IArmor
    {
        private readonly int _addedProtection = 10;

        public int ProtectMe(int damage)
        {
            Console.WriteLine($"\tThe purple gem protected a extra {_addedProtection} damage: {damage} - {_addedProtection} = {damage - _addedProtection}");

            return damage - _addedProtection;
        }
    }
}
