using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Models.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Active = true;
            Deleted = false;
        }
        [Key]
        public Guid Id { get; private set; }

        public bool Active { get; private set; }
        public bool Deleted { get; private set; }

        public void Activate() => Active = true;
        public void Deactivate() => Active = false;
        public void Delete() => Deleted = true;
        public void Undelete() => Deleted = false;
    }
}
