using System.Security.Cryptography.X509Certificates;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("contas2.0.txt");
        Console.WriteLine(lines.Length);

        /*
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
        */

        var fileBytes = File.ReadAllBytes("contas2.0.txt");
        Console.WriteLine($"File with {fileBytes.Length} bytes");

        File.WriteAllText("writeWithClassFile.txt", "Test with Write class");

        Console.WriteLine("Finish");
    }
}