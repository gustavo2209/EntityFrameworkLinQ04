namespace EntityFrameworkLinQ04
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class frases
    {
        [Key]
        public int idfrase { get; set; }

        public int idautor { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string frase { get; set; }

        public virtual autores autores { get; set; }
    }
}
