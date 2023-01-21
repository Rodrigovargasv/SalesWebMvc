namespace SalesWebMvc.Models.Services.Exceptions
{
    public class NotFoundExecption : ApplicationException
    {
          public NotFoundExecption(string menssage) : base(menssage) { }
    }
}
