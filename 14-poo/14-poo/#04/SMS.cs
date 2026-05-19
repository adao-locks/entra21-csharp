using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_poo
{
    class SMS : Notificacao
    {
        public SMS(string mensagem) : base(mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"📱 SMS enviado: {Mensagem}");
        }
    }
}
