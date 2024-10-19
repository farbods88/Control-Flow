
string[] NPCs = { "Dutch", "John", "Sadie", "Jack" };

foreach (string member in NPCs)
{
    if (member == "Dutch")
    {
        Console.WriteLine("Arthur talks to Dutch about the plan.");
    }
    else if (member == "John")
    {
        Console.WriteLine("Arthur shares a drink with John.");
    }
    else if (member == "Sadie")
    {
        Console.WriteLine("Arthur discusses bounty hunting with Sadie.");
    }
    else
    {
        Console.WriteLine("Arthur takes Jack fishing.");
    }
}
