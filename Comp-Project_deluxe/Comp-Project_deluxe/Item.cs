using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Used to make items
/// 
/// </summary>

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
    //makes the Melee class

    public abstract class Melee : Item
    {
        public decimal Maccuracy {get; set; }  //establishes accuracy
        public uint Mdamage { get; set; } //establishes Damage

        public Melee(uint value, decimal accuracy, uint Mdamage) : base(value) // Melee constructor
        {
            this.Mdamage = Mdamage;
            this.Maccuracy = Maccuracy;

        }
    }
    //Makes the ranged class

    public abstract class Ranged : Item
    {
        public decimal Raccuracy { get; set; }//establishes accuracy
        public uint Rdamage { get; set; }//establishes Damage

        public Ranged(uint value, decimal Raccuracy, uint damage) : base(value) //Ranged constructor
        {
            this.Raccuracy = Raccuracy;
            this.Rdamage = Rdamage;
        }

    }
    //makes the Dagger class

    class Dagger : Melee
    {


        public Dagger(uint value, uint Mdamage, uint Maccuracy) : base(value, Maccuracy, Mdamage)
        {

        }

        public override string ToString() // changes the string assigned the dagger so it displays stats
        {
            return string.Format("Dagger [value={0}, damage={1}, accuracy={2}]", value, Mdamage,Maccuracy);
        }
    }
    //makes the sling class

    class sling : Ranged
    {
        public sling(uint value, uint Rdamage, uint Raccuracy) : base(value, Raccuracy, Rdamage)
        {

        }
        public override string ToString()// changes the string assigned to sling so it displays stats
        {
            return string.Format("Sling [value={0}, damage={1}, accuracy={2}]", value, Rdamage, Raccuracy);
        }
    }
}