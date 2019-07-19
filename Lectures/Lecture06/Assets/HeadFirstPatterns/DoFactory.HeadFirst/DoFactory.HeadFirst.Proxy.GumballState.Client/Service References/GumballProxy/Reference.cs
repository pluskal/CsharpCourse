﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoFactory.HeadFirst.Proxy.GumballState.Client.GumballProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mycompany.com/headfirst/2008/07", ConfigurationName="GumballProxy.GumballMachine", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface GumballMachine {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/headfirst/2008/07/GumballMachine/StartWithQuarters", ReplyAction="http://www.mycompany.com/headfirst/2008/07/GumballMachine/StartWithQuartersRespon" +
            "se")]
        void StartWithQuarters(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/headfirst/2008/07/GumballMachine/InsertQuarter", ReplyAction="http://www.mycompany.com/headfirst/2008/07/GumballMachine/InsertQuarterResponse")]
        void InsertQuarter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/headfirst/2008/07/GumballMachine/TurnCrank", ReplyAction="http://www.mycompany.com/headfirst/2008/07/GumballMachine/TurnCrankResponse")]
        void TurnCrank();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/headfirst/2008/07/GumballMachine/EjectQuarter", ReplyAction="http://www.mycompany.com/headfirst/2008/07/GumballMachine/EjectQuarterResponse")]
        void EjectQuarter();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mycompany.com/headfirst/2008/07/GumballMachine/GetReport", ReplyAction="http://www.mycompany.com/headfirst/2008/07/GumballMachine/GetReportResponse")]
        string GetReport();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface GumballMachineChannel : DoFactory.HeadFirst.Proxy.GumballState.Client.GumballProxy.GumballMachine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GumballMachineClient : System.ServiceModel.ClientBase<DoFactory.HeadFirst.Proxy.GumballState.Client.GumballProxy.GumballMachine>, DoFactory.HeadFirst.Proxy.GumballState.Client.GumballProxy.GumballMachine {
        
        public GumballMachineClient() {
        }
        
        public GumballMachineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GumballMachineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GumballMachineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GumballMachineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void StartWithQuarters(int count) {
            base.Channel.StartWithQuarters(count);
        }
        
        public void InsertQuarter() {
            base.Channel.InsertQuarter();
        }
        
        public void TurnCrank() {
            base.Channel.TurnCrank();
        }
        
        public void EjectQuarter() {
            base.Channel.EjectQuarter();
        }
        
        public string GetReport() {
            return base.Channel.GetReport();
        }
    }
}
