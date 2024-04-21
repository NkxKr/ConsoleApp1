string name = "Nikodem";
string gender = "Men";
int age = 21;

if (gender == "Women")
{
    if (age < 30)
    {
        if (name == "Ewa" && age == 30)
        {
            Console.WriteLine("Ewa lat 30");
        }
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else
    if (gender == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Niedotyczy");
}
