namespace FoodShortage.Models
{
    using Interfaces;
    public class Person : IIdentifiable, IBirthable, IHuman
    {
        public Person(string name, int age, string id, string birthdate)
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

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
