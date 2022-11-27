namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class BaseVO
    {
        public BaseVO()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
