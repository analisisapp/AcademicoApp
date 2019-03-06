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
    
    public partial class SegPersonalAdministrativo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SegPersonalAdministrativo()
        {
            this.Mensajes = new HashSet<Mensajes>();
            this.Notificaciones = new HashSet<Notificaciones>();
        }
    
        public int id { get; set; }
        public string strNombre { get; set; }
        public string strApellidoPaterno { get; set; }
        public string strApellidoMaterno { get; set; }
        public string strMail { get; set; }
        public string strFotoUrl { get; set; }
        public string strTelefonoInstitucional { get; set; }
        public string strExtension { get; set; }
        public Nullable<int> idSegPerfil { get; set; }
        public Nullable<int> idCatCarrera { get; set; }
        public string strNombreUsuario { get; set; }
        public string strPassword { get; set; }
        public byte[] foto { get; set; }
    
        public virtual CatCarrera CatCarrera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensajes> Mensajes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
        public virtual SegPerfil SegPerfil { get; set; }
    }
}