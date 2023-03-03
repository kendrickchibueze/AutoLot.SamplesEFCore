using AutoLot.SamplesDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoLot.SamplesDAL.Entities
{

    [Table("Inventory", Schema = "dbo")]
    [Index(nameof(MakeId), Name = "IX_Inventory_MakeId")]
    [EntityTypeConfiguration(typeof(CarConfiguration))]
    public class Car : BaseEntity
    {
        private string _color;
        [Required, StringLength(50)]
        public string Color
        {
            get => _color;
            set => _color = value;
        }

        [Required, StringLength(50)]
        public string PetName { get; set; }
        public int MakeId { get; set; }

        [ForeignKey(nameof(MakeId))]
        public Make MakeNavigation { get; set; }

        public Radio RadioNavigation { get; set; }

        [InverseProperty(nameof(Driver.Cars))]
        public IEnumerable<Driver> Drivers { get; set; } = new List<Driver>();

        

        private bool? _isDrivable;
        public bool IsDrivable
        {
            get => _isDrivable ?? true;
            set => _isDrivable = value;
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string Display { get; set; }

        //The DatabaseGenerated data annotation is often used in conjunction with the Fluent API to increase  readability of the code


        [InverseProperty(nameof(CarDriver.CarNavigation))]
        public IEnumerable<CarDriver> CarDrivers { get; set; } = new List<CarDriver>();
    }
}



//one-To-Many
//To create a one-to-many relationship, the entity class on the one side (the principal) adds a collection 
//property of the entity class that is on the many side(the dependent). The dependent entity should also have 
//properties for the foreign key back to the principal. If not, EF Core will create shadow foreign key properties, 

//in the Car/Make example, the Car entity is the dependent entity (the many of the one-to-many), and the 
//Make entity is the principal entity (the one of the one-to-many).



//One-To-One
//Since Radio has a foreign key to the Car class (based on convention, covered shortly), Radio is the
//dependent entity, and Car is the principal entity. EF Core creates the required unique index on the foreign 
//key property in the dependent entity implicitly. If you want to change the name of the index, that can be 
//accomplished using data annotations or the Fluent API.