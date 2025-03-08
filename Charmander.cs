using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Charmander : Pokemon
    {
        //constructor
        //run at first when the object is created
        public Charmander()
        {
            this.Type = PokemonType.Fire;
            this.Height = 0.5;
            this.Weight = 8.5;
            this.HP = 39;
            this.Attack = 52;
            this.Defense = 43;
            this.SpecialAttack = 60;
            this.SpecialDefense = 50;
            this.Speed = 65;
            this.Total = 309;
            this.Name = "Charmander";
            //check if the image in ResourceManager is not null
            //return the image
            this.image =
                Resource1.ResourceManager.GetObject("charmander") as byte[] ?? Array.Empty<byte>();
        }
    }
}
