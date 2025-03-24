using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyAktieHandelRepoLib
{
    public class AktieHandelRepository
    {
        private readonly List<Aktiehandel> aktiehandelListe = new List<Aktiehandel>();

        private int _nextId = 1;

        public Aktiehandel GetById(int id)
        {
            //return AktieListe.Find(aktie => aktie.HandelsId == id); <--- in lambda expression
            foreach (Aktiehandel aktie in aktiehandelListe)
            {
                if(aktie.HandelsId == aktie.HandelsId)
                {
                    return aktie;
                }
                else
                {
                    throw new Exception("An aktie does not exist by that id");
                    
                }                
            }
            return null;
        }

        public Aktiehandel GetAllAktier()
        {
            if(aktiehandelListe == null)
            {
                throw new Exception("The list of Aktier/shares is empty.");
            }
            foreach(Aktiehandel aktie in aktiehandelListe)
            {
                return aktie;
            }
            return null;

        }

        //to be used for sorting later apparently.
        public Aktiehandel Get()
        {
            if (aktiehandelListe == null)
            {
                throw new Exception("The list of Aktier/shares is empty.");
            }
            foreach (Aktiehandel aktie in aktiehandelListe)
            {
                return aktie;
            }
            return null;

        }

        public Aktiehandel Add(Aktiehandel aktieHandel)
        {
            Aktiehandel newAktiehandel = new Aktiehandel(aktieHandel.AktieNavn, aktieHandel.Antal, aktieHandel.HandelsPris);
            newAktiehandel.HandelsId = _nextId++;

            aktiehandelListe.Add(newAktiehandel);
            return newAktiehandel;
        }

        public Aktiehandel? Delete(int handelsId)
        {
            foreach(Aktiehandel aktiehandel in aktiehandelListe)
            {
                if(aktiehandel.HandelsId == handelsId)
                {
                    aktiehandelListe.Remove(aktiehandel);
                    return aktiehandel;
                }
                else if(aktiehandel.HandelsId == null)
                {
                    throw new ArgumentOutOfRangeException("Id does not exist in list.");                    
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newId"></param>
        /// <param name="updatedAktie"></param>
        /// <returns></returns>
        public Aktiehandel? Update(int newId, Aktiehandel updatedAktie)
        {
            Aktiehandel newAktieToBeUpdated = aktiehandelListe.Find(aktie => aktie.HandelsId == updatedAktie.HandelsId);
            if(newAktieToBeUpdated != null)
            {
                newAktieToBeUpdated.HandelsId = newId;
                newAktieToBeUpdated.AktieNavn = updatedAktie.AktieNavn;
                newAktieToBeUpdated.Antal = updatedAktie.Antal;
                newAktieToBeUpdated.HandelsPris = updatedAktie.HandelsPris;
                return newAktieToBeUpdated;
            }
            else
            {
                return null;
            }

        }

    }
}
