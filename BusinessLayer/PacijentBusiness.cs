using DataLayer.Models;
using DataLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class PacijentBusiness
    {
        PacijentRepository pacijentRepository;

        public PacijentBusiness()
        {
            pacijentRepository = new PacijentRepository();
        }

        public List<Pacijent> GetPacijent()
        {
            return pacijentRepository.GetPacijent();
        }
        public bool InsertPacijent(Pacijent p)
        {
            int result = pacijentRepository.InsertPacijent(p);
            if (result != 0)
                return true;
            else
                return false;
        }
        public bool UpdatePacijent(Pacijent p)
        {
            int result = pacijentRepository.UpdatePacijent(p);
            if (result != 0)
                return true;
            else
                return false;
        }

        public bool DeletePacijent(int pid)
        {
            int result = pacijentRepository.DeletePacijent(pid);
            if (result != 0)
                return true;
            else
                return false;
        }
    }
}

