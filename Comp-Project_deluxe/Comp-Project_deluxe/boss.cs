using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Project_deluxe
{
    public abstract class Boss
    {
        public uint health { get; set; }
        public uint meleeDamage { get; set; }
        public uint rangedDamage { get; set; }
        public uint accuracy { get; set; }
        Random attackType = new Random();
        Random hitC = new Random();
        


        public Boss()
        {
            health = 999;
            meleeDamage = 1;
            rangedDamage = 1;
            accuracy = 1;

        }

        public bool myTurnHit()
        {
            int hitR = hitC.Next(1,100);
            if (hitR >= accuracy)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int myTurnWeapon()
        {
            return attackType.Next(1, 3);

        }
    }

    class AppleBoss : Boss
    {

        public AppleBoss(uint health, uint meleeDamage, uint rangedDamage, uint accuracy)
        {
            this.health = health;
            this.meleeDamage = meleeDamage;
            this.rangedDamage = rangedDamage;
            this.accuracy = accuracy;

        }
    }
}

