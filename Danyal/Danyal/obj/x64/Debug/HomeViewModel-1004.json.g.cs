// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "HomeViewModel.json"
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
using __HomeView1__ = global::Danyal.HomeViewModel.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __HoAddNewCo__ = global::Danyal.HomeViewModel.Input.AddNewCorporation;
using __HoNewCorpo__ = global::Danyal.HomeViewModel.Input.NewCorporationName;
using __HoHtml__ = global::Danyal.HomeViewModel.Input.Html;
using __HomeView2__ = global::Danyal.HomeViewModel.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TString__ = global::Starcounter.Templates.TString;
using __HoSchema__ = global::Danyal.HomeViewModel.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __HomeView__ = global::Danyal.HomeViewModel;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class HomeViewModel_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class HomeViewModel : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __HoSchema__ DefaultTemplate = new __HoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HomeViewModel() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HomeViewModel(__HoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __HoSchema__ Template { get { return (__HoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__HomeView__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/View/HomeView.html";
                Html.SetCustomAccessors((_p_) => { return ((__HomeView__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__HomeView__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Corporations = Add<__TArray__>("Corporations");
                Corporations.SetCustomAccessors((_p_) => { return ((__HomeView__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__HomeView__)_p_).__bf__Corporations__ = (__Arr__)_v_; }, false);
                NewCorporationName = Add<__TString__>("NewCorporationName$");
                NewCorporationName.DefaultValue = "";
                NewCorporationName.Editable = true;
                NewCorporationName.SetCustomAccessors((_p_) => { return ((__HomeView__)_p_).__bf__NewCorporationName__; }, (_p_, _v_) => { ((__HomeView__)_p_).__bf__NewCorporationName__ = (System.String)_v_; }, false);
                AddNewCorporation = Add<__TString__>("AddNewCorporation$");
                AddNewCorporation.DefaultValue = "";
                AddNewCorporation.Editable = true;
                AddNewCorporation.SetCustomAccessors((_p_) => { return ((__HomeView__)_p_).__bf__AddNewCorporation__; }, (_p_, _v_) => { ((__HomeView__)_p_).__bf__AddNewCorporation__ = (System.String)_v_; }, false);
                AddNewCorporation.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.AddNewCorporation() { App = (HomeViewModel)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((HomeViewModel)pup).Handle((Input.AddNewCorporation)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __HomeView__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ Corporations;
            public __TString__ NewCorporationName;
            public __TString__ AddNewCorporation;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "HomeViewModel.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "HomeViewModel.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Corporations__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Corporations {
    #line 3 "HomeViewModel.json"
        get {
        #line hidden
            return Template.Corporations.Getter(this); }
        #line 3 "HomeViewModel.json"
        set {
        #line hidden
            Template.Corporations.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewCorporationName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewCorporationName {
    #line 4 "HomeViewModel.json"
        get {
        #line hidden
            return Template.NewCorporationName.Getter(this); }
        #line 4 "HomeViewModel.json"
        set {
        #line hidden
            Template.NewCorporationName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__AddNewCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String AddNewCorporation {
    #line 5 "HomeViewModel.json"
        get {
        #line hidden
            return Template.AddNewCorporation.Getter(this); }
        #line 5 "HomeViewModel.json"
        set {
        #line hidden
            Template.AddNewCorporation.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__HomeView__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewCorporationName : Input<__HomeView__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddNewCorporation : Input<__HomeView__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
