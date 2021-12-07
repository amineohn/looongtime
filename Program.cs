using System.Diagnostics;


static bool execute(bool start)
{
    Process.Start(@"\Users\\" + Environment.UserName + "\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe");
    Console.WriteLine("Execute VSCode..");
    Thread.Sleep(1500);
    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
    Console.WriteLine("Execute Chrome..");
    Environment.Exit(0);
    Thread.Sleep(1500);
    return start;
}

static string start()
{
    string? winpath = Environment.GetEnvironmentVariable("windir");
    if (winpath != null)
    {
        execute(true);
    }
    else
    {
        Thread.Sleep(1000);
        Process.Start(@"");
    }
    return "";
}
start();