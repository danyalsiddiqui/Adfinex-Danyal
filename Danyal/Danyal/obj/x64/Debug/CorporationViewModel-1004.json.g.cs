// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CorporationViewModel.json"
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
using __Corporat2__ = global::Danyal.CorporationViewModel.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoSortByTr__ = global::Danyal.CorporationViewModel.Input.SortByTrend;
using __CoSortByAv__ = global::Danyal.CorporationViewModel.Input.SortByAvgCommission;
using __CoSortByTo__ = global::Danyal.CorporationViewModel.Input.SortByTotalCommission;
using __CoSortByNo__ = global::Danyal.CorporationViewModel.Input.SortByNoOfHomes;
using __CoAddNewFr__ = global::Danyal.CorporationViewModel.Input.AddNewFranchies;
using __CoFranchie__ = global::Danyal.CorporationViewModel.Input.FranchiesName;
using __CoName__ = global::Danyal.CorporationViewModel.Input.Name;
using __CoHtml__ = global::Danyal.CorporationViewModel.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Corporat1__ = global::Danyal.CorporationViewModel.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Danyal.CorporationViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Danyal.CorporationViewModel;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationViewModel(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/View/CorporationView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Franchies = Add<__TArray__>("Franchies");
                Franchies.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Franchies__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Franchies__ = (__Arr__)_v_; }, false);
                FranchiesName = Add<__TString__>("FranchiesName$");
                FranchiesName.DefaultValue = "";
                FranchiesName.Editable = true;
                FranchiesName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiesName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiesName__ = (System.String)_v_; }, false);
                AddNewFranchies = Add<__TLong__>("AddNewFranchies$");
                AddNewFranchies.DefaultValue = 0L;
                AddNewFranchies.Editable = true;
                AddNewFranchies.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AddNewFranchies__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AddNewFranchies__ = (System.Int64)_v_; }, false);
                AddNewFranchies.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddNewFranchies() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.AddNewFranchies)input); });
                SortByNoOfHomes = Add<__TLong__>("SortByNoOfHomes$");
                SortByNoOfHomes.DefaultValue = 0L;
                SortByNoOfHomes.Editable = true;
                SortByNoOfHomes.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortByNoOfHomes__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortByNoOfHomes__ = (System.Int64)_v_; }, false);
                SortByNoOfHomes.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByNoOfHomes() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortByNoOfHomes)input); });
                SortByTotalCommission = Add<__TLong__>("SortByTotalCommission$");
                SortByTotalCommission.DefaultValue = 0L;
                SortByTotalCommission.Editable = true;
                SortByTotalCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortByTotalCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortByTotalCommission__ = (System.Int64)_v_; }, false);
                SortByTotalCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByTotalCommission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortByTotalCommission)input); });
                SortByAvgCommission = Add<__TLong__>("SortByAvgCommission$");
                SortByAvgCommission.DefaultValue = 0L;
                SortByAvgCommission.Editable = true;
                SortByAvgCommission.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortByAvgCommission__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortByAvgCommission__ = (System.Int64)_v_; }, false);
                SortByAvgCommission.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByAvgCommission() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortByAvgCommission)input); });
                SortByTrend = Add<__TLong__>("SortByTrend$");
                SortByTrend.DefaultValue = 0L;
                SortByTrend.Editable = true;
                SortByTrend.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortByTrend__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortByTrend__ = (System.Int64)_v_; }, false);
                SortByTrend.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortByTrend() { App = (CorporationViewModel)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationViewModel)pup).Handle((Input.SortByTrend)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ Franchies;
            public __TString__ FranchiesName;
            public __TLong__ AddNewFranchies;
            public __TLong__ SortByNoOfHomes;
            public __TLong__ SortByTotalCommission;
            public __TLong__ SortByAvgCommission;
            public __TLong__ SortByTrend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CorporationViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "CorporationViewModel.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Franchies__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Franchies {
    #line 4 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.Franchies.Getter(this); }
        #line 4 "CorporationViewModel.json"
        set {
        #line hidden
            Template.Franchies.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiesName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiesName {
    #line 5 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.FranchiesName.Getter(this); }
        #line 5 "CorporationViewModel.json"
        set {
        #line hidden
            Template.FranchiesName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__AddNewFranchies__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddNewFranchies {
    #line 6 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.AddNewFranchies.Getter(this); }
        #line 6 "CorporationViewModel.json"
        set {
        #line hidden
            Template.AddNewFranchies.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByNoOfHomes__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByNoOfHomes {
    #line 7 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortByNoOfHomes.Getter(this); }
        #line 7 "CorporationViewModel.json"
        set {
        #line hidden
            Template.SortByNoOfHomes.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByTotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByTotalCommission {
    #line 8 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortByTotalCommission.Getter(this); }
        #line 8 "CorporationViewModel.json"
        set {
        #line hidden
            Template.SortByTotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByAvgCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByAvgCommission {
    #line 9 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortByAvgCommission.Getter(this); }
        #line 9 "CorporationViewModel.json"
        set {
        #line hidden
            Template.SortByAvgCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortByTrend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortByTrend {
    #line 10 "CorporationViewModel.json"
        get {
        #line hidden
            return Template.SortByTrend.Getter(this); }
        #line 10 "CorporationViewModel.json"
        set {
        #line hidden
            Template.SortByTrend.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiesName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewFranchies : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByNoOfHomes : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByTotalCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByAvgCommission : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SortByTrend : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
