using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayesha1281246.University
{
    public enum gender{Male, Female}
    public class students:Entity
    {
        public string StudentName { get; set; }
        public string StudentFName { get; set; }
        public string StudentMName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public gender Gender { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public override string ToString()
        {
            return $"Student ID:{ID}\nStudent Name:{StudentName}\nFather's Name:{StudentFName}\nMother's Name:{StudentMName}" +
                $"\nDate Of Birth:{DateOfBirth}\nContact Number:{ContactNo}\n";

        }

    }
}
