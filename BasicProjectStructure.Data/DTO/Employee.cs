using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectStructure.Data.DTO
{
    internal class Employee : Entity<Guid>
    {
        
        public string Name { get; set; }
        public decimal Salray { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
