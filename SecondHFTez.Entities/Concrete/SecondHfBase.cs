using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHFTez.Entities.Concrete
{
    public class SecondHfBase
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public string ModifiedUserName { get; set; }

    }
}
