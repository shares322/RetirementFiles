#pragma checksum "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9de1498dab94f21305d7952beafdc14d7e76e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee), @"mvc.1.0.view", @"/Views/Home/Employee.cshtml")]
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
#line 1 "C:\Repos\Assessment6Mock\Views\_ViewImports.cshtml"
using Assessment6Mock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\Assessment6Mock\Views\_ViewImports.cshtml"
using Assessment6Mock.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9de1498dab94f21305d7952beafdc14d7e76e5", @"/Views/Home/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360f77e6e938adf60b9c8fd0c54c658a4bcc5ab1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assessment6Mock.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RetirementInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Employees</h1>\r\n<div class=\"container p-3\">\r\n    <div class=\"row pt-4\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-primary\">Employee List</h2>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9de1498dab94f21305d7952beafdc14d7e76e54706", async() => {
                WriteLiteral("\r\n                Retirement Info\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <br /><br />\r\n");
#nullable restore
#line 17 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        ID
                    </th><th>
                        First Name
                    </th>
                    <th>
                        Age
                    </th>
                    <th>
                        Salary
                    </th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 37 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"10%\">");
#nullable restore
#line 40 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                               Write(obj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50%\">");
#nullable restore
#line 41 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                               Write(obj.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 42 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                               Write(obj.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 43 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                               Write(obj.Salary.ToString("C", new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 48 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No category exists</p>\r\n");
#nullable restore
#line 52 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
#nullable restore
#line 56 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
 using (@Html.BeginForm("RetirementInfo", "Home", FormMethod.Post))
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"EmployeeId\" class=\"text-primary\">Employee ID</label>\r\n    <input id=\"employeeId\" name=\"employeeId\" type=\"number\"/>\r\n    <input id=\"Submit\" type=\"submit\" value=\"Submit\"/>\r\n");
#nullable restore
#line 61 "C:\Repos\Assessment6Mock\Views\Home\Employee.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef9de1498dab94f21305d7952beafdc14d7e76e59750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assessment6Mock.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
