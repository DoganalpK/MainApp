using MainApp.Application.Enums;
using MainApp.Application.Wrappers;

namespace MainApp.Persistence.Wrappers
{
    public class Response<T> : Response, IResponse<T>
    {
        public T Data { get; set; }
        public List<ICustomValidationError> Errors { get; set; }

        public Response(ResponseType responseType, string message) : base(responseType, message)
        {
        }

        public Response(ResponseType responseType, T data) : base(responseType)
        {
            Data = data;
        }

        public Response(T data, List<ICustomValidationError> errors) : base(ResponseType.ValidationError)
        {
            Errors = errors;
            Data = data;
        }
    }
}
