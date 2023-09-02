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
            int tl = 0;
            int choose = 0;
            Console.WriteLine("Initializing Pokédex.....");
            //for (int i = 0;  i < 20; i++)
            //{
            //    Console.WriteLine("..."[i]);
            //}
            try
            {
                Console.Write("Choose a number:  (0 to 10) ");
                tl = Convert.ToInt32(Console.ReadLine());
                choose = Convert.ToInt32(Console.ReadLine());
                if (tl > 10) tl = 10;
            }
            catch {
                tl = 1;
            }
            Pokemon pokemon = pokedex.Pokemons[choose];
            pokemon.ShowDataPokemon();
            Console.ReadKey();
        }
    }
}