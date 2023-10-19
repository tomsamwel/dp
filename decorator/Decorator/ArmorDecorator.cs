namespace Decorator
{
    public abstract class ArmorDecorator : IArmor
    {
        protected readonly IArmor _armor;

        public ArmorDecorator(IArmor armor)
        {
            _armor = armor;
        }

        public abstract int ProtectMe(int damage);
    }
}
