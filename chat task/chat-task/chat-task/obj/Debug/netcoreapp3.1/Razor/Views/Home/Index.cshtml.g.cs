#pragma checksum "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b325601ab7e6558d5457c153d82790d4f2eb16b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\_ViewImports.cshtml"
using chat_task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\_ViewImports.cshtml"
using chat_task.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\_ViewImports.cshtml"
using chat_task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b325601ab7e6558d5457c153d82790d4f2eb16b0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5b93ede9adffbda59637e41329f4e432b3e475", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />

<div class=""container"">
    <div class=""row clearfix"">
        <div class=""col-lg-12"">
            <div class=""card chat-app"">
                <div id=""plist"" class=""people-list"">
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i class=""fa fa-search""></i></span>
                        </div>
                        <input type=""hidden"" id=""UserIdd"" name=""ReciveUserId""");
            BeginWriteAttribute("value", " value=\"", 661, "\"", 669, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Search...\">\n                    </div>\n                    <ul class=\"list-unstyled chat-list mt-2 mb-0\">\n");
#nullable restore
#line 21 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                         foreach (AppUser user in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("id", " id=\"", 971, "\"", 984, 1);
#nullable restore
#line 23 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
WriteAttributeValue("", 976, user.Id, 976, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"clearfix user\">\n                                <img src=\"https://bootdey.com/img/Content/avatar/avatar1.png\" alt=\"avatar\">\n                                <div class=\"about\">\n                                    <div class=\"name\">");
#nullable restore
#line 26 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                                                 Write(user.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                    <div class=\"status user\"> <i");
            BeginWriteAttribute("class", " class=\"", 1308, "\"", 1375, 3);
            WriteAttributeValue("", 1316, "fa", 1316, 2, true);
            WriteAttributeValue(" ", 1318, "fa-circle", 1319, 10, true);
#nullable restore
#line 27 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1328, user.CpnnectionId==null? "offline":"online", 1329, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> </div>\n                                </div>\n                            </li>\n");
#nullable restore
#line 30 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <div style=""height:90vh; overflow-y:scroll"" class=""chat"">
                    <div class=""chat-header clearfix"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <a href=""javascript:void(0);"" data-toggle=""modal"" data-target=""#view_info"">
                                    <img src=""https://bootdey.com/img/Content/avatar/avatar2.png"" alt=""avatar"">
                                </a>
                                <div class=""chat-about"">
                                    <h6 class=""m-b-0"">Aiden Chavez</h6>
                                    <small>Last seen: 2 hours ago</small>
                                </div>
                            </div>
                            <div class=""col-lg-6 hidden-sm text-right"">
");
#nullable restore
#line 46 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                                 if (!User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b325601ab7e6558d5457c153d82790d4f2eb16b010038", async() => {
                WriteLiteral("Login");
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
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b325601ab7e6558d5457c153d82790d4f2eb16b011516", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 50 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b325601ab7e6558d5457c153d82790d4f2eb16b013305", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 54 "C:\Users\OMEN\Desktop\ChatApp-AspNet\chat task\chat-task\chat-task\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                    <div class=\"chat-history\">\n                        <ul class=\" asream m-b-0\">\n");
            WriteLiteral("\n");
            WriteLiteral(@"                        </ul>
                    </div>

                </div>
                <div class=""chat-message clearfix"">
                    <div class=""input-group mb-0"">

                        <div class=""input-group-prepend"">
                            <span id=""send"" class=""input-group-text""><i class=""fa fa-send""></i></span>
                        </div>
                        <input id=""message"" type=""text"" class=""form-control"" placeholder=""Enter text here..."">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b325601ab7e6558d5457c153d82790d4f2eb16b015960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        var Connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build()
        Connection.start()



        $(""#send"").click(function () {
            let message = $(""#message"").val()
            let reciveuserid = $(""#UserIdd"").val()
            Connection.invoke(""SendMessage"", message, reciveuserid)

        })
        $(""#message"").val("" "")
      
        $("".user"").click(function () {
            let userid = $(this).attr(""id"")
            let connectuserid = $(""#UserIdd"").val(userid)
          
        })

        Connection.on(""ReciveMessage"", function (user,message) {
            //console.log(`${message},${name}`)
            let area = document.querySelector("".message"")
            let li = document.createElement(""li"")
            li.className=""clearfix""
            li.innerHTML = `
               <div class=""message-data"">
                  <span class=""message-data-time"">${user} Today</span>
                   </div>
                  <div class=""message my-message");
                WriteLiteral(@""">${message}</div>
              `
            let asream = document.querySelector("".asream"")
            asream.append(li)
        })

        Connection.on(""SendMessage"", function (user, message) {
            //console.log(`${message},${name}`)
            let area = document.querySelector("".message"")
            let li = document.createElement(""li"")
            li.className = ""clearfix text-right""
            li.innerHTML = `
               <div class=""message-data"">
                  <span class=""message-data-time"">${user} Today</span>
                   </div>
                  <div class=""message my-message float-right"">${message}</div>
              `
            let asream = document.querySelector("".asream"")
            asream.append(li)
        })


        Connection.on(""UserConnected"", function (Id) {

            let user = document.getElementById(Id)
            $(user).find(""i"").removeClass(""offline"")
            $(user).find(""i"").addClass(""online"")

        })
        Connection.on(""UserDisCon");
                WriteLiteral("nected\", function (Id) {\n\n            let user = document.getElementById(Id)\n            $(user).find(\"i\").removeClass(\"online\")\n            $(user).find(\"i\").addClass(\"offline\")\n\n        })\n        \n\n\n    </script>\n\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
