using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Comment : SecondHfBase, IEntity
    {
        public string CContent { get; set; }

        public int Owner_Id { get; set; }
        public int Product_Id { get; set; }
    }
}