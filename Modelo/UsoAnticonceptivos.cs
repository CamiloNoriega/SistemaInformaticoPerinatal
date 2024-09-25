﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Table("UsoAnticonceptivo")]
    public class UsoAnticonceptivos
    {
        [Key]
        public int Id {  get; set; }
        public string Nombre { get; set; }

        public int IdAntecedentesPObstetricos { get; set; }
        public virtual ICollection<AntecedentesPObstetricos> AntecedentesPObstetricos { get; set; }

    }
}
