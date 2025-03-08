using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public enum PokemonType
    {
        Normal,
        Fire,
        Electric,
        Water,
        Ground,
        Psychic,

    }
    public class Pokemon
    {
        //class attributes
        protected string Name;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int SpecialAttack;
        protected int SpecialDefense;
        protected int Speed;
        protected int Total;
        protected double Height;
        protected double Weight;
        protected PokemonType Type;
        protected byte[] image;
        //constructor
        public Pokemon() { }
        //methods
        public string getName()
        {
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
        public int getHP()
        {
            return this.HP;
        }
        public int getAttack()
        {
            return this.Attack;
        }
        public int getDefense()
        {
            return this.Defense;
        }
        public int getSpecialAttack()
        {
            return this.SpecialAttack;
        }
        public int getSpecialDefense()
        {
            return this.SpecialDefense;
        }
        public int getSpeed()
        {
            return this.Speed;
        }
        public int getTotal()
        {
            return this.Total;
        }
        public double getHeight()
        {
            return this.Height;
        }
        public double getWeight()
        {
            return this.Weight;
        }
        public string getType()
        {
            return this.Type.ToString();
        }
    }
}
