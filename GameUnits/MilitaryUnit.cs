namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        private float _cost;
        
        public override int Health 
        {
            set
            {
                Health = base.Health + XP;
            }

            get
            {
                return Health;
            }
        }

        public override float Cost
        {
            get
            {
                return _cost = AttackPower + XP;
            }
        }

        public MilitaryUnit(int mov, int health, int attackPower)
        : base(mov, health)
        {                                                // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
    }
}
