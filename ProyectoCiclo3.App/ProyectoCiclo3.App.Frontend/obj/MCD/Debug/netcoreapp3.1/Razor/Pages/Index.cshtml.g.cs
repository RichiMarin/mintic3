#pragma checksum "E:\mintic\Ciclo III\Desarrollo web\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e758766912cd0c9081e034f758dc725db2d8b40b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages
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
#line 1 "E:\mintic\Ciclo III\Desarrollo web\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e758766912cd0c9081e034f758dc725db2d8b40b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\mintic\Ciclo III\Desarrollo web\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h1 class=""display-4"">Bienvenido</h1>
        <div id=""carouselExampleControls"" class=""carousel slide"" data-bs-ride=""carousel"">
        <div class=""carousel-inner"" hidden:1200px>
            <div class=""carousel-item active"">
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjEOUxuO2zKUlAst-vMOiIiAOKLII-ZYGOZQ&usqp=CAU"" class=""d-block w-100"" alt=""..."">
            </div>
            <div class=""carousel-item"">
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXW7Wyoxw1mBV858Q8lb4WblmKq36q2xdx9A&usqp=CAU"" class=""d-block w-100"" alt=""..."">
            </div>
            <div class=""carousel-item"">
            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGWg9IYxzO0dRXi0jpzYvmLVcom9gJBbumHQ&usqp=CAU"" class=""d-block w-100"" alt=""..."">
            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleControls"" data-bs-slide=""prev"">
            <span class=""carousel-");
            WriteLiteral(@"control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleControls"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
        </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
