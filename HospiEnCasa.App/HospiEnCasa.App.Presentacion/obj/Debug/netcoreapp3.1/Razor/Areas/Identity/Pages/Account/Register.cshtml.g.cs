#pragma checksum "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175e233bf0226cf8e60734aec011b7e384a2bf01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Register.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Register), null)]
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
#line 1 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion.Areas.Identity;

#line default
#line hidden
#line 3 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"175e233bf0226cf8e60734aec011b7e384a2bf01", @"/Areas/Identity/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f9fa0e338bad55bf667f10edcdb863d5bba2fc", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab9cb95298e25b3b3d937e408d956bf6e8abb7b", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("external-account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(73, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(80, 17, false);
#line 7 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 64, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(161, 1333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf018179", async() => {
                BeginContext(220, 78, true);
                WriteLiteral("\r\n            <h4>Create a new account.</h4>\r\n            <hr />\r\n            ");
                EndContext();
                BeginContext(298, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf018641", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(358, 56, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(414, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0110541", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 16 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(451, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(469, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "175e233bf0226cf8e60734aec011b7e384a2bf0112235", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(521, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(539, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0114010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 18 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(605, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(681, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0115925", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 21 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(721, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(739, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "175e233bf0226cf8e60734aec011b7e384a2bf0117622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(794, 365, true);
                WriteLiteral(@"
                <!--<span asp-validation-for=""Input.Password"" class=""text-danger""></span>-->
                <span class=""field-validation-error text-danger"" 
            data-valmsg-for=""Input.Password"" 
            data-valmsg-replace=""true"">El campo contraseña es requerido.</span>
            </div>
            <div class=""form-group"">
                ");
                EndContext();
                BeginContext(1159, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0119760", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 29 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.ConfirmPassword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1206, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1224, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "175e233bf0226cf8e60734aec011b7e384a2bf0121466", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.ConfirmPassword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1286, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1304, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0123253", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 31 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.ConfirmPassword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1380, 107, true);
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                       WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1494, 152, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6 col-md-offset-2\">\r\n        <section>\r\n            <h4>Use another service to register.</h4>\r\n            <hr />\r\n");
            EndContext();
#line 40 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
            BeginContext(1743, 404, true);
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
            EndContext();
#line 49 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2207, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2227, 651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "175e233bf0226cf8e60734aec011b7e384a2bf0128837", async() => {
                BeginContext(2359, 66, true);
                WriteLiteral("\r\n                        <div>\r\n                            <p>\r\n");
                EndContext();
#line 55 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {

#line default
#line hidden
                BeginContext(2541, 97, true);
                WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2638, "\"", 2660, 1);
#line 57 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue("", 2646, provider.Name, 2646, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2661, "\"", 2716, 6);
                WriteAttributeValue("", 2669, "Log", 2669, 3, true);
                WriteAttributeValue(" ", 2672, "in", 2673, 3, true);
                WriteAttributeValue(" ", 2675, "using", 2676, 6, true);
                WriteAttributeValue(" ", 2681, "your", 2682, 5, true);
#line 57 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
WriteAttributeValue(" ", 2686, provider.DisplayName, 2687, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2708, "account", 2709, 8, true);
                EndWriteAttribute();
                BeginContext(2717, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2719, 20, false);
#line 57 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(2739, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 58 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                                }

#line default
#line hidden
                BeginContext(2785, 86, true);
                WriteLiteral("                            </p>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                                                                                    WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2878, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "D:\MISION TIC 2022\CICLO 3\Grupo 47\ProyectoFormacion\HospiEnCasa.App\hospiencasa.app.presentacion\Areas\Identity\Pages\Account\Register.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2914, 42, true);
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2974, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2980, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "175e233bf0226cf8e60734aec011b7e384a2bf0135321", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3024, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
