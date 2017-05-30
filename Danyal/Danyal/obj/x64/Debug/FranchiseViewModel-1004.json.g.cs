// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "FranchiseViewModel.json"
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
using __FrHtml__ = global::Danyal.FranchiseViewModel.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrUrlId__ = global::Danyal.FranchiseViewModel.Input.UrlId;
using __FrTrend__ = global::Danyal.FranchiseViewModel.Input.Trend;
using __FrAverageC__ = global::Danyal.FranchiseViewModel.Input.AverageCommision;
using __FrTotalCom__ = global::Danyal.FranchiseViewModel.Input.TotalCommission;
using __FrNoOfHome__ = global::Danyal.FranchiseViewModel.Input.NoOfHomesSold;
using __FrName__ = global::Danyal.FranchiseViewModel.Input.Name;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Danyal.FranchiseViewModel.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Danyal.FranchiseViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Danyal.FranchiseViewModel;
using __Franchis2__ = global::Danyal.FranchiseViewModel.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseViewModel(__FrSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/View/FranchiseView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                NoOfHomesSold = Add<__TLong__>("NoOfHomesSold");
                NoOfHomesSold.DefaultValue = 0L;
                NoOfHomesSold.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__NoOfHomesSold__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__NoOfHomesSold__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                AverageCommision = Add<__TLong__>("AverageCommision");
                AverageCommision.DefaultValue = 0L;
                AverageCommision.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AverageCommision__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AverageCommision__ = (System.Int64)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                UrlId = Add<__TString__>("UrlId");
                UrlId.DefaultValue = "";
                UrlId.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__UrlId__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__UrlId__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ NoOfHomesSold;
            public __TLong__ TotalCommission;
            public __TLong__ AverageCommision;
            public __TLong__ Trend;
            public __TString__ UrlId;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NoOfHomesSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NoOfHomesSold {
    #line 4 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.NoOfHomesSold.Getter(this); }
        #line 4 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.NoOfHomesSold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalCommission {
    #line 5 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.TotalCommission.Getter(this); }
        #line 5 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.TotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AverageCommision__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AverageCommision {
    #line 6 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.AverageCommision.Getter(this); }
        #line 6 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.AverageCommision.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 7 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 7 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__UrlId__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String UrlId {
    #line 8 "FranchiseViewModel.json"
        get {
        #line hidden
            return Template.UrlId.Getter(this); }
        #line 8 "FranchiseViewModel.json"
        set {
        #line hidden
            Template.UrlId.Setter(this, value); } }
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
        public class NoOfHomesSold : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommision : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class UrlId : Input<__Franchis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
