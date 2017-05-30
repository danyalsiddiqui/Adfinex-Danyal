// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FranchiseDetailViewModel.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Danyal {
using __FrCity__ = global::Danyal.FranchiseDetailViewModel.Input.City;
using __FrAddress__ = global::Danyal.FranchiseDetailViewModel.Input.Address;
using __FrSaveFran__ = global::Danyal.FranchiseDetailViewModel.Input.SaveFranchiseAddress;
using __FrNewHomeS__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeStreet;
using __FrNewHomeN__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeNumber;
using __FrNewHomeZ__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeZipCode;
using __FrNewHomeC__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeCity;
using __FrNewHomeC1__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeCountry;
using __FrNewHomeA__ = global::Danyal.FranchiseDetailViewModel.Input.NewHomeAddress;
using __FrTransact__ = global::Danyal.FranchiseDetailViewModel.Input.TransactionDate;
using __FrTransact1__ = global::Danyal.FranchiseDetailViewModel.Input.TransactionSalePrice;
using __FrTransact2__ = global::Danyal.FranchiseDetailViewModel.Input.TransactionCommision;
using __FrSaveTran__ = global::Danyal.FranchiseDetailViewModel.Input.SaveTransaction;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __FrCountry__ = global::Danyal.FranchiseDetailViewModel.Input.Country;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FrNumber__ = global::Danyal.FranchiseDetailViewModel.Input.Number;
using __Franchis__ = global::Danyal.FranchiseDetailViewModel;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::Danyal.FranchiseDetailViewModel.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FrZipCode__ = global::Danyal.FranchiseDetailViewModel.Input.ZipCode;
using __TLong__ = global::Starcounter.Templates.TLong;
using __Franchis1__ = global::Danyal.FranchiseDetailViewModel.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Franchis2__ = global::Danyal.FranchiseDetailViewModel.Input;
using __FrHtml__ = global::Danyal.FranchiseDetailViewModel.Input.Html;
using __FrName__ = global::Danyal.FranchiseDetailViewModel.Input.Name;
using __FrStreet__ = global::Danyal.FranchiseDetailViewModel.Input.Street;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetailViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseDetailViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailViewModel(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/View/FranchiseDetailView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TLong__>("Number$");
                Number.DefaultValue = 0L;
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                ZipCode = Add<__TLong__>("ZipCode$");
                ZipCode.DefaultValue = 0L;
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                Address = Add<__TString__>("Address", bind:"Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
                SaveFranchiseAddress = Add<__TLong__>("SaveFranchiseAddress$");
                SaveFranchiseAddress.DefaultValue = 0L;
                SaveFranchiseAddress.Editable = true;
                SaveFranchiseAddress.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveFranchiseAddress__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveFranchiseAddress__ = (System.Int64)_v_; }, false);
                SaveFranchiseAddress.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveFranchiseAddress() { App = (FranchiseDetailViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailViewModel)pup).Handle((Input.SaveFranchiseAddress)input); });
                NewHomeStreet = Add<__TString__>("NewHomeStreet$");
                NewHomeStreet.DefaultValue = "";
                NewHomeStreet.Editable = true;
                NewHomeStreet.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeStreet__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeStreet__ = (System.String)_v_; }, false);
                NewHomeNumber = Add<__TLong__>("NewHomeNumber$");
                NewHomeNumber.DefaultValue = 0L;
                NewHomeNumber.Editable = true;
                NewHomeNumber.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeNumber__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeNumber__ = (System.Int64)_v_; }, false);
                NewHomeZipCode = Add<__TLong__>("NewHomeZipCode$");
                NewHomeZipCode.DefaultValue = 0L;
                NewHomeZipCode.Editable = true;
                NewHomeZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeZipCode__ = (System.Int64)_v_; }, false);
                NewHomeCity = Add<__TString__>("NewHomeCity$");
                NewHomeCity.DefaultValue = "";
                NewHomeCity.Editable = true;
                NewHomeCity.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeCity__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeCity__ = (System.String)_v_; }, false);
                NewHomeCountry = Add<__TString__>("NewHomeCountry$");
                NewHomeCountry.DefaultValue = "";
                NewHomeCountry.Editable = true;
                NewHomeCountry.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeCountry__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeCountry__ = (System.String)_v_; }, false);
                NewHomeAddress = Add<__TString__>("NewHomeAddress", bind:"NewHomeAddress");
                NewHomeAddress.DefaultValue = "";
                NewHomeAddress.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NewHomeAddress__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NewHomeAddress__ = (System.String)_v_; }, false);
                TransactionDate = Add<__TString__>("TransactionDate$");
                TransactionDate.DefaultValue = "";
                TransactionDate.Editable = true;
                TransactionDate.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionDate__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionDate__ = (System.String)_v_; }, false);
                TransactionSalePrice = Add<__TLong__>("TransactionSalePrice$");
                TransactionSalePrice.DefaultValue = 0L;
                TransactionSalePrice.Editable = true;
                TransactionSalePrice.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionSalePrice__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionSalePrice__ = (System.Int64)_v_; }, false);
                TransactionCommision = Add<__TLong__>("TransactionCommision$");
                TransactionCommision.DefaultValue = 0L;
                TransactionCommision.Editable = true;
                TransactionCommision.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TransactionCommision__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TransactionCommision__ = (System.Int64)_v_; }, false);
                SaveTransaction = Add<__TLong__>("SaveTransaction$");
                SaveTransaction.DefaultValue = 0L;
                SaveTransaction.Editable = true;
                SaveTransaction.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveTransaction__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveTransaction__ = (System.Int64)_v_; }, false);
                SaveTransaction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTransaction() { App = (FranchiseDetailViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailViewModel)pup).Handle((Input.SaveTransaction)input); });
                SoldHomes = Add<__TArray__>("SoldHomes");
                SoldHomes.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SoldHomes__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SoldHomes__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Street;
            public __TLong__ Number;
            public __TLong__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ Address;
            public __TLong__ SaveFranchiseAddress;
            public __TString__ NewHomeStreet;
            public __TLong__ NewHomeNumber;
            public __TLong__ NewHomeZipCode;
            public __TString__ NewHomeCity;
            public __TString__ NewHomeCountry;
            public __TString__ NewHomeAddress;
            public __TString__ TransactionDate;
            public __TLong__ TransactionSalePrice;
            public __TLong__ TransactionCommision;
            public __TLong__ SaveTransaction;
            public __TArray__ SoldHomes;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 4 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 4 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Number {
    #line 5 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 5 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 ZipCode {
    #line 6 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 6 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 8 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 8 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    #line hidden
    private System.Int64 __bf__SaveFranchiseAddress__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveFranchiseAddress {
    #line 10 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.SaveFranchiseAddress.Getter(this); }
        #line 10 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.SaveFranchiseAddress.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewHomeStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewHomeStreet {
    #line 11 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.NewHomeStreet.Getter(this); }
        #line 11 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.NewHomeStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewHomeNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewHomeNumber {
    #line 12 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.NewHomeNumber.Getter(this); }
        #line 12 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.NewHomeNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewHomeZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewHomeZipCode {
    #line 13 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.NewHomeZipCode.Getter(this); }
        #line 13 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.NewHomeZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewHomeCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewHomeCity {
    #line 14 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.NewHomeCity.Getter(this); }
        #line 14 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.NewHomeCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewHomeCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewHomeCountry {
    #line 15 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.NewHomeCountry.Getter(this); }
        #line 15 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.NewHomeCountry.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewHomeAddress__;
    #line default
    #line hidden
    private System.String __bf__TransactionDate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TransactionDate {
    #line 17 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.TransactionDate.Getter(this); }
        #line 17 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.TransactionDate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TransactionSalePrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TransactionSalePrice {
    #line 18 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.TransactionSalePrice.Getter(this); }
        #line 18 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.TransactionSalePrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TransactionCommision__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TransactionCommision {
    #line 19 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.TransactionCommision.Getter(this); }
        #line 19 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.TransactionCommision.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTransaction__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTransaction {
    #line 20 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.SaveTransaction.Getter(this); }
        #line 20 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.SaveTransaction.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__SoldHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ SoldHomes {
    #line 21 "FranchiseDetailViewModel.json"
        get {
        #line hidden
            return Template.SoldHomes.Getter(this); }
        #line 21 "FranchiseDetailViewModel.json"
        set {
        #line hidden
            Template.SoldHomes.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveFranchiseAddress : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewHomeStreet : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewHomeNumber : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewHomeZipCode : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewHomeCity : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewHomeCountry : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewHomeAddress : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TransactionDate : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TransactionSalePrice : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TransactionCommision : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveTransaction : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
