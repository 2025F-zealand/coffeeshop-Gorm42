using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktieHandelRepositoryLib
{
    public class AktieHandelRepository 
    {
        //opgaveformulering fra den 27.02.25
        // create database https://learn.microsoft.com/en-us/sql/relational-databases/databases/create-a-database?view=sql-server-ver16
        // save the connection-string https://learn.microsoft.com/en-us/visualstudio/data-tools/how-to-save-and-edit-connection-strings?view=vs-2022
        //Field vs. property : https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property
        private List<Aktie> AktieListe;
        private int _nextId = 1;

        //public AktieHandelRepository()
        //{
        //    AktieListe = new List<Aktie>();
        //}

        /// <summary>
        /// GetAktieById metode. Bruger lambda udtryk til at finde et aktie objekt
        /// i listen AktieListe ud fra et id, som er ens med det i parametrene.
        /// </summary>
        /// <returns>Returnerer et aktie objekt  med pågældende id</returns>
        public Aktie GetAktieById(int id)
        {
            return AktieListe.Find(aktie => aktie.HandelsId == id);
        }

        /// <summary>
        /// GetAllAktier metode. Returnerer hele listen af aktier.
        /// </summary>
        /// <returns>Returnerer alle aktie objekter i AktieListe</returns>
        public List<Aktie> GetAllAktier()
        {
            return AktieListe;
        }

        /// <summary>
        /// GetAktie --- fejl fra Martin? - for den skal gøre det samme som GetAllAktier
        /// </summary>
        /// <returns>Returnerer alle aktie objekter fra AktieListe</returns>
        public List<Aktie> GetAktie()
        {
            return AktieListe;
        }

        /// <summary>
        /// AddAktie metode. Vi sender det gamle id og det nye id med som parametre.
        /// Dernæst kører vi GetAktieById metoden og gemmer objektet i en ny Aktie variabel.
        /// Vi sætter dernæst det hentede objekts HandelsId til det nye id.
        /// Til sidst tilføjer vi det nye objekt til listen AktieListe og returnere objektet.
        /// </summary>
        /// <returns></returns>
        public Aktie AddNewIdToAktie(int oldId, int newId)
        {
            Aktie aktie = GetAktieById(oldId);
            aktie.HandelsId = newId;
            AktieListe.Add(aktie);
            return aktie;
        }

        /// <summary>
        /// Vi henter en aktie ud fra dens id og sletter den dernæst fra listen
        /// så fremt den ikke er null 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returnerer aktie objektet hvis metoden virker og eller null</returns>
        public Aktie? DeleteAktie(int id)
        {
            Aktie aktie = GetAktieById(id);
            if (aktie != null)
            {
                AktieListe.Remove(aktie);
                return aktie;
            }
            return null;
        }

        /// <summary>
        /// UpdateAktie metode. Vi henter en aktie ud fra dens id via GetAktieById metoden
        /// og opdaterer den med de nye data. Vi inkluderer i dette id'et, selvom dette 
        /// kan være problematisk. Kan man overveje at fjerne fra opdateringen. Lave
        /// en separat metode til at opdatere id'et.
        /// </summary>
        /// <param name="aktie"></param>
        /// <returns>Returnerer et aktie objekt hvis det findes og ellers null</returns>
        public Aktie? UpdateAktie(Aktie aktie)
        {
            Aktie aktieOpdateres = GetAktieById(aktie.HandelsId);
            if (aktieOpdateres != null)
            {
                aktieOpdateres.HandelsId = aktie.HandelsId;
                aktieOpdateres.AktieNavn = aktie.AktieNavn;
                aktieOpdateres.Antal = aktie.Antal;
                aktieOpdateres.Pris = aktie.Pris;
                return aktieOpdateres;
            }
            return null;
        }
















        public int GenerateId()
        {
            return _nextId++; 
        }
        
        public Aktie AddAktieAktieListe(Aktie aktie)
        {
            aktie.HandelsId = GenerateId();
            AktieListe.Add(aktie);
            return aktie;
        }

        

       








    }
}
