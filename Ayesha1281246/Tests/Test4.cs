using Ayesha1281246.Repositories;
using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.Tests
{
    public class Test4
    {
        public void Run(IGenericRepository<Teachers> repo)
        {
            //Insert
            Console.WriteLine("-------------Insert----------");
           
            repo.Add(new Teachers { ID = 12, TeacherName = "Najmul", Address = "Kazipara, Dhaka", PhoneNo = "0132XXXXXXX", Email = "najmul@yahoo.com", Salary = 100000 });
            repo.AddRange(new[] {new Teachers { ID=13, TeacherName="Bashir", Address="Shewrapara, Dhaka", PhoneNo="01999XXXXXX", Email="basirsr@gamil.com",Salary=65000},
                         new Teachers { ID=14, TeacherName="Salam Uddin", Address="Mirpur 10, Dhaka", PhoneNo="018769XXXXX", Email="salam@pb.com", Salary=150000}
            });
            repo.Get().ToList()
                .ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));

            //update
            Console.WriteLine("-------------Update-------------");

            var teachers = repo.Get(12);
            teachers.Address = "Dhanmondi, Dhaka";
            repo.Update(teachers);
            repo.Get()
                .ToList()
                .ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));

            //Delete
            Console.WriteLine("-------------Delete--------------");

            repo.Delete(13);
            repo.Get()
                .ToList().ForEach(x => Console.WriteLine($"ID:{x.ID}\nTeacher's Name:{x.TeacherName}\nAddress:{x.Address}\nPhone No:{x.PhoneNo}" +
                $"\nEmail:{x.Email}\nSalary:{x.Salary}\n"));
        }
    }
}
