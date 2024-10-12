// If-Else statements

int playerHealth = 20;
int tonicNumber = 0;

if (playerHealth <= 20 && tonicNumber > 0)
{
    tonicNumber--;
    playerHealth = playerHealth + 30;
    Console.WriteLine ("Tonic consumed. Health is now : " + playerHealth);
}

else if (playerHealth > 20)
{
    Console.WriteLine ("No tonics needed");
}

else 
{
    Console.WriteLine ("Arthur is in need of a tonic but none is left");
}
