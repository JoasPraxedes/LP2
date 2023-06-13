﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato004
{
    class Cidade
    {
        private int idcidade;
        private string nomecidade;
        private string ufcidade;

        public int Idcidade
        {
            get { return idcidade; }
            set { idcidade = value; }
        }

        public string Nomecidade
        {
            get { return nomecidade; }
            set { nomecidade = value; }
        }

        public string Ufcidade
        {
            get { return ufcidade; }
            set { ufcidade = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM CIDADE",
               Form1.conexao);

                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO CIDADE VALUES" + "(@nomecidade, @ufcidade)", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomecidade", SqlDbType.VarChar));

                mycommand.Parameters.Add(new SqlParameter("@ufcidade", SqlDbType.VarChar));

                mycommand.Parameters["@nomecidade"].Value = nomecidade;

                mycommand.Parameters["@ufcidade"].Value = ufcidade;

                retorno = mycommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CIDADE WHERE id_cidade = @id_cidade", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));

                mycommand.Parameters["@id_cidade"].Value = Convert.ToInt16(idcidade);

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE CIDADE SET nome_cidade = @nomecidade ,uf_cidade = @ufcidade WHERE id_cidade = @idcidade", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomecidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@ufcidade", SqlDbType.Char));

                mycommand.Parameters["@idcidade"].Value = idcidade;
                mycommand.Parameters["@nomecidade"].Value = nomecidade;
                mycommand.Parameters["@ufcidade"].Value = ufcidade;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

    }
}

