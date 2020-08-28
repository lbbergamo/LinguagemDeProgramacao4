using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Prova
{
    class DAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDFarinha.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void consultaUmCliente(string cliente)
        {
            String aux = "SELECT * FROM TabClientes A,TabVendasCliente B WHERE A.CNPJ = '" + cliente + "' AND A.CNPJ = B.CNPJ";
            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
        }

        public static void getProximo()
        {
            Erro.setErro(false);
            if (result.Read())
            {
                Cliente.setCNPJ(result.GetString(0));
                Cliente.setNome(result.GetString(1));
                //VendaCliente.setCodigo(result.GetString(2));
                VendaCliente.setData(result.GetString(4));
                VendaCliente.setToneladas(result.GetString(5));
                VendaCliente.setvalor(result.GetString(6));
            }
            else
                Erro.setErro(true);
        }

    }
}
