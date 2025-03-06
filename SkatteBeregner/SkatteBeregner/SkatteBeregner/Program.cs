namespace SkatteBeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Create an instance or object of SkatteBeregning that we can then call its methods on.
            SkatteBeregning skatteBeregning = new SkatteBeregning();

            List<Borger> bürger = new List<Borger>();
            bürger.Add(new Borger("Arne", Borger.TypeAfBorger.Pensionist, 8000));            
            bürger.Add(new Borger("Benedikte",Borger.TypeAfBorger.Underviser, 21000));
            bürger.Add(new Borger("Camilla",Borger.TypeAfBorger.Studerende, 20002));
            bürger.Add(new Borger("Dorthe",Borger.TypeAfBorger.Studerende, 19000));
            bürger.Add(new Borger("Erik",Borger.TypeAfBorger.Underviser, 17000));
            bürger.Add(new Borger("Frederik", Borger.TypeAfBorger.Pensionist, 20500));
            bürger.Add(new Borger("Greta", Borger.TypeAfBorger.Pensionist, 0));

            foreach (Borger b in bürger)
            {
                double skat = skatteBeregning.BeregnSkat(b.TypeBorger, b.Indkomst);
                Console.WriteLine($" {b.Name} skal betale {skat} kr. i skat.");
            }
        }
    }
}
