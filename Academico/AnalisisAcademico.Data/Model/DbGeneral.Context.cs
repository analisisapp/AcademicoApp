﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnalisisAcademicoEntities : DbContext
    {
        public AnalisisAcademicoEntities()
            : base("name=AnalisisAcademicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AlumnoEstatusAcademico> AlumnoEstatusAcademico { get; set; }
        public virtual DbSet<Asignaturas> Asignaturas { get; set; }
        public virtual DbSet<CatAsuntoSolicitud> CatAsuntoSolicitud { get; set; }
        public virtual DbSet<CatCarrera> CatCarrera { get; set; }
        public virtual DbSet<catCarreraAsignaturasCursadas> catCarreraAsignaturasCursadas { get; set; }
        public virtual DbSet<catCarreraCreditos> catCarreraCreditos { get; set; }
        public virtual DbSet<CatStatus> CatStatus { get; set; }
        public virtual DbSet<Creditos> Creditos { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Documento_Solicitud> Documento_Solicitud { get; set; }
        public virtual DbSet<EspecialAsignaturas> EspecialAsignaturas { get; set; }
        public virtual DbSet<EspecialAsignaturasAcreditadas> EspecialAsignaturasAcreditadas { get; set; }
        public virtual DbSet<EstatusAcademico> EstatusAcademico { get; set; }
        public virtual DbSet<IngresoInstitucional> IngresoInstitucional { get; set; }
        public virtual DbSet<Mensajes> Mensajes { get; set; }
        public virtual DbSet<Notificaciones> Notificaciones { get; set; }
        public virtual DbSet<SegPerfil> SegPerfil { get; set; }
        public virtual DbSet<SegPersonalAdministrativo> SegPersonalAdministrativo { get; set; }
        public virtual DbSet<Seguimiento> Seguimiento { get; set; }
        public virtual DbSet<SegUsuarios> SegUsuarios { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<SolicitudDeAlumno> SolicitudDeAlumno { get; set; }
    }
}
