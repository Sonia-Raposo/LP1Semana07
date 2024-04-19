using System.ComponentModel.Design.Serialization;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public string Move(int movement)
        {
            return $"{this.movement = movement}";
        }

    }
}
