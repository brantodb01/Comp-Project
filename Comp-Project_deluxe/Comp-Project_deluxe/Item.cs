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
        public uint value { get; set; }

        // protected means that only subclasses and this class can access it
        protected Item(uint value)
        {
            this.value = value;
        }
    }

    public abstract class Melee : Item
    {
        public decimal Maccuracy {get; set; }  
        public uint Mdamage { get; set; }

        public Melee(uint value, decimal accuracy, uint Mdamage) : base(value)
        {
            this.Mdamage = Mdamage;
            this.Maccuracy = Maccuracy;

        }
    }

    public abstract class Ranged : Item
    {
        public decimal Raccuracy { get; set; }
        public uint Rdamage { get; set; }

        public Ranged(uint value, decimal Raccuracy, uint damage) : base(value)
        {
            this.Raccuracy = Raccuracy;
            this.Rdamage = Rdamage;
        }

    }

    class Dagger : Melee
    {


        public Dagger(uint value, uint Mdamage, uint Maccuracy) : base(value, Maccuracy, Mdamage)
        {

        }

        public override string ToString()
        {
            return string.Format("Dagger [value={0}, damage={1}, accuracy={2}]", value, Mdamage,Maccuracy);
        }
    }

    class sling : Ranged
    {
        public sling(uint value, uint Rdamage, uint Raccuracy) : base(value, Raccuracy, Rdamage)
        {

        }
        public override string ToString()
        {
            return string.Format("Sling [value={0}, damage={1}, accuracy={2}]", value, Rdamage, Raccuracy);
        }
    }
}