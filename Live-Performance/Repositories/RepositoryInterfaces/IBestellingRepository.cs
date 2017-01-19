using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;

namespace Live_Performance.Repositories.RepositoryInterfaces
{
    public interface IBestellingRepository:IRepository<Bestelling>
    {
        void AssignDrankToBestelling(List<Drank> entityProducten);
        void AssignSaladeToBestelling(List<Salade> entityProducten);
        void AssignPizzaToBestelling(List<Pizza> entityProducten);
        int GetWachttijd(int bestellingId);
    }
}
