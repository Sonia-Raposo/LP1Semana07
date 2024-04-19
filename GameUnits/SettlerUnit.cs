namespace GameUnits
{
    /// <summary>
    /// Class that defines Settler Units that has legacy from class Unit
    /// </summary>
    public class SettlerUnit : Unit
    {
        private float _cost;
        
        /// <summary>
        /// An override for the property Health, setting the base at 3.
        /// </summary>
        public override int Health 
        {
            set
            {
                Health = 3;
            }

            get
            {
                return Health;
            }
        }

        /// <summary>
        /// An override for the property Cost, setting the base cost at 5.
        /// </summary>
        public override float Cost
        {
            get
            {
                return _cost = 5;
            }
        }

        public SettlerUnit(int mov, int health) : base(1, 3)
        {   
                                  
        }

    }
}
