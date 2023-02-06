namespace HelloMvc.Models;

public class Student
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public DateTime Dob { get; set; }
    public Sex Gender { get; set; } = Sex.Male;
}

public enum Sex
{
    Male = 1,
    Female = 2,
    Others = 3
}
