using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    class Seel : Pokemon
    {
        public Seel()
        {
            this.Type = PokemonType.Water;
            this.Height = 1.1;
            this.Weight = 90;
            this.HP = 65;
            this.Attack = 45;
            this.Defense = 55;
            this.SpecialAttack = 45;
            this.SpecialDefense = 70;
            this.Speed = 45;
            this.Total = 325;
            this.Name = "Seel";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("seel") as byte[] ?? Array.Empty<byte>();
        }
    }
}
