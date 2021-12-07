using System.Diagnostics;


static bool execute()
{
    Process.Start(@"\Users\\" + Environment.UserName + "\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe");
    Console.WriteLine("Execute VSCode..");
    Thread.Sleep(1500);
    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
    Thread.Sleep(1500);
    return true;
}

static string start()
{
    Console.WriteLine("Hello, World!");
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
    string winpath = Environment.GetEnvironmentVariable("windir");
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
    if (winpath != null)
    {
        execute();
    }
    else
    {
        Thread.Sleep(1000);
        Process.Start(@"");
    }
    return "";
}
start();