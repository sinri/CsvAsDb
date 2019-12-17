﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsvAsDb.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsvAsDb.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 # 支持信息
        ///
        ///----
        ///
        ///## 更新历史
        ///
        ///[ Beta Version, 2019-12-13 ]
        ///
        ///Add the Leqee Finance CSV Worker main function here, which is inspired by Lina Yu the Great years before.
        ///
        ///[ Alpha Version, 2019-12-11 ]
        ///
        ///Turn your CSVs in one directory into database and query with any possible SQL.
        ///
        ///This toolkit is inspired by Shaoqiao Wang the Great in Dec 9th, 2019 AD.
        ///
        ///----
        ///
        ///## 声明
        ///
        ///该程序使用了第三方库 System.Data.SQLite 以及 CsvHelper。该程序基于 .NET Framework 4.7 构建。
        ///
        ///Copyright 2019 Sinri Edogawa
        ///
        ///维护者联系方式 &lt;ljni@leqee.com&gt;
        ///        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string AboutContentFile {
            get {
                return ResourceManager.GetString("AboutContentFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 王神A套餐 【WSQ_A】
        ///
        ///根据三个字段，业务类型、备注、对方账号，进行组合统计并作合计。选好文件夹和插件，导入，以默认SQL查询，如此傻瓜操作即可。 的本地化字符串。
        /// </summary>
        internal static string PluginDescWsqA {
            get {
                return ResourceManager.GetString("PluginDescWsqA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 喻神A套餐 【YLN_A】 
        ///
        ///根据业务类型和备注，按照预设分类字典进行分类，并按照分类进行统计。
        ///这个插件要求提前导入或编辑好分类字典，然后再导入，并按默认SQL查询即可。 的本地化字符串。
        /// </summary>
        internal static string PluginDescYlnA {
            get {
                return ResourceManager.GetString("PluginDescYlnA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 张神A套餐 【ZY_A】 
        ///
        ///根据备注，按照预设分类字典进行分类，并按照分类和业务类型进行统计。按照指示，大小写不敏感。
        ///这个插件要求提前导入或编辑好分类字典，然后再导入，并按默认SQL查询即可。 的本地化字符串。
        /// </summary>
        internal static string PluginDescZyA {
            get {
                return ResourceManager.GetString("PluginDescZyA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 1.0 的本地化字符串。
        /// </summary>
        internal static string ProjectVersion {
            get {
                return ResourceManager.GetString("ProjectVersion", resourceCulture);
            }
        }
    }
}
