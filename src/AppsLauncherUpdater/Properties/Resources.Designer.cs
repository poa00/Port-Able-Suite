﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Updater.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Updater.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to @echo off
        ///title &quot;{0}&quot;
        ///for %%s in (
        ///AppsDownloader
        ///AppsDownloader64
        ///AppsLauncher
        ///AppsLauncher64 ) do taskkill /F /IM &quot;%%s.exe&quot; &gt;nul 2&gt;&amp;1
        ///set &quot;extractor=7z.exe&quot;
        ///if not exist %extractor% set &quot;extractor=7zG.exe&quot;
        ///if exist %extractor% %extractor% x Update.7z -o&quot;{1}\&quot; -y
        ///ping localhost -n 5 &gt;nul
        ///for %%s in (
        ///7z.dll
        ///7z.exe
        ///7zG.exe
        ///LICENSE.txt
        ///Update.7z ) do if exist &quot;%%s&quot; del /F /Q &quot;%%s&quot;
        ///set path=%WinDir%\System32\cmd.exe
        ///if exist %0 start &quot;{2}&quot; %path% /C del /F /Q %0 &amp;&amp; taskkill /FI &quot;{0}&quot; /IM cmd [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BatchDummy {
            get {
                return ResourceManager.GetString("BatchDummy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Changelog {
            get {
                object obj = ResourceManager.GetObject("Changelog", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /// Port-Able Suite - Version History:
        ///
        /// Website: https://www.port-a.de
        /// License: https://git.io/fmKti
        /// Sources: https://git.io/fmrjV
        /// Library: https://git.io/vb5Vg
        /// Support: https://support.si13n7.de
        ///
        ///____________________________________________________________________________________
        ///
        ///
        ///{0}.
        /// </summary>
        internal static string ChangeLogTemplate {
            get {
                return ResourceManager.GetString("ChangeLogTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launcher.
        /// </summary>
        internal static string ConfigSection {
            get {
                return ResourceManager.GetString("ConfigSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap diagonal_pattern {
            get {
                object obj = ResourceManager.GetObject("diagonal_pattern", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port-Able Suite Updater.
        /// </summary>
        internal static string GlobalTitle {
            get {
                return ResourceManager.GetString("GlobalTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Logo {
            get {
                object obj = ResourceManager.GetObject("Logo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
