using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var fileAddress = "contas.txt";
        var numberOfBytesRead = -1;

        var fileStream = new FileStream(fileAddress, FileMode.Open);

        var buffer = new byte[1024];//1kb

        while (numberOfBytesRead != 0)
        {
            numberOfBytesRead = fileStream.Read(buffer, 0, 1024);
            ReadingBuffer(buffer);
        }

        fileStream.Read(buffer, 0, 1024);

        
        Console.ReadLine();
    }

    static void ReadingBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        //foreach (var myByte in buffer)
        //{
        //    Console.Write(myByte);
        //    Console.Write(" ");
        //}
        var text = utf8.GetString(buffer);
        Console.Write(text);
    }
}