using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        [Required]
        public String AliasCategory { get; set; }

        
        //Relacion con productos
        public ICollection<ProductEntity> Products { get; set; }

    }
}
