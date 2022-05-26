string instructorName = "Kat";
string[] instructors = new string[] {"Michael", "Joshua", instructorName};

foreach (string name in instructors)
{
    Console.WriteLine(name);
}