namespace ConsoleApp3.Models;
public class DocumentProgram
{
    public void OpenDocument()
    {
        Console.WriteLine("Document opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
}