namespace DelegateTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person {Name = "Murad", Surname = "Ganbarov", Age = 19},
                new Person {Name = "Kamil", Surname = "Rasulzade", Age = 19},
                new Person {Name = "Adil", Surname = "Mustafayev", Age = 25},
                new Person {Name = "Sabir", Surname = "Ramazanov", Age = 26},
                new Person {Name = "Vahid", Surname = "Selimzade", Age = 24},

            };

            List<Person> muradlist = people.FindAll(p => p.Name == "Murad");
            Console.WriteLine("\nAdi Murad olanlar:");
            foreach (var person in muradlist)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> kamillist = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("\nAdi Kamil olanlar:");
            foreach (var person in kamillist)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> adillist = people.FindAll(p => p.Name == "Adil");
            Console.WriteLine("\nAdi Adil olanlar:");
            foreach (var person in adillist)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> sabirlist = people.FindAll(p => p.Name == "Sabir");
            Console.WriteLine("\nAdi Murad olanlar:");
            foreach (var person in sabirlist)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> vahidlist = people.FindAll(p => p.Name == "Vahid");
            Console.WriteLine("\nAdi Vahid olanlar:");
            foreach (var person in vahidlist)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> ovSurname = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova") || p.Surname.EndsWith("ev") || p.Surname.EndsWith("eva") );
            Console.WriteLine("\nOv ve ova' ile biten soyadlar");

            foreach(var person in ovSurname)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> ageUpper20 = people.FindAll(p => p.Age >= 20);
            Console.WriteLine("\nYashlari 20'den yuxari olan yada 20 yashi olan telebeler");
            foreach (var person in ageUpper20)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

            List<Person> ageUnder20 = people.FindAll(p => p.Age < 20);
            Console.WriteLine("\nYashlari 20 den ashaqi olan telebeler");
            foreach ( var person in ageUnder20)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }

        }
    }
}