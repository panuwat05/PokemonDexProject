using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDex;

namespace PokemonDex
{
    class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            this.Type = PokemonType.Psychic;
            this.Height = 2.0;
            this.Weight = 122;
            this.HP = 106;
            this.Attack = 110;
            this.Defense = 90;
            this.SpecialAttack = 154;
            this.SpecialDefense = 90;
            this.Speed = 130;
            this.Total = 680;
            this.Name = "Mewtwo";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("mewtwo") as byte[] ?? Array.Empty<byte>();
        }
    }
}