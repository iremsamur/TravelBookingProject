#pragma checksum "C:\Users\User\Desktop\C# Projects\TravelBooking\TravelBooking\Views\LayoutPartial\_NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ca441a3429c3327df23874ade6748697930d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__NavbarPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\User\Desktop\C# Projects\TravelBooking\TravelBooking\Views\_ViewImports.cshtml"
using TravelBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\C# Projects\TravelBooking\TravelBooking\Views\_ViewImports.cshtml"
using TravelBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\C# Projects\TravelBooking\TravelBooking\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ca441a3429c3327df23874ade6748697930d5a", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af2987ac249f1986ab482b5451f90d4f04fc4c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
  <header id=""site-header"" class=""fixed-top"">
    <div class=""container"">
      <nav class=""navbar navbar-expand-lg stroke"">
        <h1><a class=""navbar-brand mr-lg-5"" href=""index.html"">
            Traversal
          </a></h1>
        <!-- if logo is image enable this   
      <a class=""navbar-brand"" href=""#index.html"">
          <img src=""image-path"" alt=""Your logo"" title=""Your logo"" style=""height:35px;"" />
      </a> -->
        <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse""
          data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
          aria-label=""Toggle navigation"">
          <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
          <span class=""navbar-toggler-icon fa icon-close fa-times""></span>
         
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo02"">
          <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item act");
            WriteLiteral(@"ive"">
              <a class=""nav-link"" href=""index.html"">Ana Sayfa <span class=""sr-only"">(current)</span></a>
            </li>
            <li class=""nav-item"">
              <a class=""nav-link"" href=""about.html"">Hakkımızda</a>
            </li>
            <li class=""nav-item"">
              <a class=""nav-link"" href=""services.html"">Rotalar</a>
            </li>

            <li class=""nav-item"">
              <a class=""nav-link"" href=""contact.html"">İletişim</a>
            </li>

          </ul>
        </div>
        <div class=""d-lg-block d-none"">
          <a href=""contact.html"" class=""btn btn-style btn-secondary"">Rezervasyon Yap</a>
        </div>
        <!-- toggle switch for light and dark theme -->
        <div class=""mobile-position"">
          <nav class=""navigation"">
            <div class=""theme-switch-wrapper"">
              <label class=""theme-switch"" for=""checkbox"">
                <input type=""checkbox"" id=""checkbox"">
                <div class=""mode-container"">
  ");
            WriteLiteral(@"                <i class=""gg-sun""></i>
                  <i class=""gg-moon""></i>
                </div>
              </label>
            </div>
          </nav>
        </div>
        <!-- //toggle switch for light and dark theme -->
      </nav>
    </div>
  </header>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
