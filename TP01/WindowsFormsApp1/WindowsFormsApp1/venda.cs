using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Venda
    {
        private static float total;
        private static float ano;

        public static void setTotal(float _total) { total = _total; }
        public static void setAno(float _ano) { ano = _ano; }

        public static float getTotal() { return total; }
        public static float getAno() { return ano; }
    }
}
