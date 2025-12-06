using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokemon
{

    public class GameMove 
    {
        public string name;
        public Action<Character, Character> effect;
        private static Random random = new Random();


        public GameMove(string name, Action<Character, Character> effect)
        {
            this.name = name;
            this.effect = effect;
        }

        // fireball has more casts, and does less damage
        public static void FireBall(Character user, Character target)
        {
            target.HP -= user.Atk * 3;
            if (random.Next(4) == 0)
            {
                target.HP -= user.Atk * 2;
            }
        }
        // pyroBlast is a bigger attack, with higher chance to proc an extra burn tick
        public static void PyroBlast(Character user, Character target)
        {
            target.HP -= user.Atk * 6;
            if (random.Next(2) == 0)
            {
                target.HP -= user.Atk * 4;
            }
        }
        public static void MageShield(Character user, Character target)
        {
            user.Def += 10;
        }
        public static void MageMelee(Character user, Character target)
        {
            target.HP -= user.Atk;
        }
        // warrior big attack
        public static void WarriorSlam(Character user, Character target)
        {
            target.HP -= user.Atk * 6;
        }
        // warrior defense up move
        public static void WarriorDefend(Character user, Character target)
        {
            user.Def += 10;
        }
        // warrior basic attack
        public static void WarriorStrike(Character user, Character target)
        {
            target.HP -= user.Atk * 2;
            // has a chance to strike twice
            if (random.Next(3) == 0)
            {
                target.HP -= user.Atk * 2;
            }
        }
        public static void WarriorRage(Character user, Character target)
        {
            user.Atk += 5;
        }
        public static void PriestSmite(Character user, Character target)
        {
            target.HP -= user.Atk * 4;
        }
        // restores health to all alies
        public static void PriestSmallHeal(Character user, Character target)
        {
            user.HP += user.Atk * 3;
        }

        // restores a large amount of health to allies
        public static void PriestLargeHeal(Character user, Character target)
        {
            user.HP += user.Atk * 6;
        }
        // revives a fallen ally to 50 HP
        public static void PriestRevive(Character user, Character target)
        {
            target.HP = 50;
        }

        public static void RogueBackstab(Character user, Character target)
        {
            target.HP -= user.Atk * 5;
            // has a chance to crit
            if (random.Next(3) == 0)
            {
                target.HP -= user.Atk * 5;
            }
        }
        public static void RoguePoison(Character user, Character target)
        {
            target.HP -= user.Atk * 2;
            // applies an instant poison
            if (random.Next(2) == 0)
            {
                target.HP -= user.Atk * 2;
            }
        }
        public static void RogueEvade(Character user, Character target)
        {
            user.Def += 10;
        }
        public static void RogueSlice(Character user, Character target)
        {
            target.HP -= user.Atk * 3;
        }
    }
}