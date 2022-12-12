using System.Collections.Generic;

namespace LambdaExpressionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecord(listPersonInCity);
            Retrieving_TopTwoRecord_ForAgeIsLessThan60(listPersonInCity);
            Retrieving_TeenSgePerson(listPersonInCity);


        }
        /// <summary>
        /// Uc1
        /// </summary>
        /// <param name="listPersonInCity"></param>
        private static void AddRecord(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person(1, "Snehal", "plot no 12,sindewahi" ,24));
            listPersonInCity.Add(new Person(2, "Raju", "plot no 13,sindewahi", 68));
            listPersonInCity.Add(new Person(3, "Mayur", "plot no 9,sindewahi", 20));
            listPersonInCity.Add(new Person(4, "Vaibhav", "plot no 28,sindewahi", 17));
            listPersonInCity.Add(new Person(5, "Lata", "plot no 89,sindewahi", 62));
            listPersonInCity.Add(new Person(6, "Anu", "plot no 57,sindewahi", 80));
            listPersonInCity.Add(new Person(7, "Mayur", "plot no 29,sindewahi", 9));
            listPersonInCity.Add(new Person(8, "Bharti", "plot no 10,sindewahi", 45));
            Display(listPersonInCity);
           
        }
        private static void Display(List<Person> listPersonInCity)
        {
            foreach (Person data in listPersonInCity)
            {
                Console.WriteLine("Id person :"+data.Id+"\n Name : "+data.Name+"\n address :"+data.Address+"\n Age: "+data.Age+"\n");
            }
        }
        /// <summary>
        /// Uc2
        /// </summary>
        /// <param name="listPersonInCity"></param>
        private static void Retrieving_TopTwoRecord_ForAgeIsLessThan60(List<Person> listPersonInCity)
        {
            var personList = listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList();
            Display(personList);
        }
        /// <summary>
        /// uc3
        /// </summary>
        /// <param name="listPersonInCity"></param>
        private static void Retrieving_TeenSgePerson(List<Person> listPersonInCity)
        {
            if(listPersonInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("Yes, WE have some TEEN_AGE IN THE LIST");
            }
            
        }

    }
}