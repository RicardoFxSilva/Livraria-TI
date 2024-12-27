using System.Data;
using Microsoft.Extensions.Options;
using Livraria_TI.Models;
using Livraria_TI.Helpers;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Livraria_TI.Services
{
    public class ComprasService
    {
        private readonly MyOptions _myOptions;

        public ComprasService(IOptions<MyOptions> myOptions)
        {
            _myOptions = myOptions.Value;
        }

        public ExecutionResult<List<CompraDTO>> Get(int? Id_Compra = null)
        {
            List<CompraDTO> listc = new List<CompraDTO>();

            DynamicParameters parameters = new DynamicParameters();

            if (Id_Compra != null)
            {
                parameters.Add("@Id_Compra", Id_Compra, DbType.Int32, ParameterDirection.Input);
            }

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                listc = conn.Query<CompraDTO>(Constants.SP_COMPRAS_GET, parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return new ExecutionResultFactory<List<CompraDTO>>().GetSuccessExecutionResult(listc, string.Empty);
        }

        public ExecutionResult<UtilizadorDTO> Insert(UtilizadorDTO dto, string NomeUtilizador)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nome", dto.NomeUtilizador, DbType.String, ParameterDirection.Input);
            parameters.Add("@Email", dto.Email, DbType.String, ParameterDirection.Input);
            parameters.Add("@Password", dto.Password, DbType.String, ParameterDirection.Input);
            parameters.Add("@Morada", dto.Morada, DbType.String, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_UTILIZADORES_INSERT, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<UtilizadorDTO>().GetSuccessExecutionResult(dto, string.Empty);
        }
        public ExecutionResult<UtilizadorDTO> Update(UtilizadorDTO dto, string NomeUtilizador)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id_Utilizador", dto.Id_Utilizador, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@NomeUtilizador", dto.NomeUtilizador, DbType.String, ParameterDirection.Input);
            parameters.Add("@Email", dto.Email, DbType.String, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_UTILIZADORES_UPDATE, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<UtilizadorDTO>().GetSuccessExecutionResult(dto, string.Empty);
        }

        public ExecutionResult<UtilizadorDTO> Delete(int Id_Utilizador)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id_Utilizador", Id_Utilizador, DbType.Int32, ParameterDirection.Input);


            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_UTILIZADORES_DELETE, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<UtilizadorDTO>().GetSuccessExecutionResult(new UtilizadorDTO(), string.Empty);
        }
    }
}
