using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace RestauranteVotacao.Models
{
    public class Colaborador
    {
        #region Variáveis públicas e privadas.
        private static List<Colaborador> Colaboradores;
        private static Colaborador colaborador;
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        
        #endregion
        
        #region Entrada de dados do Colaborador.
        static Colaborador()
        {
            // 1. Criam-se 5 colaboradores fictícios, já que não existe banco de dados.
            Colaborador colaborador1 = new Colaborador(
                "1000", 
                "Colaborador Um", 
                "colaborador1@gmail.com", 
                ObterSenha("senha1"));
            
            // 2. Coloca-se estes 5 colabores numa lista.
            Colaboradores = new List<Colaborador>();
            Colaboradores.Add(colaborador1);
            
        }
        #endregion
        
        #region Criptografia da senha.
        public static string ObterSenha(string senha)
        {
            // Apenas faz um Hash da senha usando o MD5. 
            HashAlgorithm hash =  MD5.Create();
            return System.Convert.ToBase64String(hash.ComputeHash(Encoding.UTF8.GetBytes(senha)));
        }
        #endregion

        #region Autenticação do colaborador.
        public static RestauranteVotacao.Models.Colaborador Autenticar(string username, string password)
        {
            if (IsValid("Admin", "admin123"))
                return colaborador;

            // Busca-se pelo e-mail e senha do colaborador.
            //RestauranteVotacao.Models.Colaborador colaborador = RestauranteVotacao.Models.Colaborador.ObterTodosColaboradores().Find(
            //    c => c.Email.Equals(username)
            //        && c.Senha.Equals(ObterSenha(password)));

            return colaborador;
        }
        #endregion

        #region Contrutor do Colaborador.
        public Colaborador(string id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        #endregion

        #region Método público para buscar todos os colaboradores.
        public static List<Colaborador> ObterTodosColaboradores()
        {
            return Colaboradores;
        }
        #endregion

        #region Valida Usuário
        public static bool IsValid(string username, string password)
        {
            using (var cn = new SqlConnection(
                @"Data Source=(LocalDB)\v11.0;
                AttachDbFilename='C:\Cursos\DB Server\Teste-DBServer\RestauranteVotacao\App_Data\Database.mdf';
                Integrated Security=True"))
            {
                string _sql = @"SELECT *  FROM [dbo].[User] WHERE [Name] = @usr AND [Password] = @pwd";
                
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@usr", SqlDbType.NVarChar))
                    .Value = username;
                cmd.Parameters
                    .Add(new SqlParameter("@pwd", SqlDbType.NVarChar))
                    .Value = Helpers.MD5.Encode(password);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read()) { 
                    // Carrego o objeto Colaborador com o resultado do select para usar mais tarde.
                            colaborador = new Colaborador(
                            reader.GetValue(2).ToString(),
                            reader.GetValue(1).ToString(),
                            reader.GetValue(0).ToString(),
                            reader.GetValue(3).ToString());
                    }

                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
        #endregion
    }
}