﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteFibonacci.ServicioFibonacci {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioFibonacci.IServicioFibonacci")]
    public interface IServicioFibonacci {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioFibonacci/GetNumerosFibonacci", ReplyAction="http://tempuri.org/IServicioFibonacci/GetNumerosFibonacciResponse")]
        int[] GetNumerosFibonacci(int num);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioFibonacci/GetNumerosFibonacci", ReplyAction="http://tempuri.org/IServicioFibonacci/GetNumerosFibonacciResponse")]
        System.Threading.Tasks.Task<int[]> GetNumerosFibonacciAsync(int num);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioFibonacciChannel : ClienteFibonacci.ServicioFibonacci.IServicioFibonacci, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioFibonacciClient : System.ServiceModel.ClientBase<ClienteFibonacci.ServicioFibonacci.IServicioFibonacci>, ClienteFibonacci.ServicioFibonacci.IServicioFibonacci {
        
        public ServicioFibonacciClient() {
        }
        
        public ServicioFibonacciClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioFibonacciClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioFibonacciClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioFibonacciClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] GetNumerosFibonacci(int num) {
            return base.Channel.GetNumerosFibonacci(num);
        }
        
        public System.Threading.Tasks.Task<int[]> GetNumerosFibonacciAsync(int num) {
            return base.Channel.GetNumerosFibonacciAsync(num);
        }
    }
}
