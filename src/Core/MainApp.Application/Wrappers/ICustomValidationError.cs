namespace MainApp.Application.Wrappers
{
    public interface ICustomValidationError
    {
        string PropertyName { get; set; }
        string ErrorMessage { get; set; }
    }
}
