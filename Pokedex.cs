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
        }

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        public enum PokemonType
        {
            Fire, Grass, Psychic, Electric, Water, Unknown,  
        };
        private void InitialList()
        {
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Charmander", "Charmander is a fire type pokémon.", Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new Pokemon("Squirtle", "Squirtle is a water type pokémon.", Pokedex.PokemonType.Water);
            this.pokemons.Add(p);
            p = new Pokemon("Pikachu", "Pikachu is a electric type pokémon.", Pokedex.PokemonType.Electric);
            this.pokemons.Add(p);
            p = new Pokemon("Raychu", "Raychu is a electric type pokémon and it's an evolve from Pikachu!!", Pokedex.PokemonType.Electric);
            this.pokemons.Add(p);
            p = new Pokemon("Charmeleon", "Charmeleon is a fire type pokémon and it's an evolve from Charmander!!", Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new Pokemon("Charizard", "Charizard is a fire type pokémon and it's an evolve from Charmeleon", Pokedex.PokemonType.Fire);
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Mew is a psychic pokémon", Pokedex.PokemonType.Psychic);
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "Mewtwo is a psychic pokémon and it's an evolve from Mew!! This pokémon is so dangerous.", Pokedex.PokemonType.Psychic);
            this.pokemons.Add(p);
            p = new Pokemon("Caterpie", "Caterpie is a grass type pokémon.", Pokedex.PokemonType.Grass);
            this.pokemons.Add(p);
            p = new Pokemon("Metapod", "Metapod is a grass type pokémon and it's an evolve from Caterpie!", Pokedex.PokemonType.Grass);
            this.pokemons.Add(p);
        }
    }
}