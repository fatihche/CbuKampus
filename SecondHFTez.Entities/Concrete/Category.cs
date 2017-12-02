using System.Collections.Generic;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Category : SecondHfBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}