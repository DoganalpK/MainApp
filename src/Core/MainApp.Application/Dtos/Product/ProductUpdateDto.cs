using MainApp.Application.Interfaces.Dtos;

namespace MainApp.Application.Dtos.Product
{
    public class ProductUpdateDto : IUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Value { get; set; }
    }
}
