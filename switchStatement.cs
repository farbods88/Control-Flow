//Switch statement

string missionStatus = "failed";

switch (missionStatus)
{
    case "in progress":
        Console.WriteLine("Mission is still in progress.");
        break;
    case "completed":
        Console.WriteLine("Mission is completed! Return to the camp for your reward.");
        break;
    case "failed":
        Console.WriteLine("Mission failed. You're dead.");
        break;
    default:
        Console.WriteLine("Unknown mission status");
        break;
}
