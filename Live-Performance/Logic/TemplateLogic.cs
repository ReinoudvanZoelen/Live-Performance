using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_Performance.Repositories.Context;
using Live_Performance.Repositories.MSSQLRepository;

namespace Live_Performance.Logic
{
    public class TemplateLogic
    {
        private TemplateContext context = new TemplateContext(new MSSQLTemplateRepository());
    }
}
