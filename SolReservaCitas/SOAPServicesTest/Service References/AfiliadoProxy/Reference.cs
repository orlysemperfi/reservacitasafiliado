﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34003
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServicesTest.AfiliadoProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Afiliado", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Afiliado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApeMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApePaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAfiliadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApeMaterno {
            get {
                return this.ApeMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApeMaternoField, value) != true)) {
                    this.ApeMaternoField = value;
                    this.RaisePropertyChanged("ApeMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApePaterno {
            get {
                return this.ApePaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApePaternoField, value) != true)) {
                    this.ApePaternoField = value;
                    this.RaisePropertyChanged("ApePaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAfiliado {
            get {
                return this.IdAfiliadoField;
            }
            set {
                if ((this.IdAfiliadoField.Equals(value) != true)) {
                    this.IdAfiliadoField = value;
                    this.RaisePropertyChanged("IdAfiliado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AfiliadoProxy.IAfiliado")]
    public interface IAfiliado {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/CrearAfiliado", ReplyAction="http://tempuri.org/IAfiliado/CrearAfiliadoResponse")]
        SOAPServicesTest.AfiliadoProxy.Afiliado CrearAfiliado(string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/CrearAfiliado", ReplyAction="http://tempuri.org/IAfiliado/CrearAfiliadoResponse")]
        System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> CrearAfiliadoAsync(string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ObtenerAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ObtenerAfiliadoResponse")]
        SOAPServicesTest.AfiliadoProxy.Afiliado ObtenerAfiliado(int idAfiliado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ObtenerAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ObtenerAfiliadoResponse")]
        System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> ObtenerAfiliadoAsync(int idAfiliado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ModificarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ModificarAfiliadoResponse")]
        SOAPServicesTest.AfiliadoProxy.Afiliado ModificarAfiliado(int idAfiliado, string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ModificarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ModificarAfiliadoResponse")]
        System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> ModificarAfiliadoAsync(int idAfiliado, string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/EliminarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/EliminarAfiliadoResponse")]
        void EliminarAfiliado(int idAfiliado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/EliminarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/EliminarAfiliadoResponse")]
        System.Threading.Tasks.Task EliminarAfiliadoAsync(int idAfiliado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ListarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ListarAfiliadoResponse")]
        SOAPServicesTest.AfiliadoProxy.Afiliado[] ListarAfiliado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ListarAfiliado", ReplyAction="http://tempuri.org/IAfiliado/ListarAfiliadoResponse")]
        System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado[]> ListarAfiliadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ValidarDNIExistente", ReplyAction="http://tempuri.org/IAfiliado/ValidarDNIExistenteResponse")]
        string ValidarDNIExistente(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAfiliado/ValidarDNIExistente", ReplyAction="http://tempuri.org/IAfiliado/ValidarDNIExistenteResponse")]
        System.Threading.Tasks.Task<string> ValidarDNIExistenteAsync(string dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAfiliadoChannel : SOAPServicesTest.AfiliadoProxy.IAfiliado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AfiliadoClient : System.ServiceModel.ClientBase<SOAPServicesTest.AfiliadoProxy.IAfiliado>, SOAPServicesTest.AfiliadoProxy.IAfiliado {
        
        public AfiliadoClient() {
        }
        
        public AfiliadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AfiliadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AfiliadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AfiliadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServicesTest.AfiliadoProxy.Afiliado CrearAfiliado(string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado) {
            return base.Channel.CrearAfiliado(dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
        }
        
        public System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> CrearAfiliadoAsync(string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado) {
            return base.Channel.CrearAfiliadoAsync(dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
        }
        
        public SOAPServicesTest.AfiliadoProxy.Afiliado ObtenerAfiliado(int idAfiliado) {
            return base.Channel.ObtenerAfiliado(idAfiliado);
        }
        
        public System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> ObtenerAfiliadoAsync(int idAfiliado) {
            return base.Channel.ObtenerAfiliadoAsync(idAfiliado);
        }
        
        public SOAPServicesTest.AfiliadoProxy.Afiliado ModificarAfiliado(int idAfiliado, string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado) {
            return base.Channel.ModificarAfiliado(idAfiliado, dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
        }
        
        public System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado> ModificarAfiliadoAsync(int idAfiliado, string dni, string nombre, string apepaterno, string apematerno, string direccion, System.DateTime fechaNacimiento, int estado) {
            return base.Channel.ModificarAfiliadoAsync(idAfiliado, dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
        }
        
        public void EliminarAfiliado(int idAfiliado) {
            base.Channel.EliminarAfiliado(idAfiliado);
        }
        
        public System.Threading.Tasks.Task EliminarAfiliadoAsync(int idAfiliado) {
            return base.Channel.EliminarAfiliadoAsync(idAfiliado);
        }
        
        public SOAPServicesTest.AfiliadoProxy.Afiliado[] ListarAfiliado() {
            return base.Channel.ListarAfiliado();
        }
        
        public System.Threading.Tasks.Task<SOAPServicesTest.AfiliadoProxy.Afiliado[]> ListarAfiliadoAsync() {
            return base.Channel.ListarAfiliadoAsync();
        }
        
        public string ValidarDNIExistente(string dni) {
            return base.Channel.ValidarDNIExistente(dni);
        }
        
        public System.Threading.Tasks.Task<string> ValidarDNIExistenteAsync(string dni) {
            return base.Channel.ValidarDNIExistenteAsync(dni);
        }
    }
}
