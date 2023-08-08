using System.Security.Cryptography.X509Certificates;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void CreateFile()
    {
        var newFileAddress = "exportedAccounts.csv";

        using (var fileFlow = new FileStream(newFileAddress, FileMode.Create))
        {
            var accountString = "456, 7895, 4785.40, Gustavo Santos";
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(accountString);

            fileFlow.Write(bytes, 0, bytes.Length);
        }

    }

    static void CreateFileWithWriter()
    {
        var newFileAddress = "exportedAccounts.csv";

        using(var fileFlow = new FileStream(newFileAddress, FileMode.Create))
        using (var writer = new StreamWriter(fileFlow))
        {
            writer.Write("456, 7895, 4785.40, Gustavo Santos");
        }
    }

    static void WriteTest()
    {
        var newFileAddress = "teste.txt";

        using (var fileFlow = new FileStream(newFileAddress, FileMode.Create))
        using (var writer = new StreamWriter(fileFlow))
        {
            for (int i = 0; i < 1000000; i++)
            {
                writer.WriteLine($"Line {i}");
                writer.Flush();//dump the buffer on the stream
                Console.WriteLine($"Line {i} it was written");
                Console.ReadLine();
            }
        }
    }
}