﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTS.PaymentReferences {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentReferences.PaymentWebSoap")]
    public interface PaymentWebSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertPayment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int InsertPayment(string paymentID, string reserveID, string Depart, string Arrival, string Date, string Time, string seatNumber, decimal grandTotal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertPayment", ReplyAction="*")]
        System.Threading.Tasks.Task<int> InsertPaymentAsync(string paymentID, string reserveID, string Depart, string Arrival, string Date, string Time, string seatNumber, decimal grandTotal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retrievePayment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet retrievePayment(string RsvID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/retrievePayment", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> retrievePaymentAsync(string RsvID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PaymentWebSoapChannel : BTS.PaymentReferences.PaymentWebSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentWebSoapClient : System.ServiceModel.ClientBase<BTS.PaymentReferences.PaymentWebSoap>, BTS.PaymentReferences.PaymentWebSoap {
        
        public PaymentWebSoapClient() {
        }
        
        public PaymentWebSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentWebSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWebSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWebSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int InsertPayment(string paymentID, string reserveID, string Depart, string Arrival, string Date, string Time, string seatNumber, decimal grandTotal) {
            return base.Channel.InsertPayment(paymentID, reserveID, Depart, Arrival, Date, Time, seatNumber, grandTotal);
        }
        
        public System.Threading.Tasks.Task<int> InsertPaymentAsync(string paymentID, string reserveID, string Depart, string Arrival, string Date, string Time, string seatNumber, decimal grandTotal) {
            return base.Channel.InsertPaymentAsync(paymentID, reserveID, Depart, Arrival, Date, Time, seatNumber, grandTotal);
        }
        
        public System.Data.DataSet retrievePayment(string RsvID) {
            return base.Channel.retrievePayment(RsvID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> retrievePaymentAsync(string RsvID) {
            return base.Channel.retrievePaymentAsync(RsvID);
        }
    }
}