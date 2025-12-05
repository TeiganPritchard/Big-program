using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Move
    {
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }

        public Move(string name, PokemonType type, int power, int accuracy)
        {
            Name = name;
            Type = type;
            Power = power;
            Accuracy = accuracy;
        }
    }
}
