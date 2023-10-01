namespace MainApp.Application.Wrappers
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; set; }
        List<ICustomValidationError> Errors { get; set; }
    }
}
