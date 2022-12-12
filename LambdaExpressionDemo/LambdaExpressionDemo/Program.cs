namespace LambdaExpressionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            AddRecord(listPersonInCity);
            
        }
        //uc1
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

        
        

    }
}