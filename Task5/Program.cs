
class Program
{
    static void Main(string[] args)
    {
        
        DateTime birthDate = new DateTime(1998, 6, 10); 

        DateTime currentDate = DateTime.Now;
        
        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365);
        
        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate);
        Console.WriteLine("Age in Years: " + ageInYears);
        
        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
    }
}