namespace WebApplication1.Scripts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class table2
    {
        [Required]
        [StringLength(50)]
        public string subs { get; set; }

        [Key]
        [StringLength(50)]
        public string topings { get; set; }

        [Required]
        [StringLength(50)]
        public string size { get; set; }
    }
}
