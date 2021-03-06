﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Classes;

namespace Live_Performance.Repositories.RepositoryInterfaces
{
    public interface IDrankRepository:IRepository<Drank>
    {
        List<Drank> GetByBestellingID(int id);
    }
}
