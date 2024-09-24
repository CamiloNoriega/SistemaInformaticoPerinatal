using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AntecedentesPersonales
    {
        
        public int Id { get; set; }
        public bool TBC { get; set; }
        public string Diabetes { get; set; }  
        public bool Hipertension { get; set; }
        public bool Preeclampsia { get; set; }
        public bool Eclampsia { get; set; }
        public bool OtraCondMedicaGrave { get; set; }
    }
}

