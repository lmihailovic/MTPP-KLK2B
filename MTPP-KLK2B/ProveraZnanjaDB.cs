using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MTPP_KLK2B
{
    public class ProveraZnanjaDB : DbContext
    {
        public ProveraZnanjaDB()
            : base("name=ProveraZnanjaDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the model and relationships here if needed
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<ProveraZnanja> ProveraZnanjas { get; set; }
        public virtual DbSet<Pitanje> Pitanjas { get; set; }
        public virtual DbSet<Odgovor> Odgovori { get; set; }
    }

    public class ProveraZnanja
    {
        [Key]
        public int IdProvereZnanja { get; set; }

        [Required]
        [StringLength(40)]
        public string NazivProvere { get; set; }

        [Required]
        public DateTime GodinaProvere { get; set; }

        public int? TrajanjeProvere { get; set; }
    }

    public class Pitanje
    {
        [Key]
        public int IdPitanja { get; set; }

        [Required]
        [StringLength(200)]
        public string TekstPitanja { get; set; }

        [Required]
        [ForeignKey("ProveraZnanja")]
        public int IdProvereZnanja { get; set; }

        public virtual ProveraZnanja ProveraZnanja { get; set; }
    }

    public class Odgovor
    {
        [Key]
        public int IdOdgovora { get; set; }

        [Required]
        [StringLength(200)]
        public string TekstOdgovora { get; set; }

        [Required]
        [ForeignKey("Pitanje")]
        public int IdPitanja { get; set; }
        public virtual Pitanje Pitanje { get; set; }
    }
}