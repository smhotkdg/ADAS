﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:2.0.50727.3625
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: http://tempuri.org/ 네임스페이스의 요소 이름 HelloWorldResult이(가) "nillable"로 표시되지 않았으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Project.ServiceReference1.HelloWorldResponse HelloWorld(Project.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: http://tempuri.org/ 네임스페이스의 요소 이름 Latitude이(가) "nillable"로 표시되지 않았으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddCoordinate", ReplyAction="*")]
        Project.ServiceReference1.AddCoordinateResponse AddCoordinate(Project.ServiceReference1.AddCoordinateRequest request);
        
        // CODEGEN: http://tempuri.org/ 네임스페이스의 요소 이름 GetLatitudeResult이(가) "nillable"로 표시되지 않았으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatitude", ReplyAction="*")]
        Project.ServiceReference1.GetLatitudeResponse GetLatitude(Project.ServiceReference1.GetLatitudeRequest request);
        
        // CODEGEN: http://tempuri.org/ 네임스페이스의 요소 이름 GetLongitudeResult이(가) "nillable"로 표시되지 않았으므로 메시지 계약을 생성합니다.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLongitude", ReplyAction="*")]
        Project.ServiceReference1.GetLongitudeResponse GetLongitude(Project.ServiceReference1.GetLongitudeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Project.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Project.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddCoordinateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddCoordinate", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.AddCoordinateRequestBody Body;
        
        public AddCoordinateRequest() {
        }
        
        public AddCoordinateRequest(Project.ServiceReference1.AddCoordinateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddCoordinateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Latitude;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Longitude;
        
        public AddCoordinateRequestBody() {
        }
        
        public AddCoordinateRequestBody(string Latitude, string Longitude) {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddCoordinateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddCoordinateResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.AddCoordinateResponseBody Body;
        
        public AddCoordinateResponse() {
        }
        
        public AddCoordinateResponse(Project.ServiceReference1.AddCoordinateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddCoordinateResponseBody {
        
        public AddCoordinateResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLatitudeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLatitude", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.GetLatitudeRequestBody Body;
        
        public GetLatitudeRequest() {
        }
        
        public GetLatitudeRequest(Project.ServiceReference1.GetLatitudeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetLatitudeRequestBody {
        
        public GetLatitudeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLatitudeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLatitudeResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.GetLatitudeResponseBody Body;
        
        public GetLatitudeResponse() {
        }
        
        public GetLatitudeResponse(Project.ServiceReference1.GetLatitudeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetLatitudeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetLatitudeResult;
        
        public GetLatitudeResponseBody() {
        }
        
        public GetLatitudeResponseBody(string GetLatitudeResult) {
            this.GetLatitudeResult = GetLatitudeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLongitudeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLongitude", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.GetLongitudeRequestBody Body;
        
        public GetLongitudeRequest() {
        }
        
        public GetLongitudeRequest(Project.ServiceReference1.GetLongitudeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetLongitudeRequestBody {
        
        public GetLongitudeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLongitudeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLongitudeResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project.ServiceReference1.GetLongitudeResponseBody Body;
        
        public GetLongitudeResponse() {
        }
        
        public GetLongitudeResponse(Project.ServiceReference1.GetLongitudeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetLongitudeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetLongitudeResult;
        
        public GetLongitudeResponseBody() {
        }
        
        public GetLongitudeResponseBody(string GetLongitudeResult) {
            this.GetLongitudeResult = GetLongitudeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ServiceSoapChannel : Project.ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<Project.ServiceReference1.ServiceSoap>, Project.ServiceReference1.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project.ServiceReference1.HelloWorldResponse Project.ServiceReference1.ServiceSoap.HelloWorld(Project.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Project.ServiceReference1.HelloWorldRequest inValue = new Project.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Project.ServiceReference1.HelloWorldRequestBody();
            Project.ServiceReference1.HelloWorldResponse retVal = ((Project.ServiceReference1.ServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project.ServiceReference1.AddCoordinateResponse Project.ServiceReference1.ServiceSoap.AddCoordinate(Project.ServiceReference1.AddCoordinateRequest request) {
            return base.Channel.AddCoordinate(request);
        }
        
        public void AddCoordinate(string Latitude, string Longitude) {
            Project.ServiceReference1.AddCoordinateRequest inValue = new Project.ServiceReference1.AddCoordinateRequest();
            inValue.Body = new Project.ServiceReference1.AddCoordinateRequestBody();
            inValue.Body.Latitude = Latitude;
            inValue.Body.Longitude = Longitude;
            Project.ServiceReference1.AddCoordinateResponse retVal = ((Project.ServiceReference1.ServiceSoap)(this)).AddCoordinate(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project.ServiceReference1.GetLatitudeResponse Project.ServiceReference1.ServiceSoap.GetLatitude(Project.ServiceReference1.GetLatitudeRequest request) {
            return base.Channel.GetLatitude(request);
        }
        
        public string GetLatitude() {
            Project.ServiceReference1.GetLatitudeRequest inValue = new Project.ServiceReference1.GetLatitudeRequest();
            inValue.Body = new Project.ServiceReference1.GetLatitudeRequestBody();
            Project.ServiceReference1.GetLatitudeResponse retVal = ((Project.ServiceReference1.ServiceSoap)(this)).GetLatitude(inValue);
            return retVal.Body.GetLatitudeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project.ServiceReference1.GetLongitudeResponse Project.ServiceReference1.ServiceSoap.GetLongitude(Project.ServiceReference1.GetLongitudeRequest request) {
            return base.Channel.GetLongitude(request);
        }
        
        public string GetLongitude() {
            Project.ServiceReference1.GetLongitudeRequest inValue = new Project.ServiceReference1.GetLongitudeRequest();
            inValue.Body = new Project.ServiceReference1.GetLongitudeRequestBody();
            Project.ServiceReference1.GetLongitudeResponse retVal = ((Project.ServiceReference1.ServiceSoap)(this)).GetLongitude(inValue);
            return retVal.Body.GetLongitudeResult;
        }
    }
}
