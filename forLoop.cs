//for loop 

int maxBullets = 7;
int currentBullet = 1;

Console.WriteLine ("Reloading Revolver...");

for (int i = currentBullet; i < maxBullets; i++)
{
 Console.WriteLine ("Currently loaded ammo : " + (i + 1));
 if (i == 6) 
 {
  Console.WriteLine ("Revolver Fully Reloaded");
 }
}
