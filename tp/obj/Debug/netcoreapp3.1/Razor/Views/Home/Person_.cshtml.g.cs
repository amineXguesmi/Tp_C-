#pragma checksum "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb8e42ab9f08620ab65ee2377132de48acf1646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Person_), @"mvc.1.0.view", @"/Views/Home/Person_.cshtml")]
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
#line 1 "C:\Users\semah\source\repos\tp\tp\Views\_ViewImports.cshtml"
using tp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semah\source\repos\tp\tp\Views\_ViewImports.cshtml"
using tp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb8e42ab9f08620ab65ee2377132de48acf1646", @"/Views/Home/Person_.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82b13f63f6bbe5f124dcd2a1cafe860565cfc16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Person_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""alert-danger text-center"">list of person </h1>
<table class=""table-bordered"">
    <thead>
        <tr>
            <th>
                id
            </th>
            <th>
                First name
            </th>
            <th>
                Last name
            </th>
            <th>
                email
            </th>
            <th>
                Date of birth
            </th>
            <th>
                image
            </th>
            <th>
                country
            </th>
        </tr>
    </thead>
");
#nullable restore
#line 29 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
     foreach (Person p in ViewBag.Person_List)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 32 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 33 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 34 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 35 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 36 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.date_birth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th><a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 797, 1);
#nullable restore
#line 37 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
WriteAttributeValue("", 789, p.image, 789, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
                      Write(p.image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n    <th>");
#nullable restore
#line 38 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
   Write(p.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n</tr>\r\n");
#nullable restore
#line 40 "C:\Users\semah\source\repos\tp\tp\Views\Home\Person_.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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