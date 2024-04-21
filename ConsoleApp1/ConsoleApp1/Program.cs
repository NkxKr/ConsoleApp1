Console.WriteLine("Cześć Nikodem");

string name = "Nikodem";
string gender = "men";
int age = 21;

if (gender == "women")
{
    if (age ==30)
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa lat 30");
        }
    }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niedotyczy");
}