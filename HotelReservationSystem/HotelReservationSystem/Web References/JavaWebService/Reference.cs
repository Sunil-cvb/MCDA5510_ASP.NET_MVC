﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace HotelReservationSystem.JavaWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CustomerWebServiceSoapBinding", Namespace="http://webservice.mcda5510.com")]
    public partial class CustomerWebServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback createTranscationOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteTransactionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CustomerWebServiceService() {
            this.Url = global::HotelReservationSystem.Properties.Settings.Default.HotelReservationSystem_JavaWebService_CustomerWebServiceService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getTransactionCompletedEventHandler getTransactionCompleted;
        
        /// <remarks/>
        public event updateTransactionCompletedEventHandler updateTransactionCompleted;
        
        /// <remarks/>
        public event createTranscationCompletedEventHandler createTranscationCompleted;
        
        /// <remarks/>
        public event deleteTransactionCompletedEventHandler deleteTransactionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice.mcda5510.com", ResponseNamespace="http://webservice.mcda5510.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getTransactionReturn")]
        public string getTransaction(int ID) {
            object[] results = this.Invoke("getTransaction", new object[] {
                        ID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTransactionAsync(int ID) {
            this.getTransactionAsync(ID, null);
        }
        
        /// <remarks/>
        public void getTransactionAsync(int ID, object userState) {
            if ((this.getTransactionOperationCompleted == null)) {
                this.getTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTransactionOperationCompleted);
            }
            this.InvokeAsync("getTransaction", new object[] {
                        ID}, this.getTransactionOperationCompleted, userState);
        }
        
        private void OngetTransactionOperationCompleted(object arg) {
            if ((this.getTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTransactionCompleted(this, new getTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice.mcda5510.com", ResponseNamespace="http://webservice.mcda5510.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("updateTransactionReturn")]
        public string updateTransaction(int ID, string cardHolderName, double unitPrice, int quantity) {
            object[] results = this.Invoke("updateTransaction", new object[] {
                        ID,
                        cardHolderName,
                        unitPrice,
                        quantity});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateTransactionAsync(int ID, string cardHolderName, double unitPrice, int quantity) {
            this.updateTransactionAsync(ID, cardHolderName, unitPrice, quantity, null);
        }
        
        /// <remarks/>
        public void updateTransactionAsync(int ID, string cardHolderName, double unitPrice, int quantity, object userState) {
            if ((this.updateTransactionOperationCompleted == null)) {
                this.updateTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateTransactionOperationCompleted);
            }
            this.InvokeAsync("updateTransaction", new object[] {
                        ID,
                        cardHolderName,
                        unitPrice,
                        quantity}, this.updateTransactionOperationCompleted, userState);
        }
        
        private void OnupdateTransactionOperationCompleted(object arg) {
            if ((this.updateTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateTransactionCompleted(this, new updateTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice.mcda5510.com", ResponseNamespace="http://webservice.mcda5510.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("createTranscationReturn")]
        public string createTranscation(int CustomerID, string nameOnCard, string cardNumber, double unitPrice, int quantity, string expDate) {
            object[] results = this.Invoke("createTranscation", new object[] {
                        CustomerID,
                        nameOnCard,
                        cardNumber,
                        unitPrice,
                        quantity,
                        expDate});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void createTranscationAsync(int CustomerID, string nameOnCard, string cardNumber, double unitPrice, int quantity, string expDate) {
            this.createTranscationAsync(CustomerID, nameOnCard, cardNumber, unitPrice, quantity, expDate, null);
        }
        
        /// <remarks/>
        public void createTranscationAsync(int CustomerID, string nameOnCard, string cardNumber, double unitPrice, int quantity, string expDate, object userState) {
            if ((this.createTranscationOperationCompleted == null)) {
                this.createTranscationOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateTranscationOperationCompleted);
            }
            this.InvokeAsync("createTranscation", new object[] {
                        CustomerID,
                        nameOnCard,
                        cardNumber,
                        unitPrice,
                        quantity,
                        expDate}, this.createTranscationOperationCompleted, userState);
        }
        
        private void OncreateTranscationOperationCompleted(object arg) {
            if ((this.createTranscationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createTranscationCompleted(this, new createTranscationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://webservice.mcda5510.com", ResponseNamespace="http://webservice.mcda5510.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("deleteTransactionReturn")]
        public string deleteTransaction(int ID) {
            object[] results = this.Invoke("deleteTransaction", new object[] {
                        ID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void deleteTransactionAsync(int ID) {
            this.deleteTransactionAsync(ID, null);
        }
        
        /// <remarks/>
        public void deleteTransactionAsync(int ID, object userState) {
            if ((this.deleteTransactionOperationCompleted == null)) {
                this.deleteTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteTransactionOperationCompleted);
            }
            this.InvokeAsync("deleteTransaction", new object[] {
                        ID}, this.deleteTransactionOperationCompleted, userState);
        }
        
        private void OndeleteTransactionOperationCompleted(object arg) {
            if ((this.deleteTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteTransactionCompleted(this, new deleteTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getTransactionCompletedEventHandler(object sender, getTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void updateTransactionCompletedEventHandler(object sender, updateTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void createTranscationCompletedEventHandler(object sender, createTranscationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createTranscationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createTranscationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void deleteTransactionCompletedEventHandler(object sender, deleteTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591