﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClashSinicizationTool.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClashSinicizationTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 [Script Path]
        ///翻译脚本.txt
        ///
        ///[Clash Path]
        /// 的本地化字符串。
        /// </summary>
        public static string cacheList {
            get {
                return ResourceManager.GetString("cacheList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap GitHub_Logo {
            get {
                object obj = ResourceManager.GetObject("GitHub Logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Icon logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 ;(function (global, factory) {
        ///    typeof exports === &apos;object&apos; &amp;&amp; typeof module !== &apos;undefined&apos; ? module.exports = factory() :
        ///    typeof define === &apos;function&apos; &amp;&amp; define.amd ? define(factory) :
        ///    global.moment = factory()
        ///}(this, (function () { &apos;use strict&apos;;
        ///
        ///    var hookCallback;
        ///
        ///    function hooks() {
        ///        return hookCallback.apply(null, arguments);
        ///    }
        ///
        ///    function setHookCallback(callback) {
        ///        hookCallback = callback;
        ///    }
        ///
        ///    function isArray(input) {
        ///        return (        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string moment_with_CN {
            get {
                return ResourceManager.GetString("moment_with_CN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 [Replace Path]
        ///\resources\app\dist\electron\renderer.js
        ///\resources\app\dist\electron\main.js
        ///\resources\app\node_modules\axios\lib\adapters\xhr.js
        ///\resources\app\node_modules\axios\dist\axios.js
        ///\resources\app\node_modules\axios\dist\axios.min.js
        ///\resources\app\node_modules\axios\dist\axios.map
        ///\resources\app\node_modules\axios\dist\axios.min.map
        /// 的本地化字符串。
        /// </summary>
        public static string pathList {
            get {
                return ResourceManager.GetString("pathList", resourceCulture);
            }
        }
    }
}
