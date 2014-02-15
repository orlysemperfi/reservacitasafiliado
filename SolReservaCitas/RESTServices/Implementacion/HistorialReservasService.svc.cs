﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "HistorialReservasService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione HistorialReservasService.svc o HistorialReservasService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class HistorialReservasService : IHistorialReservasService
    {
        private HistorialReservasDAO dao = new HistorialReservasDAO();
        private AfiliadoDAO dao1 = new AfiliadoDAO();
        
        public List<HistorialReservas> ListarHistorial(string dni,string desde,string hasta)
        {

             Afiliado afiliadoBuscado = dao1.Obtener(dni);
             List<HistorialReservas> Lista = null;
             if (afiliadoBuscado==null)
             {
                 throw new WebFaultException<string>(
                     "Afiliado No Registrado."
                     , HttpStatusCode.InternalServerError);
             }
             else
             {
                 Lista = dao.ListarTodos(dni,desde,hasta);
                 ICollection<HistorialReservas> modelo = Lista;

                 if (modelo.Count == 0)
                     throw new WebFaultException<string>(
                         "No existen reservas para el rango de fechas consultado."
                   , HttpStatusCode.InternalServerError);
                 
             }
             return Lista;
            }
    }
}
