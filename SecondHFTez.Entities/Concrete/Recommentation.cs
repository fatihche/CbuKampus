using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Recommentation : SecondHfBase, IEntity
    {
        public string RContent { get; set; }
        public int Owner_Id { get; set; }
    }
}