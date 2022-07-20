using ProjetoDIO_JogoRPG_C_.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight arus = new Knight("Arus", 23, "Knight");
        Warlock mitch = new Warlock("Mitch", 42, "Warlock");
        Ninja wedge = new Ninja("Wedge", 22, "Ninja");
        Wizard jenica = new Wizard("Jenica", 40, "Wizard");


        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 21);


        Console.WriteLine(mitch.Attack(valorInteiro));
        Console.WriteLine(arus.Attack(valorInteiro));
        Console.WriteLine(wedge.Attack(valorInteiro));
        Console.WriteLine(jenica.Attack(valorInteiro));

    }
}