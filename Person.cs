namespace Comparer
{
    public class Person{
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}