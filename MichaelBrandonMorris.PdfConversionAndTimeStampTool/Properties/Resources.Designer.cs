﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MichaelBrandonMorris.PdfConversionAndTimeStampTool.Properties {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class Resources {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("MichaelBrandonMorris.PdfConversionAndTimeStampTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var f = this.getField(&apos;Timestamp&apos;);
        ///f.alignment = &apos;left&apos;;
        ///f.multiline = false;
        ///f.textSize = 11;
        ///f.richText = true;
        ///var style = f.defaultStyle;
        ///style.fontFamily = [&apos;Calibri&apos;, &apos;sans-serif&apos;];
        ///f.defaultStyle = style;
        ///var t = new Array();
        ///t[0] = new Object();
        ///t[0].text = &apos;Uncontrolled 24 hours after &apos;;
        ///t[1] = new Object();
        ///t[1].text = util.printd(&apos;mm/dd/yy h:MM tt&apos;, new Date());
        ///f.richValue = t;.
        /// </summary>
        internal static string TimeStampDay {
            get {
                return ResourceManager.GetString("TimeStampDay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?var f = this.getField(&apos;Timestamp&apos;);
        ///f.alignment = &apos;left&apos;;
        ///f.multiline = false;
        ///f.textSize = 11;
        ///f.richText = true;
        ///var style = f.defaultStyle;
        ///style.fontFamily = [&apos;Calibri&apos;, &apos;sans-serif&apos;];
        ///f.defaultStyle = style;
        ///var t = new Array();
        ///t[0] = new Object();
        ///t[0].text = &apos;Uncontrolled 30 days after &apos;;
        ///t[1] = new Object();
        ///t[1].text = util.printd(&apos;mm/dd/yy h:MM tt&apos;, new Date());
        ///f.richValue = t;.
        /// </summary>
        internal static string TimeStampMonth {
            get {
                return ResourceManager.GetString("TimeStampMonth", resourceCulture);
            }
        }
    }
}