using DataLayer.Models;
using DataLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class DoktorBusiness
    {
        DoktorRepository doktorRepository;

        public DoktorBusiness()
        {
            doktorRepository = new DoktorRepository();
        }

        public List<Doktor> GetDoktor()
        {
            return doktorRepository.GetDoktor();
        }
        public bool InsertDoktor(Doktor d)
        {
            int result = doktorRepository.InsertDoktor(d);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdateDoktor(Doktor d)
        {
            int result = doktorRepository.UpdateDoktor(d);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool DeleteGost(int did)
        {
            int result = doktorRepository.DeleteDoktor(did);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}

