using appPokedex;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Console.Clear();
            int choose = 100;
            while (choose != 0)
            {
                choose = Menu();
                Console.Clear();
                if (choose == 1)
                {
                    pokedex.PokemonList();
                }
                if (choose == 2)
                {
                    // Pokemon choosing //
                    pokedex.PokemonList();
                    Console.WriteLine("Choose pokémon by CODE: ");
                    int CODE = Convert.ToInt32(Console.ReadLine());
                    // Locking player pokemon //
                    PokemonPlus player = pokedex.Pokemons[CODE];
                    // Random PC Pokemon for battle //
                    Random r = new Random();
                    CODE = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pc = pokedex.Pokemons[CODE];
                    Console.Clear();
                    Console.WriteLine("   " + player.Nome +  "      |    ---------    |     " + pc.Nome + "  ");
                    Console.WriteLine("Power: (" + player.Power + ")   |  --  Versus --  |  Power: (" + pc.Power + ")  ");
                    Console.WriteLine("Type: " + player.Tipo + "  |    ----------   |  Type: " + pc.Tipo + " ");
                    Console.WriteLine("");
                    // BATTLE //
                    if (player.Power > pc.Power)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You Win!");
                    }
                    else if (player.Power == pc.Power)
                    {
                        Console.WriteLine("IT'S A DRAW!!!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }

                }

                Console.ReadKey();
                Console.Clear();
                }
            }
        static int Menu()
        {
            Console.WriteLine("Initializing Pokédex........");
            Console.WriteLine("Press 0 to exit.");
            Console.WriteLine("Press 1 to Open Pokémon List.");
            Console.WriteLine("Press 2 for battle!!!");
            int choose = Convert.ToInt32(Console.ReadLine());
            return choose;
        }
    }
}