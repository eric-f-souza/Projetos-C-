using System.Security.Cryptography.X509Certificates;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void UseInputStream()
    {

        using(var fileFlow = Console.OpenStandardInput())
        using(var fs = new FileStream("ConsoleInput.txt", FileMode.Create))
        {
            var buffer = new byte[1024];//1kb

            while (true)
            {
                var readBytes = fileFlow.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, readBytes);
                fs.Flush();
                Console.WriteLine($"Read Bytes {readBytes}");
            }

        }

    }
}