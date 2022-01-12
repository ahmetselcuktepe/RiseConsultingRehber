using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rehber.Entities
{
   public class RehberKDetail
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int İd { get; set; }
        [StringLength(50)]
        public string Key { get; set; }
        [StringLength(50)]
        public string Deger { get; set; }
        [StringLength(50)]
        public string KisiId { get; set; }

        public bool Kaldirma { get; set; }
    }
}
