#pragma checksum "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce76045f206f8e2da24c858331f434f92b99c53b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flowers_ListDates), @"mvc.1.0.view", @"/Views/Flowers/ListDates.cshtml")]
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
#line 1 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\_ViewImports.cshtml"
using Project_P_ASP.NET.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\_ViewImports.cshtml"
using Project_P_ASP.NET.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce76045f206f8e2da24c858331f434f92b99c53b", @"/Views/Flowers/ListDates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a5fcbc1560e19cd48a83d07931c25df3263eb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Flowers_ListDates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>");
#nullable restore
#line 1 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h2>Квіти для побачень</h2>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 4 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
      
        foreach (var flower in Model.allFlowers)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
             if (flower.Category.categoryName == "Для побачень")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 324, "\"", 341, 1);
#nullable restore
#line 10 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
WriteAttributeValue("", 330, flower.img, 330, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 342, "\"", 360, 1);
#nullable restore
#line 10 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
WriteAttributeValue("", 348, flower.name, 348, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h2>Назва: ");
#nullable restore
#line 11 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
                          Write(flower.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 12 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
                  Write(flower.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Ціна: ");
#nullable restore
#line 13 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
                        Write(flower.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"btn btn-warning\" href=\"#\">Детальніше</p>\r\n                </div>\r\n");
#nullable restore
#line 16 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ХНУРЭ\6СЕМ\Р ASP.NET\Проект_Р ASP.NET\Project_P ASP.NET\Project_P ASP.NET\Views\Flowers\ListDates.cshtml"
             
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
