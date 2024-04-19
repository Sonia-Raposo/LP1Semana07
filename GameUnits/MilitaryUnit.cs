namespace GameUnits
{
    /// <summary>
    /// Class that defines Military Units that has legacy from class Unit
    /// </summary>
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        private float _cost;
        
        /// <summary>
        /// An override for the property Health, setting the base health + XP.
        /// </summary>
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

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower} XP={XP}";
        }
    }
}
