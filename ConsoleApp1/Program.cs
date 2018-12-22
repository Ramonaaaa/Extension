using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Extension
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string myString = "My awesome students";
            int wNo = Extensions.WordCount(myString);
            int wordNumberExtension = myString.WordCountExtension();

            var now = DateTime.Now;
            Console.WriteLine(now.RoundToHalfHour());

            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                City = "Iasi",
                Country = "Romania",
                FirstName = "Mihai",
                LastName = "Ramona"

            });

            persons.Add(new Person()
            {
                City = "Roma",
                Country = "Italy",
                FirstName = "Mocanu",
                LastName = "Roxana"

            });

            persons.Add(new Person()
            {
                City = "Bucuresti",
                Country = "Romania",
                FirstName = "Ciobanu",
                LastName = "Maria"

            });

            //anonymous type
            var student = new
            {
                Name = "Student1",
                Course = ".Net"
            };
            Console.WriteLine(student.Course + student.Name);

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            //with linq:
            var personInCity = persons.Where(person => person.City == "Iasi").ToList();

            //varianta clasica:
            var personInCityClass = new List<Person>();
            foreach (var person in persons)
            {
                if (person.City == "Iasi")
                {
                    personInCityClass.Add(person);
                }
            }

            var orderBy = persons.Where(person => person.LastName == "Ramona")
                .OrderBy(x => x.FirstName)
                .OrderBy(x => x.Country.WordCountExtension()).ToList();
        }
                
            
            
        
    }
}
