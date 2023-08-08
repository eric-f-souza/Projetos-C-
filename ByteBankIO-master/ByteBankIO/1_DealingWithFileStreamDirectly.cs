using System.Text;

partial class Program
{
    static void DealingWithFileStreamDitectly(string[] args)
    {
        var fileAddress = "contas2.0.txt";

        using (var fileStream = new FileStream(fileAddress, FileMode.Open))
        {
            var numberOfBytesRead = -1;

            var buffer = new byte[1024];//1kb

            while (numberOfBytesRead != 0)
            {
                numberOfBytesRead = fileStream.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numberOfBytesRead}");
                ToWriteBuffer(buffer, numberOfBytesRead);
            }

            fileStream.Read(buffer, 0, 1024);


            fileStream.Close();

            Console.ReadLine();
        }

        static void ToWriteBuffer(byte[] buffer, int bytesRead)
        {
            var utf8 = new UTF8Encoding();

            //foreach (var myByte in buffer)
            //{
            //    Console.Write(myByte);
            //    Console.Write(" ");
            //}

            var text = utf8.GetString(buffer, 0, bytesRead);

            //public virtual string GetString(byte[] bytes, int index, int count);
            Console.Write(text);
        }
    }

}