﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Extensions/TextRegion.cshtml")]
    public partial class TextRegion : System.Web.Mvc.WebViewPage<Piranha.Extend.Regions.TextRegion>
    {
        public TextRegion()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
  

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n    <li>");

            
            #line 5 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
   Write(Html.LabelFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">");

            
            #line 6 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
                      Write(Html.TextBoxFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.Title));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    <li>");

            
            #line 8 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
   Write(Html.LabelFor(m => m.Body));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">");

            
            #line 9 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
                      Write(Html.TextAreaFor(m => m.Body, new { @rows = 8 }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 10 "..\..\Areas\Manager\Views\Extensions\TextRegion.cshtml"
   Write(Html.ValidationMessageFor(m => m.Body));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n</ul>");

        }
    }
}
#pragma warning restore 1591
