#pragma checksum "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e48943fb74aaea92d21304d7e48680c07bded3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e48943fb74aaea92d21304d7e48680c07bded3a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.PersonViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 8, true);
            WriteLiteral("\r\n\r\n<h2>");
            EndContext();
            BeginContext(61, 11, false);
#line 4 "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(72, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
#line 7 "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
 foreach(var p in Model.Person)
{

#line default
#line hidden
            BeginContext(119, 25, true);
            WriteLiteral("    <div>\r\n\r\n        <h2>");
            EndContext();
            BeginContext(145, 11, false);
#line 11 "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
       Write(p.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(156, 19, true);
            WriteLiteral("</h2>\r\n        <h3>");
            EndContext();
            BeginContext(176, 10, false);
#line 12 "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
       Write(p.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(186, 21, true);
            WriteLiteral("</h3>\r\n\r\n    </div>\r\n");
            EndContext();
#line 15 "\\Mac\Home\Desktop\GitProjects\Windows\Samples\MVC Core WebApp\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
    
}

#line default
#line hidden
            BeginContext(216, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.PersonViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
