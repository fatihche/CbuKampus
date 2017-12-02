using System.Collections.Generic;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class SecondHfRole : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }

    }
}