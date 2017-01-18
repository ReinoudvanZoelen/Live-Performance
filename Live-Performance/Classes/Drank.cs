﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance.Classes
{
    public class Drank : Product
    {
        public bool Alcoholhoudend { get; set; }

        public Drank(int id, string naam, decimal verkoopprijs, decimal inkoopprijs, bool alcoholhoudend)
        {
            this.ID = id;
            this.Naam = naam;
            this.Verkoopprijs = verkoopprijs;
            this.Inkoopprijs = inkoopprijs;
            this.Alcoholhoudend = alcoholhoudend;
        }

        public Drank()
        {
            
        }
    }
}
