using System.Security.Cryptography.X509Certificates;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void UseStreamReader(string[] args)
    {
        var fileAddress = "contas2.0.txt";
        using (var fileStream = new FileStream(fileAddress, FileMode.Open))
        {
            var reader = new StreamReader(fileStream);

            //var line = reader.ReadLine();
            //var text = reader.ReadToEnd();
            //var number = reader.Read();

            while (!reader.EndOfStream  )
            {
                var line = reader.ReadLine();
                var currentAccount = ConvertStringToCurrentAccount(line);


                Console.WriteLine($"{currentAccount.Titular.Nome} = Accont number: {currentAccount.Numero}, Agency: {currentAccount.Agencia}, balance {currentAccount.Saldo}");
            }

            fileStream.Close();
        }
    }

    static ContaCorrente ConvertStringToCurrentAccount(string line)
    {
        var fields = line.Split(',');
        var agencyString = fields[0];
        var numberString = fields[1];
        var balanceString = fields[2].Replace('.',',');
        Console.WriteLine(balanceString);
        var holderString = fields[3];

        var agency = int.Parse(agencyString);
        var number = int.Parse(numberString);
        var balance = double.Parse(balanceString);
        var holder = new Cliente();
        holder.Nome = holderString;


        var result = new ContaCorrente(agency, number);
        result.Depositar(balance);
        result.Titular = holder;
        return result;
    }
}