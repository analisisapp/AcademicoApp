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
    
    public partial class Creditos
    {
        public int id { get; set; }
        public Nullable<decimal> creditosTotales { get; set; }
        public Nullable<decimal> creditosAprobados { get; set; }
        public Nullable<decimal> creditosPorCursar { get; set; }
        public Nullable<int> idAlumno { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<bool> activacion { get; set; }
    
        public virtual SegUsuarios SegUsuarios { get; set; }
    }
}
