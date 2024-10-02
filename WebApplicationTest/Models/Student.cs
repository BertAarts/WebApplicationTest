namespace WebApplicationTest.Models
{
    public class Student
    {
        public Student(string name, string place)
        {
            Name = name;
            Place = place;
        }
    
        public string Name { get;set; }
        public string Place {  get;set; }

    }
}
