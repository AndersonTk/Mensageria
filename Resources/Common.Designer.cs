﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Common {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Common() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Common", typeof(Common).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string CATEGORY_LBL_NAME {
            get {
                return ResourceManager.GetString("CATEGORY_LBL_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field {0} is required.
        /// </summary>
        public static string DATA_ANOTATION_REQUIRED {
            get {
                return ResourceManager.GetString("DATA_ANOTATION_REQUIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identifier.
        /// </summary>
        public static string ENTITY_LBL_IDENTIFIER {
            get {
                return ResourceManager.GetString("ENTITY_LBL_IDENTIFIER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found.
        /// </summary>
        public static string EXCEPTION_MSG_NOT_FOUND {
            get {
                return ResourceManager.GetString("EXCEPTION_MSG_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} cannot be null.
        /// </summary>
        public static string EXCEPTION_MSG_THE_PROPERTY_CANNOT_BE_NULL {
            get {
                return ResourceManager.GetString("EXCEPTION_MSG_THE_PROPERTY_CANNOT_BE_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product category.
        /// </summary>
        public static string PRODUCT_LBL_CATEGORY {
            get {
                return ResourceManager.GetString("PRODUCT_LBL_CATEGORY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string PRODUCT_LBL_NAME {
            get {
                return ResourceManager.GetString("PRODUCT_LBL_NAME", resourceCulture);
            }
        }
    }
}
