using Model.Entidades;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace mapasala.DAO
{
    public class ProfessorDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores "
        }
       
        
    }
}
