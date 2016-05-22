using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A marketing company wants to keep record of its employees.Each record would have the following characteristics:
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names.Print the data at the console.
//• First name • Last name • Age(0...100) • Gender(m or f) • Personal ID number(e.g. 8306112507) 
//• Unique employee number(27560000…27569999)

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            string lastName = "Marley";
            byte age = 27;
            char gender = 'm';
            ulong personalID = 8306112507;
            uint UniqueEmployeeNumber = 27563571;

            Console.WriteLine("First name: {0}\nLast name: {1}", firstName, lastName + "\n" + "Age: " + age + "\n" +
                             "Gender: " + gender + "\n" + "Persenol ID: " + personalID + "\n" + 
                             "Unique Employee number: " + UniqueEmployeeNumber);



        }
    }
}
