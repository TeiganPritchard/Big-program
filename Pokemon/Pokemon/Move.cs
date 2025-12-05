using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokemon
{
    
    public class Move
    {
        public static Random random = new Random();
        public static int CastSpell(int Atk)
        {
            int damage = Atk * 3;
            return damage;
        }

        public static int Shield(int Def)
        {
            int Defense = Def * 2;
            return Defense;
        }
        public static int NormalAttack(int Atk)
        {
            int damage = Atk * 2;
            return damage;
        }

        public static int HeavyAttack(int Atk)
        {
            //chance to miss
            if (random.Next(2) == 0)
            {
                int damage = Atk * 5;
                return damage;
            }
            return 0;
        }

        public static int HeavyShield(int Def)
        {
            //chance to miss
            if (random.Next(2) == 0)
            {
                int defense = Def * 5;
                return defense;
            }
            return 0;
        }

        //public static int heal(int HP)
        //{

        //}


    }
}
