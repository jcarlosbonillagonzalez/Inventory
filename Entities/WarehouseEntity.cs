using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        public int WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        [Required]
        [StringLength(100)]
        public string WarehouseAddress { get; set; }

        public int StorageId { get; set; }
        //Relacion con almacenamiento
        public ICollection<StorageEntity> storages { get; set; }
    }
}
