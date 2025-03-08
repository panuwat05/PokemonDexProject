using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Type = PokemonType.Normal;
            this.Height = 2.1;
            this.Weight = 460.0;
            this.HP = 160;
            this.Attack = 110;
            this.Defense = 65;
            this.SpecialAttack = 65;
            this.SpecialDefense = 110;
            this.Speed = 30;
            this.Total = 540;
            this.Name = "Snorlax";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("snorlax") as byte[] ?? Array.Empty<byte>();
        }
    }
}
