namespace csharp_es03
{
    internal class Rettangolo
    {

        //readonly rende la variabile immodificabile se non dal costruttore0
        private int baseRettangolo;
        private int altezzaRettangolo;
        public Rettangolo()
        {
            baseRettangolo = 0;
            altezzaRettangolo = 0;
        }

        public int calcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            return baseRettangolo * altezzaRettangolo;
        }

        public int calcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public bool infoRettangolo(int baseRettangolo, int altezzaRettangolo)
        {



            Console.WriteLine("-- Dati Rettangolo --");
            Console.WriteLine("-- base: {0} --", baseRettangolo);
            Console.WriteLine("-- altezza: {0} --", altezzaRettangolo);
            Console.WriteLine("-- area: {0} --", calcolaArea(baseRettangolo, altezzaRettangolo));
            Console.WriteLine("-- perimetro: {0} --", calcolaPerimetro(baseRettangolo, altezzaRettangolo));
            return true;
        }
    }
}
