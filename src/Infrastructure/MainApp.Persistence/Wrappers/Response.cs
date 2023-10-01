using MainApp.Application.Enums;
using MainApp.Application.Wrappers;

namespace MainApp.Persistence.Wrappers
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }

        public ResponseType ResponseType { get; set; }
        public string Message { get; set; }
    }
}
