namespace MainApp.Domain.Entities
{
    public class Product : MainApp.Domain.Common.BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Value { get; set; }
    }
}
