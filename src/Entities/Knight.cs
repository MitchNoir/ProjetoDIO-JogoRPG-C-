using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDIO_JogoRPG_C_.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }


        public string Attack(int Bonus){

            if (Bonus > 16){
                return this.Name + " Fez um ataque critico que causou " + Bonus + " de dano";
            }else if (Bonus > 5) {
                return this.Name + " Fez um ataque que causou " + Bonus + " de dano";
            }else{
                return this.Name + " Fez um ataque fraco que causou " + Bonus + " de dano";
            }
        }
    
    }
}