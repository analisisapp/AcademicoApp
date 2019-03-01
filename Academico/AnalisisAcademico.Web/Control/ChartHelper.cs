using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalisisAcademico.Web.Control
{
    public class ChartHelper
    {
        public string Graficar()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("$(function () {");
            builder.Append("$('#container').highcharts({");
            builder.Append(" title: {");
            builder.Append("  text: 'Monthly Average Temperature',");
            builder.Append(" x: -20 //center");
            builder.Append("},");
            builder.Append("subtitle: {");
            builder.Append("text: 'Source: WorldClimate.com',");
            builder.Append(" x: -20");
            builder.Append("},");
            builder.Append("xAxis: {");
            builder.Append("categories: ");
            builder.Append("['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun','Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']");
            builder.Append("},");
            builder.Append("yAxis: {");
            builder.Append("title: { text: 'Temperature (°C)' },");
            builder.Append("plotLines: [{value: 0,width: 1,color: '#808080'}]");
            builder.Append("},");
            builder.Append("tooltip: {valueSuffix: '°C'},");
            builder.Append("legend: {");
            builder.Append("layout: 'vertical',");
            builder.Append("align: 'right',");
            builder.Append("verticalAlign: 'middle',");
            builder.Append("borderWidth: 0");
            builder.Append(" },");
            builder.Append("series: [{name: 'Tokyo',");
            builder.Append("data: [7.0, 6.9, 9.5, 14.5, 18.2, 21.5, 25.2, 26.5, 23.3, 18.3, 13.9, 9.6]");
            builder.Append("}, {");
            builder.Append("name: 'New York',");
            builder.Append("data: [-0.2, 0.8, 5.7, 11.3, 17.0, 22.0, 24.8, 24.1, 20.1, 14.1, 8.6, 2.5]");
            builder.Append("}, {");
            builder.Append("name: 'Berlin',");
            builder.Append("data: [-0.9, 0.6, 3.5, 8.4, 13.5, 17.0, 18.6, 17.9, 14.3, 9.0, 3.9, 1.0]");
            builder.Append("}, {");
            builder.Append("name: 'London',");
            builder.Append("data: [3.9, 4.2, 5.7, 8.5, 11.9, 15.2, 17.0, 16.6, 14.2, 10.3, 6.6, 4.8]");
            builder.Append("}]");
            builder.Append("});");
            builder.Append("});");
            
            return builder.ToString();
        }

        public string Graficar(string json, string cabeceras)
        {
            return "";
        }


        public string Graficar(EstadisticaSolicitudAlumno estadistica)
        {
            StringBuilder scriptChart = new StringBuilder();
            scriptChart.Append("<script>");
            scriptChart.Append("var ctx = document.getElementById('myChart').getContext('2d');");
            scriptChart.Append("var myChart = new Chart(ctx, {");
            scriptChart.Append("type: 'bar',");
            scriptChart.Append("data:");
            scriptChart.Append("{");
            scriptChart.Append("labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],");
            scriptChart.Append("datasets: [{");
            scriptChart.Append("label: 'Numero de Solicitudes Generadas',");
            //aqui esta el proceso de la graficacion de  los datos
            scriptChart.Append("data:["+ estadistica.TotalSolicitudAlumno+ ","+estadistica.TotalSolicitudCarrera+"],");
            ////
            scriptChart.Append("backgroundColor: [");
            scriptChart.Append("'rgba(255, 99, 132, 0.2)',");
            scriptChart.Append("'rgba(54, 162, 235, 0.8)',");
            scriptChart.Append("'rgba(255, 206, 86, 0.7)',");
            scriptChart.Append("'rgba(75, 192, 192, 0.7)',");
            scriptChart.Append("'rgba(153, 102, 255, 0.2)',");
            scriptChart.Append("'rgba(4, 180, 134, 0.8)'");
            scriptChart.Append(" ],");
            scriptChart.Append(" borderColor: [");
            scriptChart.Append("'rgba(255,99,132,1)',");
            scriptChart.Append("'rgba(54, 162, 235, 1)',");
            scriptChart.Append("'rgba(255, 206, 86, 1)',");
            scriptChart.Append("'rgba(75, 192, 192, 1)',");
            scriptChart.Append("'rgba(153, 102, 255, 1)',");
            scriptChart.Append("'rgba(255, 159, 64, 1)'");
            scriptChart.Append("  ],");
            scriptChart.Append("borderWidth: 1");
            scriptChart.Append("  }]");
            scriptChart.Append("},");
            scriptChart.Append(" options:");
            scriptChart.Append("{");
            scriptChart.Append(" scales:");
            scriptChart.Append(" {");
            scriptChart.Append("yAxes: [{");
            scriptChart.Append("ticks:");
            scriptChart.Append(" {");
            scriptChart.Append("beginAtZero: true");
            scriptChart.Append("}");
            scriptChart.Append("}]");
            scriptChart.Append("}");
            scriptChart.Append(" }");
            scriptChart.Append(" });");
            scriptChart.Append(" </script>");
            //data: [12, 19, 7, 4, 1, 22]
         return scriptChart.ToString();         
        }
        
      } 
  
}
