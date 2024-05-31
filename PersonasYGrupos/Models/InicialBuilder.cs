using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Models
{
    internal class InicialBuilder : IListaBuilder
    {
        public List<Employee> dameEmpleados()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            {
                ID = 1,
                FName = "John",
                MName = "",
                LName = "Shields",
                DOB = DateTime.Parse("11/12/1971"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 2,
                FName = "Mary",
                MName = "Matthew",
                LName = "Jacobs",
                DOB = DateTime.Parse("17/01/1961"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 3,
                FName = "Amber",
                MName = "Carl",
                LName = "Agar",
                DOB = DateTime.Parse("23/12/1971"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 4,
                FName = "Kathy",
                MName = "",
                LName = "Berry",
                DOB = DateTime.Parse("15/11/1976"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 5,
                FName = "Lena",
                MName = "Ashco",
                LName = "Bilton",
                DOB = DateTime.Parse("11/05/1978"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 6,
                FName = "Susanne",
                MName = "",
                LName = "Buck",
                DOB = DateTime.Parse("7/03/1965"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 7,
                FName = "Jim",
                MName = "",
                LName = "Brown",
                DOB = DateTime.Parse("11/09/1972"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 8,
                FName = "Jane",
                MName = "G",
                LName = "Hooks",
                DOB = DateTime.Parse("11/12/1972"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 9,
                FName = "Robert",
                MName = "",
                LName = "",
                DOB = DateTime.Parse("28/06/1964"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 10,
                FName = "Cindy",
                MName = "Preston",
                LName = "Fox",
                DOB = DateTime.Parse("11/01/1978"),
                Sex = 'M'
            });
            return empList;
        }
    }
}
