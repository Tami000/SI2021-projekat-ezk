using DataLayer.Models;
using DataLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class KartonBusiness
    {
        KartonRepository kartonRepository;

        public KartonBusiness()
        {
            kartonRepository = new KartonRepository();
        }

        public List<Karton> GetKarton()
        {
            return kartonRepository.GetKarton();
        }
        public bool InsertKarton(Karton k)
        {
            int result = kartonRepository.InsertKarton(k);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateKarton(Karton k)
        {
            int result = kartonRepository.UpdateKarton(k);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}

