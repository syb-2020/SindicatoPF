//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocioSindicato.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conyuge
    {
        public int id_conyuge { get; set; }
        public string nombre { get; set; }
        public string conviviente { get; set; }
        public string rut { get; set; }
        public Nullable<System.DateTime> nacimiento { get; set; }
        public int edad { get; set; }
        public string rut_socio { get; set; }
    
        public virtual Socio Socio { get; set; }
    }
}
