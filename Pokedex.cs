using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPokedex
{
    public class Pokedex
    {
        // CONSTRUCTOR //
        public Pokedex()
        {
            this.InitialList();
            this.PokemonList();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        public enum PokemonType
        {
            Fire, Grass, Psychic, Electric, Water, Unknown,  
        };
        private void InitialList()
        {
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus ("Charmander", "Charmander is a fire type pokémon.", 30 , Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new PokemonPlus("Squirtle", "Squirtle is a water type pokémon.", 25, Pokedex.PokemonType.Water);
            this.pokemons.Add(p);
            p = new PokemonPlus("Pikachu", "Pikachu is a electric type pokémon.", 50, Pokedex.PokemonType.Electric);
            this.pokemons.Add(p);
            p = new PokemonPlus("Raychu", "Raychu is a electric type pokémon and it's an evolve from Pikachu!!", 60, Pokedex.PokemonType.Electric);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charmeleon", "Charmeleon is a fire type pokémon and it's an evolve from Charmander!!", 50, Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new PokemonPlus("Charizard", "Charizard is a fire type pokémon and it's an evolve from Charmeleon", 100, Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Mew is a psychic pokémon", 80, Pokedex.PokemonType.Psychic);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Mewtwo is a psychic pokémon and it's an evolve from Mew!! This pokémon is so dangerous.", 120, Pokedex.PokemonType.Psychic);
            this.pokemons.Add(p);
            p = new PokemonPlus("Caterpie", "Caterpie is a grass type pokémon.", 25, Pokedex.PokemonType.Grass);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metapod", "Metapod is a grass type pokémon and it's an evolve from Caterpie!", 45, Pokedex.PokemonType.Grass);
            this.pokemons.Add(p);
        }
        public void PokemonList()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                this.Pokemons[i].ShowPokemonDataPlus();
            }
        }
    }
}