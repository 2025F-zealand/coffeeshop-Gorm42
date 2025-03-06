using Aktie;

namespace AktieDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Aktie1 aktie = new Aktie1("Novo", 100, 150, 500);
            aktie.ToString();
            Console.WriteLine("Dit afkast er: \n");
            Console.WriteLine(aktie.Afkast());

            Aktie1 novoAktie = new Aktie1("Novo", 100, 150, 100);
            Aktie1 mærskAktie = new Aktie1("Mærsk", 80, 95, 5);

            AktieManager portFolio = new AktieManager();
            portFolio.AddAktie(novoAktie);
            portFolio.AddAktie(mærskAktie);

            
        }
    }
}
