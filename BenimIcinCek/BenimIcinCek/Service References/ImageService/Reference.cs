﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace BenimIcinCek.ImageService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImageService.Image")]
    public interface Image {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/Image/Upload", ReplyAction="http://tempuri.org/Image/UploadResponse")]
        System.IAsyncResult BeginUpload(byte[] image, System.AsyncCallback callback, object asyncState);
        
        string EndUpload(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/Image/Download", ReplyAction="http://tempuri.org/Image/DownloadResponse")]
        System.IAsyncResult BeginDownload(string fileName, System.AsyncCallback callback, object asyncState);
        
        byte[] EndDownload(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ImageChannel : BenimIcinCek.ImageService.Image, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UploadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UploadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageClient : System.ServiceModel.ClientBase<BenimIcinCek.ImageService.Image>, BenimIcinCek.ImageService.Image {
        
        private BeginOperationDelegate onBeginUploadDelegate;
        
        private EndOperationDelegate onEndUploadDelegate;
        
        private System.Threading.SendOrPostCallback onUploadCompletedDelegate;
        
        private BeginOperationDelegate onBeginDownloadDelegate;
        
        private EndOperationDelegate onEndDownloadDelegate;
        
        private System.Threading.SendOrPostCallback onDownloadCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ImageClient() {
        }
        
        public ImageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<UploadCompletedEventArgs> UploadCompleted;
        
        public event System.EventHandler<DownloadCompletedEventArgs> DownloadCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult BenimIcinCek.ImageService.Image.BeginUpload(byte[] image, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpload(image, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string BenimIcinCek.ImageService.Image.EndUpload(System.IAsyncResult result) {
            return base.Channel.EndUpload(result);
        }
        
        private System.IAsyncResult OnBeginUpload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            byte[] image = ((byte[])(inValues[0]));
            return ((BenimIcinCek.ImageService.Image)(this)).BeginUpload(image, callback, asyncState);
        }
        
        private object[] OnEndUpload(System.IAsyncResult result) {
            string retVal = ((BenimIcinCek.ImageService.Image)(this)).EndUpload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUploadCompleted(object state) {
            if ((this.UploadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadCompleted(this, new UploadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadAsync(byte[] image) {
            this.UploadAsync(image, null);
        }
        
        public void UploadAsync(byte[] image, object userState) {
            if ((this.onBeginUploadDelegate == null)) {
                this.onBeginUploadDelegate = new BeginOperationDelegate(this.OnBeginUpload);
            }
            if ((this.onEndUploadDelegate == null)) {
                this.onEndUploadDelegate = new EndOperationDelegate(this.OnEndUpload);
            }
            if ((this.onUploadCompletedDelegate == null)) {
                this.onUploadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadCompleted);
            }
            base.InvokeAsync(this.onBeginUploadDelegate, new object[] {
                        image}, this.onEndUploadDelegate, this.onUploadCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult BenimIcinCek.ImageService.Image.BeginDownload(string fileName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDownload(fileName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        byte[] BenimIcinCek.ImageService.Image.EndDownload(System.IAsyncResult result) {
            return base.Channel.EndDownload(result);
        }
        
        private System.IAsyncResult OnBeginDownload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string fileName = ((string)(inValues[0]));
            return ((BenimIcinCek.ImageService.Image)(this)).BeginDownload(fileName, callback, asyncState);
        }
        
        private object[] OnEndDownload(System.IAsyncResult result) {
            byte[] retVal = ((BenimIcinCek.ImageService.Image)(this)).EndDownload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDownloadCompleted(object state) {
            if ((this.DownloadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DownloadCompleted(this, new DownloadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DownloadAsync(string fileName) {
            this.DownloadAsync(fileName, null);
        }
        
        public void DownloadAsync(string fileName, object userState) {
            if ((this.onBeginDownloadDelegate == null)) {
                this.onBeginDownloadDelegate = new BeginOperationDelegate(this.OnBeginDownload);
            }
            if ((this.onEndDownloadDelegate == null)) {
                this.onEndDownloadDelegate = new EndOperationDelegate(this.OnEndDownload);
            }
            if ((this.onDownloadCompletedDelegate == null)) {
                this.onDownloadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDownloadCompleted);
            }
            base.InvokeAsync(this.onBeginDownloadDelegate, new object[] {
                        fileName}, this.onEndDownloadDelegate, this.onDownloadCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override BenimIcinCek.ImageService.Image CreateChannel() {
            return new ImageClientChannel(this);
        }
        
        private class ImageClientChannel : ChannelBase<BenimIcinCek.ImageService.Image>, BenimIcinCek.ImageService.Image {
            
            public ImageClientChannel(System.ServiceModel.ClientBase<BenimIcinCek.ImageService.Image> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginUpload(byte[] image, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = image;
                System.IAsyncResult _result = base.BeginInvoke("Upload", _args, callback, asyncState);
                return _result;
            }
            
            public string EndUpload(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Upload", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDownload(string fileName, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = fileName;
                System.IAsyncResult _result = base.BeginInvoke("Download", _args, callback, asyncState);
                return _result;
            }
            
            public byte[] EndDownload(System.IAsyncResult result) {
                object[] _args = new object[0];
                byte[] _result = ((byte[])(base.EndInvoke("Download", _args, result)));
                return _result;
            }
        }
    }
}