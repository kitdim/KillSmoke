using KillSmokeConsoleaApp.Main;

Console.WriteLine("The KillSmoke shows the number of days without cigarettes.\n");
Console.WriteLine("Statistics for today:");

Console.Write("\n\nDid you smoke today?(Yes|Not): ");
var answer = Console.ReadLine().ToLower();

switch (answer)
{
    case "yes": 
        //TODO Сделать обнуление дней без сигарет
        break;
    case "not":
        SetSmoke();
        break;
    default:
        Console.WriteLine("Error");
        break;
}

void SetSmoke()
{
    var countCig = Load.Loading();
    var myCig = new Smoke(countCig);

    myCig.ShowSmokeInfo();
}

Console.ReadLine();