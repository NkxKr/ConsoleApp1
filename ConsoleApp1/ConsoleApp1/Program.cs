Console.WriteLine("Cześć Nikodem");

string name = "Nikodem";
string gender = "men";
int age = 21;

if (gender == "women" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (gender == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyna");
}