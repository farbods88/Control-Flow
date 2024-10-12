//while 
int stamina = 100;

Console.WriteLine("Arthur starts running...");

while (stamina > 0)
{
    stamina = stamina - 10;
    Console.WriteLine("Stamina is now : " + stamina);

    if (stamina == 0)
    {
        Console.WriteLine("Arthur is tired.He needs to rest");
    }
}

