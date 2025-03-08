using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDex;

namespace PokemonDex
{
    class Cubone : Pokemon
    {
        public Cubone()
        {
            this.Type = PokemonType.Ground;
            this.Height = 0.4;
            this.Weight = 6.5;
            this.HP = 50;
            this.Attack = 50;
            this.Defense = 95;
            this.SpecialAttack = 40;
            this.SpecialDefense = 50;
            this.Speed = 35;
            this.Total = 320;
            this.Name = "Cubone";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("cubone") as byte[] ?? Array.Empty<byte>();
        }
    }
}