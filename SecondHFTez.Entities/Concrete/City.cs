using System.Collections.Generic;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class City : SecondHfBase, IEntity
    {
        public string Name { get; set; }
        public int PostCode { get; set; }
    }
}