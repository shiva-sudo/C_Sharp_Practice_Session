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
            // Local Variable age
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

//Explanation :
//In the above program, the variable “age” is a local variable to the function StudentAge().
//If we use the variable age outside StudentAge() function, the compiler will produce an error as shown in below program.

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
            // Local Variable age
            int age = 26;
            age = age + 10;
            //Console.WriteLine("Student Age is : {0} ", age);
        }
        static void Main(string[] args)
        {
          
            // out side of the method
            Console.WriteLine("Student Age is : {0} ", age);
            Console.ReadLine();

        }
    }
}
// error CS0103: The name 'age' does not exist in the current context
