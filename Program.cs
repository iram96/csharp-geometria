namespace csharp_es03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la base");
            int rispA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("inserisci l'altezza");
            int rispB = Convert.ToInt32(Console.ReadLine());

            Rettangolo primoRett = new Rettangolo();
            Rettangolo secondoRett = new Rettangolo();


            Console.WriteLine(primoRett.infoRettangolo(rispA, rispB));
            // Console.WriteLine("La tua Area è {0}", primoRett.calcolaArea(rispA, rispB));
            // Console.WriteLine("Il tuo Perimetro è {0}", primoRett.calcolaPerimetro(rispA, rispB));
        }
    }
}
