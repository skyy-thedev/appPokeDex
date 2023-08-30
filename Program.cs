using appPokedex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPokeDex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokemons[1];
            p.ShowDataPokemon();
            Console.ReadKey();
        }
    }
}