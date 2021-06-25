using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class InputOputEntity
    {
        [Key]
        public int InoutId { get; set; }
        [Required]
        public DateTime InOutDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }

        //Relacion con almacenamiento

        public string StorageId { get; set; }
        public StorageEntity storage { get; set; }

    }
}
