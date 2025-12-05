using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {

        public string Name { get; set; }

        public PokemonType PrimaryType { get; set; }

        public PokemonType SecondaryType { get; set; }

        public int HP { get; set; }
        
        public int Attack { get; set; }

        public int Defense { get; set; }

        public int SpecialAttack { get; set; }

        public int SpecialDefense { get; set; }

        public int Speed { get; set; }

        public BindingList<Move> Moves { get; set; }

        public Pokemon( string Name, int HP,  int Attack, int Defense, int Speed, BindingList<Move> Moves ) { 
            this.Name = Name;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.Moves = Moves ?? new BindingList<Move>();

        }
    }
}
