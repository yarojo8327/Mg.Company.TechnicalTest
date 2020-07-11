namespace Mg.Company.Application.WebApi.Models
{
    public class ResponseModel<T> 
    {
        public bool IsSuccess { get; set; }
        public string Messages { get; set; }
        public T Result { get; set; }
    }
}
