namespace MainApp.Application.Wrappers
{
    public class CustomValidationError : ICustomValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
