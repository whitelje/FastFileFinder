﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFind {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Constants {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Constants() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FastFind.Constants", typeof(Constants).Assembly);
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
        ///   Looks up a localized string similar to The array must not be null or of zero length..
        /// </summary>
        internal static string ArrayMustBeValid {
            get {
                return ResourceManager.GetString("ArrayMustBeValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error on the &apos;{0}&apos; switch..
        /// </summary>
        internal static string ErrorSwitch {
            get {
                return ResourceManager.GetString("ErrorSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid parameter was passed to the method.
        /// </summary>
        internal static string InvalidParameter {
            get {
                return ResourceManager.GetString("InvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Invalid regular expression: &apos;{0}&apos; Error : {1}&quot;.
        /// </summary>
        internal static string InvalidRegExFmt {
            get {
                return ResourceManager.GetString("InvalidRegExFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No search patterns were specified..
        /// </summary>
        internal static string NoPatternsSpecified {
            get {
                return ResourceManager.GetString("NoPatternsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one -path switch at a time may be used..
        /// </summary>
        internal static string PathMultipleSwitches {
            get {
                return ResourceManager.GetString("PathMultipleSwitches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path directory does not exist or ends in &apos;\&apos; which Windows command line parsing does not like..
        /// </summary>
        internal static string PathNotExist {
            get {
                return ResourceManager.GetString("PathNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total directories processed : {0}.
        /// </summary>
        internal static string TotalDirectoriesFmt {
            get {
                return ResourceManager.GetString("TotalDirectoriesFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total files processed       : {0}.
        /// </summary>
        internal static string TotalFilesFmt {
            get {
                return ResourceManager.GetString("TotalFilesFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total matches               : {0}.
        /// </summary>
        internal static string TotalMatchesFmt {
            get {
                return ResourceManager.GetString("TotalMatchesFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total matches size          : {0} bytes.
        /// </summary>
        internal static string TotalMatchesSizeFmt {
            get {
                return ResourceManager.GetString("TotalMatchesSizeFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total size                  : {0} bytes.
        /// </summary>
        internal static string TotalSizeFmt {
            get {
                return ResourceManager.GetString("TotalSizeFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total execution time        : {0}ms.
        /// </summary>
        internal static string TotalTimeFmt {
            get {
                return ResourceManager.GetString("TotalTimeFmt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown command line option..
        /// </summary>
        internal static string UnknownCommandLineOption {
            get {
                return ResourceManager.GetString("UnknownCommandLineOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FF {0}
        ///(c) 2016, John Robbins/Wintellect - john@wintellect.com
        ///Find file and directory names fast!
        ///
        ///Usage: 
        ///FF [-regex] [-includedir] [-nostats] [-path &lt;directory&gt;] pattern*
        ///
        ///-regex            - Treat the patterns as regular expressions. The default 
        ///                    follows DOS wildcard usage. Make sure to use regex values 
        ///                    in patterns with this flag. (short: -re)
        ///-includedir       - Include directory names when searching for matches. The 
        ///                    default is only to look  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UsageString {
            get {
                return ResourceManager.GetString("UsageString", resourceCulture);
            }
        }
    }
}
