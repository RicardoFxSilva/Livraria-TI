using System.Data;
using Microsoft.Extensions.Options;
using Livraria_TI.Models;
using Livraria_TI.Helpers;


namespace Livraria_TI.Services
{
    public class UtilizadorService
    {
        private readonly MyOptions _myOptions;

        public UtilizadorService(IOptions<MyOptions> myOptions)
        {
            _myOptions = myOptions.Value;
        }

        public ExecutionResult<List<UtilizadorDTO>> Get(int? idCliente = null)
        {
            List<UtilizadorDTO> listc = new List<UtilizadorDTO>();

            DynamicParameters parameters = new DynamicParameters();

            if (Id_Utilizador != null)
            {
                parameters.Add("@Id_Utilizador ", Id_Utilizador, DbType.Int32, ParameterDirection.Input);
            }

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                listc = conn.Query<UtilizadorDTO>(Constants.SP_CLIENTE_GET, parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return new ExecutionResultFactory<List<UtilizadorDTO>>().GetSuccessExecutionResult(listc, string.Empty);
        }

        public ExecutionResult<UtilizadorDTO> Insert(UtilizadorDTO dto, string user)
        {
            int result;

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nome", dto.Nome, DbType.String, ParameterDirection.Input);
            parameters.Add("@Email", dto.Email, DbType.String, ParameterDirection.Input);

            using (IDbConnection conn = new SqlConnection(_myOptions.ConnString))
            {
                result = conn.Execute(Constants.SP_CLIENTE_INSERT, parameters, commandType: CommandType.StoredProcedure);
            }

            return new ExecutionResultFactory<UtilizadorDTO>().GetSuccessExecutionResult(dto, string.Empty);
        }
    }
}

