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

namespace DSoftCloud.DSoftWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="dsoft_serverBinding", Namespace="www.dsoftsistemas.com.br/DSoftWS/?wsdl")]
    public partial class dsoft_server : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback dsoft_testOperationCompleted;
        
        private System.Threading.SendOrPostCallback dsoft_loginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public dsoft_server() {
            this.Url = global::DSoftCloud.Properties.Settings.Default.DSoftCloud_br_com_dsoftsistemas_www_dsoft_server;
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
        public event dsoft_testCompletedEventHandler dsoft_testCompleted;
        
        /// <remarks/>
        public event dsoft_loginCompletedEventHandler dsoft_loginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.dsoftsistemas.com.br/DSoftWS/server.php/dsoft_test", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string dsoft_test(string test) {
            object[] results = this.Invoke("dsoft_test", new object[] {
                        test});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void dsoft_testAsync(string test) {
            this.dsoft_testAsync(test, null);
        }
        
        /// <remarks/>
        public void dsoft_testAsync(string test, object userState) {
            if ((this.dsoft_testOperationCompleted == null)) {
                this.dsoft_testOperationCompleted = new System.Threading.SendOrPostCallback(this.Ondsoft_testOperationCompleted);
            }
            this.InvokeAsync("dsoft_test", new object[] {
                        test}, this.dsoft_testOperationCompleted, userState);
        }
        
        private void Ondsoft_testOperationCompleted(object arg) {
            if ((this.dsoft_testCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dsoft_testCompleted(this, new dsoft_testCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.dsoftsistemas.com.br/DSoftWS/server.php/dsoft_login", RequestNamespace="", ResponseNamespace="")]
        public void dsoft_login() {
            this.Invoke("dsoft_login", new object[0]);
        }
        
        /// <remarks/>
        public void dsoft_loginAsync() {
            this.dsoft_loginAsync(null);
        }
        
        /// <remarks/>
        public void dsoft_loginAsync(object userState) {
            if ((this.dsoft_loginOperationCompleted == null)) {
                this.dsoft_loginOperationCompleted = new System.Threading.SendOrPostCallback(this.Ondsoft_loginOperationCompleted);
            }
            this.InvokeAsync("dsoft_login", new object[0], this.dsoft_loginOperationCompleted, userState);
        }
        
        private void Ondsoft_loginOperationCompleted(object arg) {
            if ((this.dsoft_loginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.dsoft_loginCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    public delegate void dsoft_testCompletedEventHandler(object sender, dsoft_testCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class dsoft_testCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal dsoft_testCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1085.0")]
    public delegate void dsoft_loginCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591