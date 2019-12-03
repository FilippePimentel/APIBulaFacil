using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIBulaFacil.Application.ViewModels.AATeste
{
    public class fooViewModel
    {
        public int id { get; set; }
        public string companyname { get; set; }
        public string companyaddress { get; set; }

        public EmployeeViewModel CotactPerson { get; set; }
        public EmployeeViewModel Manager { get; set; }

    }

    public class EmployeeViewModel
    {
        public int id { get; set; }
        public string employeename { get; set; }
        public string mobile { get; set; }
    }


    public class Boo
    {

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public ICollection<Employee> Employee { get; set; }

    }
    
    public class Employee
    {

        public int id { get; set; }
        public int fooid { get; set; }
        public foo foo { get; set; }
        public int Booid { get; set; }
        public string employeename { get; set; }
        public string mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
    }


    public class foo
    {

        public int id { get; set; }
        public string companyname { get; set; }
        public string companyaddress { get; set; }
        public string Email { get; set; }
        public DateTime EstablismentDate { get; set; }

    }


}
