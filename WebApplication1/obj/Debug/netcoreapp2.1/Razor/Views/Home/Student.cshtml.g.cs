#pragma checksum "C:\Users\KESCO\source\repos\WebApplication1\WebApplication1\Views\Home\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0c0a44b1617e6cfadb5824509921a485556dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Student), @"mvc.1.0.view", @"/Views/Home/Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Student.cshtml", typeof(AspNetCore.Views_Home_Student))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0c0a44b1617e6cfadb5824509921a485556dc2", @"/Views/Home/Student.cshtml")]
    public class Views_Home_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 934, true);
            WriteLiteral(@"<link rel= ""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">
<h3>Add New Student</h3>
<form class=""form form-horizontal"" method=""POST"">
    <div class=""form-group"">
        <img src=""https://image.ibb.co/iKfYKx/computer.jpg"" />
    </div>
    <div class=""form-group"">
        <div class=""col-md-3"">
            <label>Name:</label>
            <input type=""text"" class=""form-control"" name=""name"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-3"">
            <label>Age:</label>
            <input type=""text"" class=""form-control"" name=""age"">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-3"">
            <label>Contury:</label>
            <input type=""text"" class=""form-control"" name=""country"">
        </div>
    </div>
    <button type=""submit"" class=""btn btn-default"">Submit</button>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
