using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//cargamos el modelo de la tabla a insertar
using AnalisisAcademico.Data.Model;
//mandamos cargar  la libreria para la consulta de elementos genericos
using AnalisisAcademico.Web.Control;
//cargamos el archivo de recursos para poder utilizar el perfil del alumno
using Academico.Common;
using System.IO;
using Microsoft.Practices.Unity;
//cargamos la libreria base donde se encuentran las interfaces y las clases de negocios
using AnalisisAcademico.Data;
using AnalisisAcademico.Data.Infraestructure;
using Unity.WebForms.Configuration;
using Unity;

namespace Academico
{
    public partial class registroinstitucional : System.Web.UI.Page
    {
        //Inyectamos la dependencia
        [Dependency]
        public ISegUsuarioRepository segUsuarioRepository { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                this.FillDropDownList();
            }
        }

        #region Llenado de el DropDownList
        public void FillDropDownList()
        {
            //este metodo se encarga de llenar un dropdownList
            this.ddlCarrera.getCatalogoCarreras();///este metodo se encuentra en la libreria de web.control
            //es un catalogo generico
        }
        #endregion

        #region Evento del DropDownList
        //este metodo se encarga de obtener loq ue el usuario selecciono del dropdownList
        private string GetDropDownListCarrera()
        {
            return this.ddlCarrera.SelectedValue.ToString();
        }

        #endregion


        #region Obtener los Datos de la Pantalla
        protected SegUsuarios GetDataViewSegUsuario(int idCarrera)
        {
            SegUsuarios segUsuario = new SegUsuarios();
            segUsuario.strUsuario = txtNombreUsuario.Text.ToLower();
            segUsuario.strPassword = txtPassword.Text.Trim().ToLower();
            segUsuario.strNombre = txtNombre.Text.ToLower();
            segUsuario.strAPaterno = txtApellidoPaterno.Text.ToLower();
            segUsuario.strAMaterno = txtApellidoMaterno.Text.ToLower();
            segUsuario.strTelefono = txtTelefonoCelular.Text.ToLower();
            //cargamos la foto para poderla insertar en la base de datos
            segUsuario.foto = (byte[]) Session["foto"]; 
            segUsuario.email = txtEmail.Text.ToLower();
            segUsuario.strPlanEstudios = txtPlanEstudios.Text.ToLower();
            //establecemos el identificador del alumno a traves del perfil
            segUsuario.idSegPerfil = int.Parse(Recursos.ID_PERFIL_ALUMNO);
            //obtenemos el id de la carrera
            segUsuario.idCarrera = idCarrera;

            //creamos la entidad credito
            Creditos credito = new Creditos();
            //llenamos nuestra entidad
            credito.creditosAprobados = int.Parse(this.txtCreditosAprobados.Text.ToLower());
            credito.creditosPorCursar = int.Parse(this.txtCreditosPorCursar.Text.ToLower());
            credito.creditosTotales = int.Parse(this.txtCreditosTotales.Text.ToLower());
            
            //insertamos  la entidad credito en la entidad principal
            //recordando que creditos es una lista, a esta lista le asignamos un elemento de la entidad credito
            segUsuario.Creditos.Add(credito);

            //creamos la entidad del tipo Asignaturas
            Asignaturas asignatura = new Asignaturas();
            asignatura.asignaturasTotales = int.Parse(this.txtAsignaturasTotales.Text.Trim());
            asignatura.asignaturasAprobadas = int.Parse(this.txtAsignaturasAprobadas.Text.Trim());
            asignatura.asignaturasCursar = int.Parse(this.txtAsignaturasCursadas.Text.Trim());
            asignatura.asignaturasReprobadas = int.Parse(this.txtAsignaturasReprobadas.Text.Trim());
            asignatura.asignaturasRepeticion = int.Parse(this.txtAsignaturasRepetición.Text.Trim());

            //relacionamos  la asignatura creada a la entidad principal
            //recuerda que asignatura es una lista pero solo almacenamos una sola entidad
            segUsuario.Asignaturas.Add(asignatura);

            return segUsuario;///regresamos la entidad  a insertar ya precargada
        }
        #endregion

        #region  Creamos el evento para subir el archivo de la foto del usuario

        protected void file_Foto_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {
            string path = Server.MapPath(Recursos.PATH_IMAGENES); //establecemos la ruta de el guardado de imagenes
            if (Directory.Exists(path))
            {
                ///obtenemos el nombre del archivo a traves del evento de carga
                string pathComplete = path + e.FileName;
                if (!File.Exists(pathComplete)) //preguntamos si existe el archivo
                {
                    //guardamos el archivo en la ruta especificada
                    this.file_Foto.SaveAs(pathComplete);
                    //este metodo se encarga de leer todos los archivos  y las pone en una variable del tipo byte
                    byte[] foto = File.ReadAllBytes(pathComplete); 
                    //se almacena en la session la foto del usuario
                    this.Session["foto"] = foto;
                    //guardamos el path Completo
                    this.Session["pathCompleto"] = pathComplete;
                }
            }
        }
        #endregion

        #region  Acción del Evento  Guardar

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaFoto = this.Session["pathCompleto"].ToString();
                rutaFoto = (string)this.Session["pathCompleto"].ToString();
                if (this.ddlCarrera.SelectedValue != "Seleccionar" && rutaFoto != string.Empty)
                {
                    int idCarrera = int.Parse(this.ddlCarrera.SelectedValue.ToString());
                    segUsuarioRepository.InsertarSegUsuario(this.GetDataViewSegUsuario(idCarrera));
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successalert();", true);
                }
            }
            catch (Exception ex)
            {
                string MensajeErr = ex.Message;
                //invocamos un script o mensaje de java script desde el servidor
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "erroralert();", true);
            }

        }
        #endregion
    }




}