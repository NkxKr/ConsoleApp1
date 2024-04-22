Console.WriteLine("Cześć Nikodem");

string name = "Nikodem";
string gender = "men";
var age = 21;

if (gender == "women" && name == "Ewa")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej lat 30");
    }
    else if (age == 30)
    {
        Console.WriteLine("Ewa lat 30");
    }
}
else if (gender == "men")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niedotyczy");
    }
}
