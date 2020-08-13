using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class VendaBLL
    {
        public static void conecta()
        {
            VendaDAL.conecta();
            if (!Erro.getErro())
            {
                VendaDAL.populaDR();
            }
        }

        public static void desconecta()
        {
            VendaDAL.desconecta();
        }

        public static void getProximo()
        {
            VendaDAL.getProximo();
        }

    }
}
