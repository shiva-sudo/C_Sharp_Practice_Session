using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession
{
    class studentDetails
    {
        //Method 
        public void StudentAge()
        {
            // Local Variable
            int age = 26;
            age = age + 10;
            Console.WriteLine("Student Age is : {0} ", age);
        }
        static void Main(string[] args)
        {
            //Creating Object
            studentDetails Obj = new studentDetails();
            Obj.StudentAge();
            Console.ReadLine();
        }
    }
}
