#pragma checksum "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07cb5f7c838cfb6ffd0cd521af7ea8bd31b7b8d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialCategories), @"mvc.1.0.view", @"/Views/Shared/_PartialCategories.cshtml")]
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
#line 1 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\_ViewImports.cshtml"
using TahaBloggerProject.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\_ViewImports.cshtml"
using TahaBloggerProject.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
using TahaBloggerProject.Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cb5f7c838cfb6ffd0cd521af7ea8bd31b7b8d7", @"/Views/Shared/_PartialCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6d0eeaaa3cb5905b71f3c46b8ab466a07c7194", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<p class=\"lead\">Kategoriler</p>\r\n<div class=\"list-group\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 137, "\"", 171, 1);
#nullable restore
#line 8 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
WriteAttributeValue("", 144, Url.Action("Index","Home"), 144, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\"> <span class=\"glyphicon glyphicon-arrow-right\"></span>Tümü</a>\r\n");
#nullable restore
#line 9 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
         foreach (var item in Model)
        {
            //Category controllerin altında select action unda  category id ye git

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 440, "\"", 480, 2);
            WriteAttributeValue("", 447, "/Category/Select/", 447, 17, true);
#nullable restore
#line 14 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
WriteAttributeValue("", 464, item.CategoryId, 464, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 481, "\"", 500, 1);
#nullable restore
#line 14 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
WriteAttributeValue("", 489, item.Title, 489, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item\"><span class=\"glyphicon glyphicon-arrow-right\"></span>");
#nullable restore
#line 14 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
                                                                                                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 15 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Project\TahasBlog\TahaBloggerProject\TahaBloggerProject.UI\Views\Shared\_PartialCategories.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
