using Ayesha1281246.Repositories;
using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Tests
{
    public class Test3
    {

        private IGenericRepository<students> repo;
        public Test3(IGenericRepository<students> repo)
        {
            this.repo = repo;
        }
        public void run()
        {
            this.repo.Add(new students { ID = 2222, StudentName = "Farjana", StudentFName="Farid", StudentMName="Momtaj", DateOfBirth= new DateTime(2000, 3, 2), ContactNo="013XXXXXXXX" });
            this.repo.AddRange(new students[]
            {
               new students {ID = 3333, StudentName = "Raida", StudentFName = "Dewan", StudentMName = "Asma", DateOfBirth = new DateTime(2006, 02, 09), Gender = gender.Female, Address = "Shewrapara, Dhaka", ContactNo = "0188XXXXXXX"},
                new students {ID = 4444, StudentName = "Aria", StudentFName = "Asraf", StudentMName = "Sultana", DateOfBirth = new DateTime(2006, 05, 01), Gender = gender.Female, Address = "Shewrapara, Dhaka", ContactNo = "0191XXXXXXX" }
            });
            //
            this.repo.Get().ToList().ForEach(x => { Console.WriteLine(x); });
            Console.WriteLine();
        }
    }
}
