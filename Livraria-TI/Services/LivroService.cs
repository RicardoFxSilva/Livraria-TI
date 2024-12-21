using System.Data;
using Microsoft.Extensions.Options;
using Livraria_TI.Models;
using Livraria_TI.Helpers;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Livraria_TI.Services
{
    public class LivroService
    {
        private readonly MyOptions _myOptions;

        public LivroService(IOptions<MyOptions> myOptions)
        {
            _myOptions = myOptions.Value;
        }

        public ExecutionResult<List<LivroDTO>> Get(int? Id_Livro = null)
        {
            List<LivroDTO> listc = new List<LivroDTO>();

            DynamicParameters parameters = new DynamicParameters();

            if (Id_Livro  != null)
            {
                parameters.Add("@Id_Livro", Id_Livro , DbType.Int32, ParameterDirection.Input);
            }

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                listc = conn.Query<LivroDTO>(Constants.SP_LIVRO_GET, parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return new ExecutionResultFactory<List<LivroDTO>>().GetSuccessExecutionResult(listc, string.Empty);
        }

        public ExecutionResult<LivroDTO> Insert(LivroDTO dto, string Titulo)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Titulo", dto.Titulo, DbType.String, ParameterDirection.Input);
            parameters.Add("@Preco", dto.Preco, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@Descricao", dto.Descricao, DbType.String, ParameterDirection.Input);
            parameters.Add("@Capa", dto.Capa, DbType.String, ParameterDirection.Input);
            parameters.Add("@Editora", dto.Editora, DbType.String, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_LIVRO_INSERT, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<LivroDTO>().GetSuccessExecutionResult(dto, string.Empty);
        }
        public ExecutionResult<LivroDTO> Update(LivroDTO dto, string Titulo)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Titulo", dto.Titulo, DbType.String, ParameterDirection.Input);
            parameters.Add("@Preco", dto.Preco, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("@Descricao", dto.Descricao, DbType.String, ParameterDirection.Input);
            parameters.Add("@Capa", dto.Capa, DbType.String, ParameterDirection.Input);
            parameters.Add("@Editora", dto.Editora, DbType.String, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_LIVRO_UPDATE, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<LivroDTO>().GetSuccessExecutionResult(dto, string.Empty);
        }

        public ExecutionResult<LivroDTO> Delete(int Id_Livro)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id_Livro", Id_Livro , DbType.Int32, ParameterDirection.Input);


            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_LIVRO_DELETE, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<LivroDTO>().GetSuccessExecutionResult(new LivroDTO(), string.Empty);
        }
    }
}