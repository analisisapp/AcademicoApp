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
    
    public partial class EstatusAcademico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusAcademico()
        {
            this.AlumnoEstatusAcademico = new HashSet<AlumnoEstatusAcademico>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoEstatusAcademico> AlumnoEstatusAcademico { get; set; }
    }
}
