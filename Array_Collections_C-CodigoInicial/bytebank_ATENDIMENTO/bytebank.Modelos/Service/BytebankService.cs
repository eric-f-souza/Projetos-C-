using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebankExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Modelos.Service;
internal class BytebankService
{
#nullable disable
    private List<ContaCorrente> _listAccont = new List<ContaCorrente>()
{
    new ContaCorrente(891) { Saldo = 100, Titular = new Cliente { Cpf="999999999", Nome = "Eric" }},
    new ContaCorrente(891) { Saldo = 110, Titular = new Cliente { Cpf="999999998", Nome = "ALe" }},
    new ContaCorrente(891) { Saldo = 120, Titular = new Cliente { Cpf="999999997", Nome = "Arthur" }},
    new ContaCorrente(894) { Saldo = 130, Titular = new Cliente { Cpf="999999996", Nome = "Aylla" }},
    new ContaCorrente(881) { Saldo = 100, Titular = new Cliente { Cpf="999999980", Nome = "Eric 2" } },
    new ContaCorrente(882) { Saldo = 110, Titular = new Cliente { Cpf="999999981", Nome = "Eric 3" } },
    new ContaCorrente(883) { Saldo = 120, Titular = new Cliente { Cpf="999999982", Nome = "Eric 4" } },
    new ContaCorrente(884) { Saldo = 130, Titular = new Cliente { Cpf="999999983", Nome = "Eric 5" } }
};

    public void ServiceClient()
    {
        try
        {
            char option = '0';
            while (option != '6')
            {
                Console.Clear();
                Console.WriteLine("============================");
                Console.WriteLine("==        Service         ==");
                Console.WriteLine("== 1 - Register Accounts  ==");
                Console.WriteLine("== 2 - Account Lists      ==");
                Console.WriteLine("== 3 - Remove Accounts    ==");
                Console.WriteLine("== 4 - sort Accounts      ==");
                Console.WriteLine("== 5 - Search Accounts    ==");
                Console.WriteLine("== 6 - Log out            ==");
                Console.WriteLine("============================");
                Console.WriteLine("\n\n");
                Console.WriteLine("Enter the desired option:");
                try
                {
                    option = Console.ReadLine()[0];
                    switch (option)
                    {
                        case '1':
                            RegisterAccount();
                            break;
                        case '2':
                            ShowAccounts();
                            break;
                        case '3':
                            DeleteAccount();
                            break;
                        case '4':
                            SortAccount();
                            break;
                        case '5':
                            FindAccount();
                            break;
                        case '6':
                            LogOut();
                            break;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    throw new ByteBankExceptions(e.Message);
                }

            }
        }
        catch (ByteBankExceptions e)
        {
            Console.WriteLine($"{e.Message}");
        }

    }

    void FindAccount()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===      Find Account       ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("1 - Find by the account number: \n" +
                          "2 - Find by CPF\n" +
                          "3 - Find by Agencia\n");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Inform the account number");
                string _accountNumber = Console.ReadLine();

                ContaCorrente accountByAccountNumber = FindAccountByAccountNumber(_accountNumber);
                Console.WriteLine(accountByAccountNumber);

                Console.WriteLine("pres a key to return to menu");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Inform the titular CPF number");
                string _cpf = Console.ReadLine();

                ContaCorrente accountByCpf = FindAccountByCpf(_cpf);
                Console.WriteLine(accountByCpf);

                Console.WriteLine("Pres a key to return to menu");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("Inform the agency number");
                int _agency = int.Parse(Console.ReadLine());

                List<ContaCorrente> accountByAgency = FindAccountByAgency(_agency);
                accountByAgency.ForEach(ac => Console.WriteLine(ac));

                Console.WriteLine("Pres a key to return to menu");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        ServiceClient();
    }

    private List<ContaCorrente> FindAccountByAgency(int agency)
    {
        var account = _listAccont.Where(account => account.NumeroAgencia.Equals(agency)).ToList();//_listAccont.Find(ac => ac.NumeroAgencia.Equals(accountNumber));

        //var account = ( from ac in _listAccont
        //                where ac.NumeroAgencia.Equals(agency)
        //               select ac).ToList();

        if (account != null)
        {
            return account;
        }
        else Console.WriteLine("No account found for agency");

        return null;
    }

    private ContaCorrente FindAccountByCpf(string? cpf)
    {
        var accountByCpf = _listAccont.Where(account => account.Titular.Cpf.Equals(cpf)).FirstOrDefault(); //_listAccont.Find(ac => ac.Titular.Cpf.Equals(cpf));
        if (accountByCpf != null)
        {
            return accountByCpf;
        }
        else Console.WriteLine("Account is not find");

        return null;
    }

    private ContaCorrente FindAccountByAccountNumber(string? accountNumber)
    {
        var account = _listAccont.Where(account => account.Conta.Equals(accountNumber)).FirstOrDefault();//_listAccont.Find(ac => ac.Conta.Equals(accountNumber));
        if (account != null)
        {
            return account;
        }
        else Console.WriteLine("Account is not find");

        return null;
    }

    private void SortAccount()
    {
        _listAccont.Sort();
        Console.WriteLine("The list of accounts has been sorted, pres a key to return to menu");
        Console.ReadKey();
        ServiceClient();
    }

    private void DeleteAccount()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     Remove Accounts     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("Inform the account number: ");
        string accountNumber = Console.ReadLine();

        var account = _listAccont.Find(ac => ac.Conta.Equals(accountNumber));
        if (account != null)
        {
            _listAccont.Remove(account);
            Console.WriteLine("\nAccount Remove, pres a key to return to menu");
        }
        else
        {
            Console.WriteLine("Accont not found, pres a key to return to menu");
        }
        Console.ReadKey();
        ServiceClient();

    }

    private void ShowAccounts()
    {
        Console.Clear();
        Console.WriteLine("============================");
        Console.WriteLine("==    Account account     ==");
        Console.WriteLine("============================");
        if (_listAccont.Count <= 0)
        {
            Console.WriteLine("No account register, pres a key to return to menu");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente account in _listAccont)
        {
            Console.WriteLine(account.ToString());
        }

        Console.WriteLine("End accounts, pres a key to return to menu");
        Console.ReadKey();
        return;
    }

    private void RegisterAccount()
    {
        Console.Clear();
        Console.WriteLine("============================");
        Console.WriteLine("==    Register account    ==");
        Console.WriteLine("============================");
        Console.WriteLine("\nAgency thar the account will be created?");
        var newAccount = new ContaCorrente(int.Parse(Console.ReadLine()));

        Console.WriteLine("\nOpening account balance?");
        newAccount.Saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("\nWhat is the owner's name?");
        newAccount.Titular.Nome = Console.ReadLine();

        Console.WriteLine("\nWhat is the owner's profession?");
        newAccount.Titular.Profissao = Console.ReadLine();

        _listAccont.Add(newAccount);
        Console.WriteLine($"Successfully registered account, account number: {newAccount.Conta}, pres a key to return to menu");
        Console.ReadKey();
        ServiceClient();

    }

    private void LogOut()
    {
        Console.WriteLine("Finish program");
        Console.ReadKey();
    }



}
