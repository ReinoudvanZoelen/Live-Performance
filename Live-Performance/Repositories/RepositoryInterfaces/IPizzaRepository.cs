﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;

namespace Live_Performance.Repositories.RepositoryInterfaces
{
    public interface IPizzaRepository:IRepository<Pizza>
    {
        List<Pizza> GetByBestellingID(int id);
    }
}
