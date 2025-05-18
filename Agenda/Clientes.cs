using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Clientes
    {
        public string nome, morada, cp, localidade, email;
        public int telefone, contribuinte;
    }

    class Particular : Clientes
    {
    }

    class Empresa : Clientes
    {
        public int cae;
    }

}
