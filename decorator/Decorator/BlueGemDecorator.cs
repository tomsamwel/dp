namespace Decorator
{
    public class BlueGemDecorator : ArmorDecorator
    {
        public readonly int _addedProtection = 7;

        public BlueGemDecorator(IArmor armor) : base(armor) { }

        public override int ProtectMe(int damage)
        {
            Console.WriteLine($"\tThe purple gem protected a extra {_addedProtection} damage: {damage} - {_addedProtection} = {damage - _addedProtection}");

            return _armor.ProtectMe(damage - _addedProtection);
        }
    }
}
