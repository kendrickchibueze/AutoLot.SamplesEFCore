﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.SamplesDAL.Entities
{
    [Table("InventoryToDrivers", Schema = "dbo")]
    public class CarDriver : BaseEntity
    {
        public int DriverId { get; set; }
        [ForeignKey(nameof(DriverId))]
        public Driver DriverNavigation { get; set; }
        [Column("InventoryId")]
        public int CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car CarNavigation { get; set; }
    }
}
