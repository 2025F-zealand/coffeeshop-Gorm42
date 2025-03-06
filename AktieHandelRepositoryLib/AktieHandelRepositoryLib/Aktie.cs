namespace AktieHandelRepositoryLib
{
    public class Aktie
    {

        private int _handelsId;
        public int HandelsId 
        {
            get { return _handelsId; }
            set { 
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("HandelsId skal være større end 0");
                }
                _handelsId = value; }
        }

        private string _aktieNavn;
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


        private int _antal;
        public int Antal 
        {
            get {return _antal; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Antal skal være større end 0");
                }
                _antal = value;
            }
        
        }

        private decimal _pris;
        public decimal Pris 
        {
            get {return _pris; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Pris skal være større end 0");
                }
                _pris = value;
            } 
        }

        public Aktie(int handelsId, string aktieNavn, int antal, decimal pris)
        {
            HandelsId = handelsId;
            AktieNavn = aktieNavn;
            Antal = antal;
            Pris = pris;

        }


    }
}
