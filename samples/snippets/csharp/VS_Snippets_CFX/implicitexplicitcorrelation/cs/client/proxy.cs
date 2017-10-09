﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.20702.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:PharmacyService", ClrNamespace="PharmacyService")]

namespace PharmacyService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="urn:PharmacyService")]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid CustomerIDField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="urn:PharmacyService")]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CostField;
        
        private System.Guid CustomerIDField;
        
        private string DrugField;
        
        private System.Guid OrderIDField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cost
        {
            get
            {
                return this.CostField;
            }
            set
            {
                this.CostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid CustomerID
        {
            get
            {
                return this.CustomerIDField;
            }
            set
            {
                this.CustomerIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drug
        {
            get
            {
                return this.DrugField;
            }
            set
            {
                this.DrugField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OrderID
        {
            get
            {
                return this.OrderIDField;
            }
            set
            {
                this.OrderIDField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetBaseCost", Namespace="urn:PharmacyService")]
    public partial class GetBaseCost : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private PharmacyService.Customer CustomerField;
        
        private string DrugField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PharmacyService.Customer Customer
        {
            get
            {
                return this.CustomerField;
            }
            set
            {
                this.CustomerField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drug
        {
            get
            {
                return this.DrugField;
            }
            set
            {
                this.DrugField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="urn:PharmacyService", ConfigurationName="IPharmacy")]
public interface IPharmacy
{
    
    // CODEGEN: Generating message contract since the operation GetAdjustedCost is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="urn:PharmacyService/IPharmacy/GetAdjustedCost", ReplyAction="urn:PharmacyService/IPharmacy/GetAdjustedCostResponse")]
    GetAdjustedCostResponse GetAdjustedCost(GetAdjustedCostRequest request);
    
    // CODEGEN: Generating message contract since the operation GetInsurancePaymentPercentage is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="urn:PharmacyService/IPharmacy/GetInsurancePaymentPercentage", ReplyAction="urn:PharmacyService/IPharmacy/GetInsurancePaymentPercentageResponse")]
    GetInsurancePaymentPercentageResponse GetInsurancePaymentPercentage(GetInsurancePaymentPercentageRequest request);
    
    // CODEGEN: Generating message contract since the operation GetBaseCost is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="urn:PharmacyService/IPharmacy/GetBaseCost", ReplyAction="urn:PharmacyService/IPharmacy/GetBaseCostResponse")]
    GetBaseCostResponse GetBaseCost(GetBaseCostRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetAdjustedCostRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
    public System.Nullable<System.Guid> guid;
    
    public GetAdjustedCostRequest()
    {
    }
    
    public GetAdjustedCostRequest(System.Nullable<System.Guid> guid)
    {
        this.guid = guid;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetAdjustedCostResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
    public System.Nullable<double> @double;
    
    public GetAdjustedCostResponse()
    {
    }
    
    public GetAdjustedCostResponse(System.Nullable<double> @double)
    {
        this.@double = @double;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetInsurancePaymentPercentageRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
    public System.Nullable<System.Guid> guid;
    
    public GetInsurancePaymentPercentageRequest()
    {
    }
    
    public GetInsurancePaymentPercentageRequest(System.Nullable<System.Guid> guid)
    {
        this.guid = guid;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetInsurancePaymentPercentageResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
    public System.Nullable<int> @int;
    
    public GetInsurancePaymentPercentageResponse()
    {
    }
    
    public GetInsurancePaymentPercentageResponse(System.Nullable<int> @int)
    {
        this.@int = @int;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetBaseCostRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:PharmacyService", Order=0)]
    public PharmacyService.GetBaseCost GetBaseCost;
    
    public GetBaseCostRequest()
    {
    }
    
    public GetBaseCostRequest(PharmacyService.GetBaseCost GetBaseCost)
    {
        this.GetBaseCost = GetBaseCost;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class GetBaseCostResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:PharmacyService", Order=0)]
    public PharmacyService.Order Order;
    
    public GetBaseCostResponse()
    {
    }
    
    public GetBaseCostResponse(PharmacyService.Order Order)
    {
        this.Order = Order;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPharmacyChannel : IPharmacy, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PharmacyClient : System.ServiceModel.ClientBase<IPharmacy>, IPharmacy
{
    
    public PharmacyClient()
    {
    }
    
    public PharmacyClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PharmacyClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PharmacyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PharmacyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetAdjustedCostResponse IPharmacy.GetAdjustedCost(GetAdjustedCostRequest request)
    {
        return base.Channel.GetAdjustedCost(request);
    }
    
    public System.Nullable<double> GetAdjustedCost(System.Nullable<System.Guid> guid)
    {
        GetAdjustedCostRequest inValue = new GetAdjustedCostRequest();
        inValue.guid = guid;
        GetAdjustedCostResponse retVal = ((IPharmacy)(this)).GetAdjustedCost(inValue);
        return retVal.@double;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetInsurancePaymentPercentageResponse IPharmacy.GetInsurancePaymentPercentage(GetInsurancePaymentPercentageRequest request)
    {
        return base.Channel.GetInsurancePaymentPercentage(request);
    }
    
    public System.Nullable<int> GetInsurancePaymentPercentage(System.Nullable<System.Guid> guid)
    {
        GetInsurancePaymentPercentageRequest inValue = new GetInsurancePaymentPercentageRequest();
        inValue.guid = guid;
        GetInsurancePaymentPercentageResponse retVal = ((IPharmacy)(this)).GetInsurancePaymentPercentage(inValue);
        return retVal.@int;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetBaseCostResponse IPharmacy.GetBaseCost(GetBaseCostRequest request)
    {
        return base.Channel.GetBaseCost(request);
    }
    
    public PharmacyService.Order GetBaseCost(PharmacyService.GetBaseCost GetBaseCost1)
    {
        GetBaseCostRequest inValue = new GetBaseCostRequest();
        inValue.GetBaseCost = GetBaseCost1;
        GetBaseCostResponse retVal = ((IPharmacy)(this)).GetBaseCost(inValue);
        return retVal.Order;
    }
}
