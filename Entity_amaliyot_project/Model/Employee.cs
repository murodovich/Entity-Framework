using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_amaliyot_project.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int StaffId {  get; set; }

        public Staff Staff { get; set; }

        public override string ToString()
        {
            Console.WriteLine(this.FirstName);
            Console.WriteLine(this.LastName);
            Console.WriteLine(this.Email);
            Console.WriteLine(this.Staff.Description);

            return null;
        }



    }
}
