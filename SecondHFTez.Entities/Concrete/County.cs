using System.Collections.Generic;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class County : SecondHfBase, IEntity
    {
        public string Name { get; set; }

        public int City_Id { get; set; }
    }
}