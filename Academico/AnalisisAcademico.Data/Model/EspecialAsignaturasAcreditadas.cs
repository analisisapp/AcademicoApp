//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalisisAcademico.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EspecialAsignaturasAcreditadas
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> idAlumno { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual SegUsuarios SegUsuarios { get; set; }
    }
}
