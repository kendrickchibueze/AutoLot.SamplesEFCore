using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.SamplesDAL.Entities
{

//    With this in place, we can replace the FirstName and LastName properties on the Driver class with the
//new Person class:



    [Table("Drivers", Schema = "dbo")]
    [EntityTypeConfiguration(typeof(DriverConfiguration))]
    public class Driver : BaseEntity
    {

        public Person PersonInfo { get; set; } = new Person();
       
        
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

        [InverseProperty(nameof(CarDriver.DriverNavigation))]
        public IEnumerable<CarDriver> CarDrivers { get; set; } = new List<CarDriver>();
    }
}



//In many-to-many relationships, both entities have a collection navigation property to the other entity. This 
//is implemented in the data store with a join table in between the two entity tables. This join table, by default,
//is named after the two tables using < Entity1Entity2 >, but can be changed programmatically through the 
//Fluent API. The join entity has one-to-many relationships to each of the entity tables.


//many-To-Many relationship exists between the car and car drivers
