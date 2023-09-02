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
            Pokemon[] pokemons = new Pokemon[200];
            Console.WriteLine("Initializing Pokédex.....");
            int choose = 0;
            //for (int i = 0;  i < 20; i++)
            //{
            //    Console.WriteLine("..."[i]);
            //}
            try
            {
                Console.Write("Choose a number:  (0 to 10) ");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose > 10) choose = 10;
            }
            catch {
                choose = 1;
            }
            Pokemon pokemon = pokedex.Pokemons[choose];
            pokemon.ShowDataPokemon();
            Console.ReadKey();
        }
    }
}