using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Rehber.Entities
{
    public class RehberK 
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(200)]
        public string Firma { get; set; }

        public bool Kaldirma { get; set; }

        public ICollection<RehberKDetail> RehberKDetails { get; set; }

    }
}
