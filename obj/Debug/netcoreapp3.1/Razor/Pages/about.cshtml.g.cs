#pragma checksum "/Users/na/Documents/programming/Antar/dotnet/213motorrade/Pages/about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c50b99704ed98192afbe1101f077409e2fa20c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(myblog.Pages.Pages_about), @"mvc.1.0.razor-page", @"/Pages/about.cshtml")]
namespace myblog.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/na/Documents/programming/Antar/dotnet/213motorrade/Pages/_ViewImports.cshtml"
using myblog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c50b99704ed98192afbe1101f077409e2fa20c9", @"/Pages/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a8cf2ad76b9f1028ccbabf6f7736964d222a75", @"/Pages/_ViewImports.cshtml")]
    public class Pages_about : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/na/Documents/programming/Antar/dotnet/213motorrade/Pages/about.cshtml"
  
    ViewData["Title"] = "Le Club";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
  
  <section>
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-6"">
          <h1 class=""mt-5"">213 Motorrade</h1>
          <h3 class=""mt-5"">Le Club</h1>

          <p>Motorrade est Le premier club Algerien dédié à la moto et aux roadtrips. Une initiative née de fondateurs passionnés par la moto et les trips dans le vaste paysage algérien riche de sa diversité naturelle dans le but de promouvoir le tourisme tant local qu'international.</p>
        </div>
      </div>
    </div>
  </section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
