using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{


    public abstract class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}


//Also notice 
//that there isn’t a DbSet<T> property for the BaseEntity class. This is because in the TPH scheme, the entire 
//hierarchy becomes a single table. The properties of the tables up the inheritance chain are folded into the 
//table with the DbSet<T> property