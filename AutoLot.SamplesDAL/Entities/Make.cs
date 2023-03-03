using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{
   

    [Table("Makes", Schema = "dbo")]
    public class Make : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Car.MakeNavigation))]
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}
