using ConsoleApp3;
using ConsoleApp3.Models;

string[] arr = new string[4] { "basic", "pro", "expert", "exit" };
int select = 0;
while (true)
{
    Console.Clear();
    for (int i = 0; i < 4; i++)
        if (i == select)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(arr[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
            Console.WriteLine(arr[i]);

    ConsoleKeyInfo key = Console.ReadKey();

    if (key.Key == ConsoleKey.DownArrow)
    {
        select++;
        if (select == 4)
            select = 0;
    }

    else if (key.Key == ConsoleKey.UpArrow)
    {
        select--;
        if (select == -1)
            select = 3;
    }

    else if (key.Key == ConsoleKey.Enter)
    {
        DocumentProgram docProgram;
        if (select == 0)
            docProgram = new DocumentProgram();

        else if (select == 1)
            docProgram = new ProDocumentProgram();

        else if (select == 2)
            docProgram = new ExpertDocument();

        else break;
        Console.WriteLine();
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
        _ = Console.ReadKey();
    }
    else if (key.Key == ConsoleKey.Escape) break;
}
