using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDIO_JogoRPG_C_.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        }


        public string Attack(int Bonus){

            if (Bonus > 16){
                return this.Name + " Lançou uma Magia critica que causou " + Bonus + " de dano";
            }else if (Bonus > 5) {
                return this.Name + " Lançou uma Magia que causou " + Bonus + " de dano";
            }else{
                return this.Name + " Lançou uma Magia fraca que causou " + Bonus + " de dano";
            }
        } 
    }
}