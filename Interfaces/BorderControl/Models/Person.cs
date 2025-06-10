namespace BorderControl.Models
{
    using Interfaces;
    public class Person : IIdentifiable
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
