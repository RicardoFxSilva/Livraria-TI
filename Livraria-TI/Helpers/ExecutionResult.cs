namespace Livraria_TI.Helpers
{
    public class ExecutionResult<T>
    {

        public bool Status { get; set; }

        public T Results { get; set; }

        public List<string>? Message { get; set; }

    }
}
