using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(6)]
        public string Referencia { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(600)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        //Relacion con Categorias
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        //Relacion con almacenamiento
        public ICollection<StorageEntity> Storages { get; set; }


    }
}
