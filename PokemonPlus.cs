using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPokedex
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this.Power = 0;
        }
        public PokemonPlus(String nome, String dataPokemon, int power, Pokedex.PokemonType tipo) : base(nome , dataPokemon, tipo)
        {
            this.Power = power;
        }

        public int Power { get; set; }

        public void ShowPokemonDataPlus()
        {
            Console.WriteLine("Pokémon name: " + this.Nome);
            Console.WriteLine("Description:  " + this.DataPokemon);
            Console.WriteLine("Power: " + this.Power);
            Console.WriteLine("Type: " + this.Tipo);
            Console.WriteLine("         ");
        }
    }
}
