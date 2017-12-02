using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Product : SecondHfBase, IEntity
    {
        public string Details { get; set; }
        public int ViewCount { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }


        public int Owner_Id { get; set; }
        public int Category_Id { get; set; }
        public int City_Id { get; set; }
        public int County_Id { get; set; }
    }
}