using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRelacionamentoTabelaClasses
{
    internal class BaseContext:DbContext
    {
        public BaseContext() : base("Formula1")//Formula1 nome do banco (ele vai usar de referencia)
        { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
