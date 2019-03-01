using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnalisisAcademico.Web.Control;
using System.Web.UI.WebControls;
using Data.Model;
namespace AnalisisAcademico.Web.Control
{
    public static class DropDownListExtended
    {
        public static void getCatalogoCarreras(this DropDownList _control)
        {
            CtrlGeneric ctrl = new CtrlGeneric();
            List<CatCarrera> lista = ctrl.GetCatalogGenericEntity<CatCarrera>();
            _control.Items.Insert(0, "Seleccionar");
            _control.DataTextField = "strValor";
            _control.DataValueField = "id";
            _control.DataSource = lista;
            _control.DataBind();

        }

        public static void getEstatusAcademico(this DropDownList _control)
        {
            CtrlGeneric ctrl = new CtrlGeneric();
            List<EstatusAcademico> lista = ctrl.GetCatalogGenericEntity<EstatusAcademico>();
            _control.Items.Insert(0,"Seleccionar");
            _control.DataTextField = "descripcion";
            _control.DataValueField = "id";
            _control.DataSource = lista;
            _control.DataBind();
        }

        public static void getCatAsuntoSolicitud(this DropDownList _control)
        {
            CtrlGeneric ctrl = new CtrlGeneric();
            List<CatAsuntoSolicitud> lista = ctrl.GetCatalogGenericEntity<CatAsuntoSolicitud>();
            _control.Items.Insert(0,"Seleccionar");
            _control.DataTextField = "strValor";
            _control.DataValueField = "id";
            _control.DataSource = lista;
            _control.DataBind();
        }


    }
}
