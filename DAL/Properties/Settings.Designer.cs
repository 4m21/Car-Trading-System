﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-KIBRTKOB\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated" +
            " Security=True;TrustServerCertificate=True")]
        public string ABC_Car_TradersConnectionString1 {
            get {
                return ((string)(this["ABC_Car_TradersConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-C79L4FJ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated" +
            " Security=True;Trust Server Certificate=True")]
        public string ABC_Car_TradersConnectionString {
            get {
                return ((string)(this["ABC_Car_TradersConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-C79L4FJ\\SQLEXPRESS;Initial Catalog=ABC_Car_Traders;Integrated" +
            " Security=True;TrustServerCertificate=True")]
        public string ABC_Car_TradersConnectionString2 {
            get {
                return ((string)(this["ABC_Car_TradersConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-C79L4FJ\\SQLEXPRESS;Integrated Security=True;TrustServerCertif" +
            "icate=True")]
        public string DataSourceConnectionString {
            get {
                return ((string)(this["DataSourceConnectionString"]));
            }
        }
    }
}
