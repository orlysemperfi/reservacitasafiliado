﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SOAPServices.Dominio;
using System.Data;

namespace SOAPServices.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAfiliado
    {

        [OperationContract]
        [FaultContract(typeof(Error))]
        Afiliado CrearAfiliado(string dni,string nombre,string apepaterno,string apematerno,string direccion,DateTime fechaNacimiento,int estado);

        [OperationContract]
        Afiliado ObtenerAfiliado(int idAfiliado);

        [OperationContract]
        Afiliado ModificarAfiliado(int idAfiliado,string dni, string nombre, string apepaterno, string apematerno, string direccion, DateTime fechaNacimiento, int estado);

        [OperationContract]
        void EliminarAfiliado(int idAfiliado);

        [OperationContract]
        List<Afiliado> ListarAfiliado();


        //Validaciones
        [OperationContract]
        string ValidarDNIExistente(string dni);

        [OperationContract]
        [FaultContract(typeof(Error))]
        string ValidarDNIExistenteReniec(string dni);

        //Obtener Datos de Reniec
        [OperationContract]
        DataSet ObtenerDatosReniec(string dni);

    }

}
