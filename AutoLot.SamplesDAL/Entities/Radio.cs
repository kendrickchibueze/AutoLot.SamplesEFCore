using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{
    [Table("Radios", Schema = "dbo")]
    [EntityTypeConfiguration(typeof(RadioConfiguration))]
    public class Radio : BaseEntity
    {
        public bool HasTweeters { get; set; }
        public bool HasSubWoofers { get; set; }

        [Required, StringLength(50)]
        public string RadioId { get; set; }

        [Column("InventoryId")]
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car CarNavigation { get; set; }
    }
}


//In one-to-one relationships, both entities have a reference navigation property to the other entity. While 
//one-to-many relationships clearly denote the principal and dependent entity, when building one-to-one 
//relationships, EF Core must be informed which side is the principal entity. This can be done either by having
//a clearly defined foreign key to the principal entity or by indicating the principal using the Fluent API.If
//EF Core is not informed through one of those two methods, it will choose one based on its ability to detect 
//a foreign key. In practice, you should clearly define the dependent by adding foreign key properties. This 
//removes any ambiguity and ensures that your tables are properly configured.


//. Note that in a one-to-one relationship, only the dependent entity has a foreign key.
