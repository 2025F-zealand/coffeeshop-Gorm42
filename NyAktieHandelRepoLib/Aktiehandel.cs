namespace NyAktieHandelRepoLib
{
    public class Aktiehandel
    {
        private int _handelsId; //handelsId skal være unikt, men det kan vi først løse i repo, når vi har en liste vi kan køre igennem.
        private string _aktieNavn; //skal være lig med eller længere end 4 tegn
        private int _antal; //skal være større end nul
        private decimal _handelsPris; //

        public Aktiehandel(string aktieNavn, int antal, decimal handelsPris)
        {
            AktieNavn = aktieNavn;
            Antal = antal;
            HandelsPris = handelsPris;
        }

        public int HandelsId
        {
            get 
            { return _handelsId;} //overvej at lave en Id skal være 1 eller højere.
            set { _handelsId = value; }
        }

        public string AktieNavn
        {
            get { return _aktieNavn; } 
            set 
            { 
                if (value != null && value.Length >= 4)
                {
                    _aktieNavn = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AktieNavn skal være mindst 4 tegn langt");
                }
                     
            }        
        }

        public int Antal { get { return _antal; } set { _antal = value; } }

        public decimal HandelsPris { get { return _handelsPris; } set { _handelsPris = value; } }

        public override string ToString()
        {
            return ($"Diese Aktie, {AktieNavn}, ist {HandelsPris} Kronen wert, und Sie haben {Antal} davon.");
        }
    }
}
