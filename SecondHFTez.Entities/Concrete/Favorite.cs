using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Favorite : IEntity
    {
        public int Id { get; set; }

        public int User_Id { get; set; }
        public int Product_Id { get; set; }
    }
}