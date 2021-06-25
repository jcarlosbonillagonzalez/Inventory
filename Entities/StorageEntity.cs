using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        public int StorageId { get; set; }

        [Required]
        [StringLength(20)]
        public string ReferenciaStorage { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }
        //Relacion con productos 
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //Relacion con bodegas
        public int WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relacion con movimientos de entrada y salida 
        public ICollection<InputOputEntity> InputOputs { get; set; }
    }
}
