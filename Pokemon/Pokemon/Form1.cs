using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        //add all types
        public List<PokemonType> pokemonTypes = new List<PokemonType>
            {
                new PokemonType("Normal"),
                new PokemonType("Fire"),
                new PokemonType("Water"),
                new PokemonType("Electric"),
                new PokemonType("Grass"),
                new PokemonType("Ice"),
                new PokemonType("Fighting"),
                new PokemonType("Poison"),
                new PokemonType("Ground"),
                new PokemonType("Flying"),
                new PokemonType("Psychic"),
                new PokemonType("Bug"),
                new PokemonType("Rock"),
                new PokemonType("Ghost"),
                new PokemonType("Dragon")
            };
        public BindingList<Pokemon> Pokedex = new BindingList<Pokemon>(
            new Pokemon("Bulbasaur", pokemonTypes, );
        

        public Form1()
        {
            InitializeComponent();
        }
    }
}
