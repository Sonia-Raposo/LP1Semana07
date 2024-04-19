using System.ComponentModel.Design.Serialization;
using System.Xml.XPath;

namespace GameUnits
{
    /// <summary>
    /// Class that defines Units.
    /// </summary>
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

        public override string ToString()
        {
            return 
            $"{GetType().Name}: Health: {Health},Cost: {Cost.ToString("F2")}";
        }
    }
}
