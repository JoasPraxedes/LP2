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
    class Contato
    {
        private int idcontato;
        private string nomecontato;
        private string endcontato;
        private int cidadeidcidade;
        private string celcontato;
        private string emailcontato;
        private DateTime dtcadastrocontato;

        public int Idcontato { get => idcontato; set => idcontato = value; }
        public string Nomecontato { get => nomecontato; set => nomecontato = value; }
        public string Endcontato { get => endcontato; set => endcontato = value; }
        public int Cidadeidcidade { get => cidadeidcidade; set => cidadeidcidade = value; }
        public string Celcontato { get => celcontato; set => celcontato = value; }
        public string Emailcontato { get => emailcontato; set => emailcontato = value; }
        public DateTime Dtcadastrocontato { get => dtcadastrocontato; set => dtcadastrocontato = value; }

        public DataTable Listar()
        {
            SqlDataAdapter daContato;
            DataTable dtContato = new DataTable();

            try
            {
                daContato = new SqlDataAdapter("SELECT * FROM CONTATO", Form1.conexao);
                daContato.Fill(dtContato);
                daContato.FillSchema(dtContato, SchemaType.Source);

            }
            catch(Exception)
            {
                throw;
            }
            return dtContato;
        }

        public int Salvar()//inclusao
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO CONTATO VALUES  (@nomecontato,@endcontato,@cidadeidcidade,@celcontato,@emailcontato,@dtcadastrocontato)", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));

                mycommand.Parameters["@nomecontato"].Value = Nomecontato;
                mycommand.Parameters["@endcontato"].Value = Endcontato;
                mycommand.Parameters["@cidadeidcidade"].Value = Cidadeidcidade;
                mycommand.Parameters["@celcontato"].Value = Celcontato;
                mycommand.Parameters["@emailcontato"].Value = Emailcontato;
                mycommand.Parameters["@dtcadastrocontato"].Value = Dtcadastrocontato;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw ;
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CONTATO WHERE id_contato = @idcontato", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));

                mycommand.Parameters["@idcontato"].Value = Convert.ToInt16(Idcontato);

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
                mycommand = new SqlCommand("UPDATE CONTATO SET nome_contato = @nomecontato ,end_contato = @endcontato, cidade_id_cidade = @cidadeidcidade,cel_contato=@celcontato,email_contato = @emailcontato,dtcadastro_contato=@dtcadastrocontato WHERE id_contato = @idcontato", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));

                mycommand.Parameters["@idcontato"].Value = Idcontato;
                mycommand.Parameters["@nomecontato"].Value = Nomecontato;
                mycommand.Parameters["@endcontato"].Value = Endcontato;
                mycommand.Parameters["@cidadeidcidade"].Value = Cidadeidcidade;
                mycommand.Parameters["@celcontato"].Value = Celcontato;
                mycommand.Parameters["@emailcontato"].Value = Emailcontato;
                mycommand.Parameters["@dtcadastrocontato"].Value = Dtcadastrocontato;

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
