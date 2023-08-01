using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebankExceptions;

public class ByteBankExceptions : Exception
{
    public ByteBankExceptions()
    {
    }

    public ByteBankExceptions(string message) : base("Exception here -> " + message)
    {
    }

    public ByteBankExceptions(string message, Exception inner) : base(message, inner)
    {
    }
}
