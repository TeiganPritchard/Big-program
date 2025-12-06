using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class BossMove
    {

        // dragon moves
        public static void DragonBreath(BindingList<Character> party)
        {
            foreach (Character target in party)
            {
                target.HP -= 30;
            }
        }
        public static void DragonClaw(BindingList<Character> party)
        {
            int targetIndex = new Random().Next(party.Count);
            party[targetIndex].HP -= 50;
        }
        public static void KnightCleave(BindingList<Character> party)
        { 
            int targetIndex = new Random().Next(party.Count);
            party[targetIndex].HP -= 40;
            int secondIndex = new Random().Next(party.Count);
            while (secondIndex == targetIndex)
            {
                secondIndex = new Random().Next(party.Count);
            }
            party[secondIndex].HP -= 40;

        }
        public static void KnightShieldBash(BindingList<Character> party)
        {
            int targetIndex = new Random().Next(party.Count);
            party[targetIndex].HP -= 60;
        }
        // ogre moves
        public static void OgreSmash(BindingList<Character> party)
        {
            int targetIndex = new Random().Next(party.Count);
            party[targetIndex].HP -= 70;
        }
        public static void OgreStomp(BindingList<Character> party)
        {
            foreach (Character target in party)
            {
                target.HP -= 10;
            }
        }

    }
}
