using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkLinQ04
{
    public partial class ModelFrases : DbContext
    {
        public ModelFrases()
            : base("name=ModelFrases")
        {
        }

        public virtual DbSet<autores> autores { get; set; }
        public virtual DbSet<frases> frases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<autores>()
                .Property(e => e.autor)
                .IsUnicode(false);

            modelBuilder.Entity<frases>()
                .Property(e => e.frase)
                .IsUnicode(false);
        }
    }
}
