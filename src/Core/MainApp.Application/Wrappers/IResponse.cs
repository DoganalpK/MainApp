using MainApp.Application.Enums;

namespace MainApp.Application.Wrappers
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
