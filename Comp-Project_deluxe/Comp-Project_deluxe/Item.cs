using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    // abstract means that we cannot instansiate a new 'Item' - only one of its subclasses
    public abstract class Item
    {
        public uint value { get; }

        // protected means that only subclasses and this class can access it
        protected Item(uint value)
        {
            this.value = value;
        }
    }

    class Dagger : Item
    {
        public uint damage { get; }

        public Dagger(uint damage) : base(12)
        {
            this.damage = damage;
        }

        public override string ToString()
        {
            return string.Format("Dagger [value={0}, damage={1}]", value, damage);
        }
    }
}