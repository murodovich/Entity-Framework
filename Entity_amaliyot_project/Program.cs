using Entity_amaliyot_project.Model;
using Entity_amaliyot_project.StudyDBContect;
using Microsoft.EntityFrameworkCore;

StudyDBContext context = new StudyDBContext();
Staff staff = new Staff();
Employee employee = new Employee();
//employee.FirstName = "Sherbek";
//employee.LastName = "Shukurov";
//employee.Email = "sherSHukur@gmail.com";
//employee.Password = "11111222";
//employee.StaffId = 1006;

//context.Employees.Add(employee);

//var stafff = context.Employees.First(name => name.FirstName =="Sarvar");
//stafff.FirstName = "Sarvarbek";
//context.Employees.Update(stafff);
//context.SaveChanges();


var employe = context.Employees
    .Where(x => x.LastName.Equals("G'ulomjonov"))
    .Include(x => x.Staff)
    .FirstOrDefault();

Console.WriteLine(employe);
context.SaveChanges();
    
    






