#pragma checksum "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beba9cdc44de231e04c47db1536b683278ac0672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Genre_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/Genre/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beba9cdc44de231e04c47db1536b683278ac0672", @"/Areas/Admin/Views/Genre/Update.cshtml")]
    public class Areas_Admin_Views_Genre_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.Genre>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml"
  
    ViewBag.Title = "-GÜNCELLEME-";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-6\">\r\n        <section class=\"panel\">\r\n            <header class=\"panel-heading\">\r\n                ");
#nullable restore
#line 12 "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml"
           Write(Model.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tür  ");
#nullable restore
#line 12 "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml"
                                 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" paneli
            </header> <br />
            <div class=""panel-body"">
                <form class=""form-horizontal"" role=""form"" method=""post"" enctype=""multipart/form-data"">
                    <div class=""form-group"">
                        <label class=""col-lg-2 col-sm-2 control-label"">Tür Adı</label>
                        <div class=""col-lg-10"">
                            ");
#nullable restore
#line 19 "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml"
                       Write(Html.TextBoxFor(x => x.GenreName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-lg-2 col-sm-2 control-label"">Durum</label>
                        <div class=""col-lg-10"">
                            ");
#nullable restore
#line 25 "C:\Users\kadir\Desktop\12-NetCoreMovieTheater\NetCoreMovie\WebUI\Areas\Admin\Views\Genre\Update.cshtml"
                       Write(Html.CheckBoxFor(x => x.IsActive, new { @class = "form-control", type = "checkbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <h5 class=""col-lg-2"">AKTİF</h5>
                        </div>
                    </div> 
                    <div class=""form-group"">
                        <div class=""col-lg-offset-2 col-lg-10"">
                            <button type=""submit"" class=""btn btn-danger"">Kaydet</button>
                        </div>
                    </div>
            </form>
        </div>
    </section>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.Genre> Html { get; private set; }
    }
}
#pragma warning restore 1591