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
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasaur";
            p.DataPokemon = "Bulbasaur is a earth type pokémon.";
            p.ShowDataPokemon(true);
            Console.ReadKey();  
        }
    }
}