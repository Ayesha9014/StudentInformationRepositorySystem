using Ayesha1281246.Factrories;
using Ayesha1281246.Repositories;
using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Tests
{
    public class Test1
    {
        readonly IRepositoryFactory factory;
        public Test1(IRepositoryFactory factory)
        {
            this.factory = factory;
        }
        public void Run()
        {
            Console.WriteLine("Students");
            //Insert
            Console.WriteLine("-------------Insert------------");
            IGenericRepository<students> repo = this.factory.GetRepo<students>();
            repo.Add(new students { ID = 1234, StudentName = "Alif", StudentFName = "Rahim", StudentMName = "Jakiya", DateOfBirth = new DateTime(2004, 02, 05), Gender = gender.Male, Address = "Shewrapara, Dhaka", ContactNo = "0187XXXXXXX" });
            repo.AddRange(new students[] {
                new students {ID = 6677, StudentName = "Raida", StudentFName = "Dewan", StudentMName = "Asma", DateOfBirth = new DateTime(2006, 02, 09), Gender = gender.Female, Address = "Shewrapara, Dhaka", ContactNo = "0188XXXXXXX"},
                new students {ID = 6679, StudentName = "Aria", StudentFName = "Asraf", StudentMName = "Sultana", DateOfBirth = new DateTime(2006, 05, 01), Gender = gender.Female, Address = "Shewrapara, Dhaka", ContactNo = "0191XXXXXXX" }
                });
            repo.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x}"));
            Console.WriteLine();

            //Update
            Console.WriteLine("------------UpDate-----------");
            var students = repo.Get(1234);
            students.ContactNo = "0177XXXXXXX";
            repo.Update(students);
            repo.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"{x}"));

            //Delete
            Console.WriteLine("------------Delete------------");
            repo.Delete(6677);
            repo.Get()
                .ToList().ForEach(x => Console.WriteLine($"{x}"));

            Console.WriteLine();
            Console.WriteLine("Teachers");
            //Insert
            Console.WriteLine("-------------Insert----------");
            IGenericRepository<Teachers> repo1 = factory.GetRepo<Teachers>();
            repo1.Add(new Teachers { ID = 12, TeacherName = "Najmul", Address = "Kazipara, Dhaka", PhoneNo = "0132XXXXXXX", Email = "najmul@yahoo.com", Salary = 100000 });
            repo1.AddRange(new[] {new Teachers { ID=13, TeacherName="Bashir", Address="Shewrapara, Dhaka", PhoneNo="01999XXXXXX", Email="basirsr@gamil.com",Salary=65000},
                         new Teachers { ID=14, TeacherName="Salam Uddin", Address="Mirpur 10, Dhaka", PhoneNo="018769XXXXX", Email="salam@pb.com", Salary=150000}
            });
            repo1.Get().ToList()
                .ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));

            //update
            Console.WriteLine("-------------Update-------------");

            var teachers = repo1.Get(12);
            teachers.Address = "Dhanmondi, Dhaka";
            repo1.Update(teachers);
            repo1.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));

            //Delete
            Console.WriteLine("-------------Delete--------------");

            repo1.Delete(13);
            repo1.Get()
                .ToList().ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));
        }
    }
}
