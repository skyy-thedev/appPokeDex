using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPokedex
{
    public class Pokemon
    {
		public Pokemon()
		{
			this.Nome = "";
			this.DataPokemon = "";
		}
        public Pokemon(String nome, String dataPokemon)
        {
            this.Nome = nome;
			this.DataPokemon = dataPokemon;
        }

        private String nome;

		public String Nome
		{
			get { 
				return nome; 
			}
			set {
				String texto = value.ToUpper();
				nome = texto; 
			}
		}
		// DATA DESCRIPTION OF POKEMON //
		private String dataPokemon; 

		public String DataPokemon
		{
			get { return this.dataPokemon; }
			set {
				this.dataPokemon = value.ToUpper();
			}
		}
		// METOD - SHOW ALL INFO //
		public void ShowDataPokemon()
		{
			Console.WriteLine("Pokémon name: " + this.Nome);
			Console.WriteLine("Description:  " + this.DataPokemon);

		}
        // METOD - SHOW ALL INFO  2//
        public void ShowDataPokemon(Boolean formated)
        {
			if(formated == true)
			{
				Console.WriteLine("Pokémon: " + this.Nome + " - " + this.DataPokemon.ToLower());
			}
			else
			{
                Console.WriteLine("Pokémon name: " + this.Nome);
                Console.WriteLine("Description:  " + this.DataPokemon);
            }
        }
    }
}
