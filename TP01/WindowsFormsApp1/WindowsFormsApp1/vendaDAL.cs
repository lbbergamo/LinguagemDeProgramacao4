using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class VendaDAL
    {

        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDVendas.mdb";
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
                Erro.setMsg("Banco da Dados não localizado - contacte o suporte.");
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }


        public static void populaDR()
        {
            String aux = "select * from TabVendasAno";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
        }

        public static void getProximo()
        {
            Erro.setErro(false);
            if (result.Read())
            {
                Venda.setAno(result.GetInt32(0));
                Venda.setTotal(result.GetInt32(1));
            }
            else
                Erro.setErro(true);
        }



    }
}
