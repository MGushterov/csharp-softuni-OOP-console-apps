namespace BirthdayCelebrations.Models
{
    using Interfaces;
    public class Person : IIdentifiable, IBirthable
    {
        public Person(string name, string id, int age, string birthdate)
        {
            Name = name;
            Id = id;
            Age = age;
            Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }
    }
}
