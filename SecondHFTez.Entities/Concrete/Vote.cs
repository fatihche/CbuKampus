using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Vote : IEntity
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public int Owner_Id { get; set; }
        public int Product_Id { get; set; }

    }
}