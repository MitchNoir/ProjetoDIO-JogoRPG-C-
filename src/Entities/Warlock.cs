using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDIO_JogoRPG_C_.src.Entities
{
    public class Warlock : Hero
    {
        public Warlock(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou um feitiço!";
        }

        public string Attack(int Bonus){

            if (Bonus > 16){
                return this.Name + " Lançou um Feitiço critico que causou " + Bonus + " de dano";
            }else if (Bonus > 5) {
                return this.Name + " Lançou uma Feitiço que causou " + Bonus + " de dano";
            }else{
                return this.Name + " Lançou um feitiço fraco que causou " + Bonus + " de dano";
            }

        }
    }
}