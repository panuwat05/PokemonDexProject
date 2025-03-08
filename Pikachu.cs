using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    //inheritance from the Pokemon class
    public class Pikachu : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Pikachu()
        {
            this.Type = PokemonType.Electric;
            this.Height = 0.4;
            this.Weight = 6.0;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;
            this.Name = "Pikachu";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("pikachu") as byte[] ?? Array.Empty<byte>();
        }
    }
}
