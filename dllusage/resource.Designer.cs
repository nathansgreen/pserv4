﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dllusage {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dllusage.resource", typeof(resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Copy to clipboard.
        /// </summary>
        internal static string IDS_COPY_TO_CLIPBOARD {
            get {
                return ResourceManager.GetString("IDS_COPY_TO_CLIPBOARD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DLLs by name.
        /// </summary>
        internal static string IDS_ModulesByName {
            get {
                return ResourceManager.GetString("IDS_ModulesByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DLLs by path.
        /// </summary>
        internal static string IDS_ModulesByPath {
            get {
                return ResourceManager.GetString("IDS_ModulesByPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EXEs by name.
        /// </summary>
        internal static string IDS_ProcessesByName {
            get {
                return ResourceManager.GetString("IDS_ProcessesByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EXEs by path.
        /// </summary>
        internal static string IDS_ProcessesByPath {
            get {
                return ResourceManager.GetString("IDS_ProcessesByPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show Properties.
        /// </summary>
        internal static string IDS_PROPERTIES {
            get {
                return ResourceManager.GetString("IDS_PROPERTIES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save as XML.
        /// </summary>
        internal static string IDS_SAVE_AS_XML {
            get {
                return ResourceManager.GetString("IDS_SAVE_AS_XML", resourceCulture);
            }
        }
    }
}