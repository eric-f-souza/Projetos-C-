using System.Security.Cryptography.X509Certificates;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void BinaryStream()
    {

        using (var fileFlow = new FileStream("current_account.txt", FileMode.Create))
        using (var writer = new BinaryWriter(fileFlow))
        {
            writer.Write(456);
            writer.Write(456544);
            writer.Write(4000.50);
            writer.Write("Gustavo Braga");
        }

    }

    static void BinaryRead()
    {
        using (var fileFlow = new FileStream("current_account.txt", FileMode.Open))
        using (var reader = new BinaryReader(fileFlow))
        {
            var agency = reader.ReadInt32();
            var account = reader.ReadInt32();
            var curent = reader.ReadDouble();
            var holder = reader.ReadString();

            Console.WriteLine($"{holder} -> Agency: {agency}, Number account: {account}, curent: {curent}");
        }
    }
}