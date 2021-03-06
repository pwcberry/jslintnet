﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSLintNet.Properties
{


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
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JSLintNet.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error linting file: {0}{1}{2}.
        /// </summary>
        internal static string ErrorEncounteredFormat
        {
            get
            {
                return ResourceManager.GetString("ErrorEncounteredFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Total JSLint error limit reached: {0}.
        /// </summary>
        internal static string ErrorLimitReachedFormat
        {
            get
            {
                return ResourceManager.GetString("ErrorLimitReachedFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to JSLint : .
        /// </summary>
        internal static string ErrorTextPrefix
        {
            get
            {
                return ResourceManager.GetString("ErrorTextPrefix", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unhandled JSLint.NET exception limit reached: {0}.
        /// </summary>
        internal static string ExceptionLimitReachedFormat
        {
            get
            {
                return ResourceManager.GetString("ExceptionLimitReachedFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Maximum file limit reached: {0}.
        /// </summary>
        internal static string FileLimitReachedFormat
        {
            get
            {
                return ResourceManager.GetString("FileLimitReachedFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to // jslint.js
        /// </summary>
        internal static string jslint
        {
            get
            {
                return ResourceManager.GetString("jslint", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to JSLint edition from file system ({0}) cannot be lower than built-in edition ({1})..
        /// </summary>
        internal static string JSLintEditionErrorFormat
        {
            get
            {
                return ResourceManager.GetString("JSLintEditionErrorFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to // jslintnet.js
        /// </summary>
        internal static string jslintnet
        {
            get
            {
                return ResourceManager.GetString("jslintnet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An unexpected exception occurred processing file &quot;{0}&quot;: {1}.
        /// </summary>
        internal static string ProcessingExceptionFormat
        {
            get
            {
                return ResourceManager.GetString("ProcessingExceptionFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///&lt;title&gt;{1} {2}&lt;/title&gt;
        ///&lt;style&gt;
        ///{0}
        ///&lt;/style&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///    &lt;h1&gt;{1} {2}&lt;/h1&gt;
        ///    &lt;dl&gt;
        ///        &lt;dt&gt;Source Directory:&lt;/dt&gt;
        ///        &lt;dd&gt;{3}&lt;/dd&gt;
        ///        &lt;dt&gt;Settings File:&lt;/dt&gt;
        ///        &lt;dd&gt;{4}&lt;/dd&gt;
        ///        &lt;dt&gt;Processed Files:&lt;/dt&gt;
        ///        &lt;dd&gt;{5}&lt;/dd&gt;
        ///        &lt;dt&gt;Files with Errors:&lt;/dt&gt;
        ///        &lt;dd&gt;{6}&lt;/dd&gt;
        ///        &lt;dt&gt;Total Errors:&lt;/dt&gt;
        ///        &lt;dd&gt;{7}&lt;/dd&gt;
        ///    &lt;/dl&gt;
        ///{8}
        ///&lt;/body&gt;
        ///&lt;/html&gt;
        ///.
        /// </summary>
        internal static string ReportDocumentFormat
        {
            get
            {
                return ResourceManager.GetString("ReportDocumentFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to body {
        ///    font-family: Tahoma, Verdana, sans-serif;
        ///    font-size: 75%;
        ///}
        ///
        ///h2 {
        ///    background-color: #cd5c5c;
        ///    color: #ffffff;
        ///    padding: 4px 8px;
        ///}
        ///
        ///cite {
        ///    background-color: #eeeeee;
        ///    display: block;
        ///    padding: 4px 8px;
        ///    font-style: normal;
        ///}
        ///
        ///address {
        ///    float: right;
        ///    color: #999999;
        ///}
        ///.
        /// </summary>
        internal static string ReportDocumentStyle
        {
            get
            {
                return ResourceManager.GetString("ReportDocumentStyle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to     &lt;h2&gt;{0} ({1} errors)&lt;/h2&gt;
        ///    {2}
        ///.
        /// </summary>
        internal static string ReportFileFormat
        {
            get
            {
                return ResourceManager.GetString("ReportFileFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        internal static string ReportNoSettingsFiles
        {
            get
            {
                return ResourceManager.GetString("ReportNoSettingsFiles", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to JSLint Report.
        /// </summary>
        internal static string ReportTitle
        {
            get
            {
                return ResourceManager.GetString("ReportTitle", resourceCulture);
            }
        }
    }
}
