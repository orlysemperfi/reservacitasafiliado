﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Error 
    {
        [DataMember]
        public string CodigoNegocio { get; set; }
        [DataMember]
        public string MensajeNegocio { get; set; }
    }
}