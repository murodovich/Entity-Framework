using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_amaliyot_project.Model
{
    public class Staff
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        ICollection<Employee> Employees { get; set; }   


        
        
        
    }
}
