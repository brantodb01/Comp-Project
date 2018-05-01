using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Create abstract Boss class
/// Create all Boss classes for each enemy type that can be encountered
/// </summary>
namespace Comp_Project_deluxe
{
    // creates the boss class
    public abstract class Boss
    {
        //creates the attributes all bosses need
        public uint health { get; set; }
        public uint meleeDamage { get; set; }
        public uint rangedDamage { get; set; }
        public uint accuracy { get; set; }
        //random attributes rolled for which attack type it does or it's accuracy for a turn
        Random attackType = new Random();
        Random hitC = new Random();
        

        //boss constructor
        public Boss()
        {
            health = 999;
            meleeDamage = 1;
            rangedDamage = 1;
            accuracy = 1;

        }
        //method for a bosses turn
        public bool myTurnHit()
        {
            int hitR = hitC.Next(1,100);
            if (hitR >= accuracy)
            {
                //returns missed
                return false;
            }
            else
            {
                //returns hit
                return true;
            }
        }
        //random attack type
        public int myTurnWeapon()
        {
            return attackType.Next(1, 3);

        }
    }
    //creates the Apple boss boss type
    class AppleBoss : Boss
    {
        //apple boss constructor so you can make boss have differant stats form on another
        public AppleBoss(uint health, uint meleeDamage, uint rangedDamage, uint accuracy)
        {
            this.health = health;
            this.meleeDamage = meleeDamage;
            this.rangedDamage = rangedDamage;
            this.accuracy = accuracy;

        }
    }
}

