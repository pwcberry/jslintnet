﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JSLintNet;

[assembly: AssemblyTitle("JSLint.NET")]
[assembly: AssemblyCompany(AssemblyInfo.Company)]
[assembly: AssemblyProduct(AssemblyInfo.Product)]
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]
[assembly: AssemblyVersion(AssemblyInfo.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.Version)]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: Guid("683a3b2e-608a-463b-8046-85e856294a34")]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: InternalsVisibleTo("JSLintNet.Console")]
[assembly: InternalsVisibleTo("JSLintNet.VisualStudio")]
[assembly: InternalsVisibleTo("JSLintNet.QualityTools")]
[assembly: InternalsVisibleTo("JSLintNet.Specifications")]
[assembly: InternalsVisibleTo("JSLintNet.Console.Specifications")]
[assembly: InternalsVisibleTo("JSLintNet.VisualStudio.Specifications")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace JSLintNet
{
    /// <summary>
    /// Version number and copyright constants for sharing between projects.
    /// </summary>
    public static class AssemblyInfo
    {
        /// <summary>
        /// The full version number for JSLint.NET.
        /// </summary>
        public const string Version = "1.8.0";

        /// <summary>
        /// The copyright line for JSLint.NET.
        /// </summary>
        public const string Copyright = "Copyright © JSLint.NET Contributors 2013-2014";

        /// <summary>
        /// The company name for JSLint.NET.
        /// </summary>
        public const string Company = "JSLint.NET Contributors";

        /// <summary>
        /// The product name for JSLint.NET.
        /// </summary>
        public const string Product = "JSLint.NET";

        /// <summary>
        /// The edition of JSLint bundled with this release.
        /// </summary>
        public const string Edition = "2014-07-08";
    }
}
