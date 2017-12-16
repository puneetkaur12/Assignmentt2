namespace WebApplication1.Scripts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [Key]
        public int substore { get; set; }

        [Required]
        [StringLength(50)]
        public string subsid { get; set; }

        public int price { get; set; }
    }
}
