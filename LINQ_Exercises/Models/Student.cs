namespace LINQ_Exercises.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public string Department { get; set; }

        public override string ToString() => $"{Name} (Age: {Age}, Grade: {Grade}, Dept: {Department})";
    }
}
