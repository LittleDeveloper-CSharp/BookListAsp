#pragma checksum "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a941fbc12aed89bab81f1dfc155c4696ff4f117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetListAuthor), @"mvc.1.0.view", @"/Views/Book/GetListAuthor.cshtml")]
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
#line 1 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\_ViewImports.cshtml"
using BookListAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\_ViewImports.cshtml"
using BookListAsp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a941fbc12aed89bab81f1dfc155c4696ff4f117", @"/Views/Book/GetListAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3260afc9fb65fe45a36fb1e372229a2c17b4cc31", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetListAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClassesModels.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
      
    ViewData["Title"] = "Список авторов";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <table>
            <thead>
                <tr>
                    <th>id</th>
                    <th>FirstName</th>
                    <th>LastName</th>
                    <th>Patronymic</th>
                    <th>Birthyear</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                 foreach(var i in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                   Write(i.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                   Write(i.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                   Write(i.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                   Write(i.Patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
                   Write(i.Birthyear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a>Изменить</a></td>\r\n                    <td><a>Удалить</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Popka\source\repos\BookAccounting\BookListAsp\Views\Book\GetListAuthor.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClassesModels.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591