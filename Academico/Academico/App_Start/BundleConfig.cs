﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace Academico
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // El orden es muy importante para el funcionamiento de estos archivos ya que tienen dependencias explícitas
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Use la versión de desarrollo de Modernizr para desarrollar y aprender. Luego, cuando esté listo
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                             "~/Scripts/jquery-3.3.1.js",
                             "~/Scripts/jquery.min.js",
                             "~/Scripts/bootstrap.min.js",
                             "~/Scripts/fastclick.js",
                             "~/Scripts/nprogress.js",
                             "~/Scripts/Chart.min.js",
                             "~/Scripts/gauge.min.js",
                             "~/Scripts/bootstrap-progressbar.min.js",
                             "~/Scripts/icheck.min.js",
                             "~/Scripts/skycons.js",
                             "~/Scripts/date.js",
                             "~/Scripts/jquery.vmap.min.js",
                             "~/Scripts/jquery.vmap.world.js",
                             "~/Scripts/jquery.vmap.sampledata.js",
                             "~/Scripts/moment.min.js",
                             "~/Scripts/moment.js",
                             "~/Scripts/daterangepicker.js",
                             "~/Scripts/bootstrap-wysiwyg.min.js",
                             "~/Scripts/jquery.hotkeys.js",
                             "~/Scripts/prettify.js",
                             "~/Scripts/jquery.tagsinput.js",
                             "~/Scripts/switchery.min.js",
                             "~/Scripts/select2.min.js",
                             "~/Scripts/parsley.min.js",
                             "~/Scripts/autosize.min.js",
                             "~/Scripts/jquery.autocomplete.min.js",
                             "~/Scripts/starrr.js",
                             "~/Scripts/custom.js",
                            "~/Scripts/modernizr-*"));

         }
    }
}