namespace Decorator
{
    public class RedGemDecorator : ArmorDecorator
    {
        public readonly int _addedProtection = 8;

        public RedGemDecorator(IArmor armor) : base(armor) { }

        public override int ProtectMe(int damage)
        {
            Console.WriteLine($"\tThe purple gem protected a extra {_addedProtection} damage: {damage} - {_addedProtection} = {damage - _addedProtection}");

            return _armor.ProtectMe(damage - _addedProtection);
        }
    }
}
