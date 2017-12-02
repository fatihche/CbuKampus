using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SecondHFTez.Core.Entities;

namespace SecondHFTez.Entities.Concrete
{
    public class Location : IEntity
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Address { get; set; }
        [Key,ForeignKey("Product")]
        public int Product_Id { get; set; }

        public Product Product { get; set; }
    }
}