﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiaoDucPhoCap.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=TRANSAO-C20CC6F\\SQLEXPRESS;Initial Catalog=GiaoDucPhoCap;Integrated S" +
            "ecurity=True")]
        public string GiaoDucPhoCapConnectionString {
            get {
                return ((string)(this["GiaoDucPhoCapConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SAO\\SQLEXPRESS;Initial Catalog=GiaoDucPhoCap;Integrated Security=True" +
            "")]
        public string GiaoDucPhoCapConnectionString1 {
            get {
                return ((string)(this["GiaoDucPhoCapConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NHUNGKUTE-B5A9B\\SQLEXPRESS;Initial Catalog=GiaoDucPhoCap;Integrated S" +
            "ecurity=True")]
        public string GiaoDucPhoCapConnectionString2 {
            get {
                return ((string)(this["GiaoDucPhoCapConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NHATTUNG;Initial Catalog=GiaoDucPhoCap;Integrated Security=True")]
        public string GiaoDucPhoCapConnectionString3 {
            get {
                return ((string)(this["GiaoDucPhoCapConnectionString3"]));
            }
        }
    }
}
