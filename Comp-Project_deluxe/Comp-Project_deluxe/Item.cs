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
        public decimal Maccuarcy { get; set; }  
        public uint Mdamage { get; set; }

        public Melee(uint value, decimal accuracy, uint Mdamage) : base(value)
        {
            this.Mdamage = Mdamage;
            this.Maccuarcy = Maccuarcy;

        }
    }

    class Dagger : Melee
    {
        uint accuracy;
        uint damage;

        public Dagger(uint value, uint Mdamage, uint Maccuracy) : base(value, Game.player.rangedD, Game.player.meleeD)
        {
            damage = Mdamage;
            accuracy = Maccuracy;
        }

        public override string ToString()
        {
            return string.Format("Dagger [value={0}, damage={1}, accuracy={2}]", value, damage,accuracy);
        }
    }
}