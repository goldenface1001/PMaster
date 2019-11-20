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

namespace Piranha.Areas.Manager.Views.SiteTree
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/SiteTree/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<Piranha.Areas.Manager.Models.SiteTreeEditModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 106), Tuple.Create("\"", 162)
, Tuple.Create(Tuple.Create("", 112), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.form.js")
, 112), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 209), Tuple.Create("\"", 275)
, Tuple.Create(Tuple.Create("", 215), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/jquery.regiontemplate.js")
, 215), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 322), Tuple.Create("\"", 376)
, Tuple.Create(Tuple.Create("", 328), Tuple.Create<System.Object, System.Int32>(Href("~/res.ashx/areas/manager/content/js/ext/json2.js")
, 328), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        /**\r\n         * This var is needed by the regiontemplate script.\r\n    " +
"     */\r\n        var templateid = \'");

            
            #line 10 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                     Write(Model.Template.Id);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n        $(document).ready(function () {\r\n            $(\'#Name\').focus();\r\n " +
"       });\r\n    </script>\r\n");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 18 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 23 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
             if (Model.CanDelete && Model.Id != Piranha.Config.DefaultSiteTreeId) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 971), Tuple.Create("\"", 1022)
            
            #line 24 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 978), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", new { id = Model.Id })
            
            #line default
            #line hidden
, 978), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                 Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 25 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1122), Tuple.Create("\"", 1161)
            
            #line 26 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1129), Tuple.Create<System.Object, System.Int32>(Url.Action("index", "sitetree")
            
            #line default
            #line hidden
, 1129), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 26 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                   Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1242), Tuple.Create("\"", 1291)
            
            #line 27 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1249), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", new { id = Model.Id })
            
            #line default
            #line hidden
, 1249), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 27 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
       Write(Piranha.WebPages.Hooks.Manager.Toolbar.Render(Url, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 34 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 36 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.NamespaceId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 37 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.CanDelete));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 40 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 44 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.Name, Piranha.Resources.Global.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 46 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 47 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 50 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.InternalId, Piranha.Resources.Global.InternalId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

            
            #line 52 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                         if (Model.Id != Piranha.Config.DefaultSiteTreeId) {
                        
            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.InternalId, new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
            
            #line 53 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                                                     
                        } else {
                        
            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.InternalId, new { @disabled = true }));

            
            #line default
            #line hidden
            
            #line 55 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                     
                        
            
            #line default
            #line hidden
            
            #line 56 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.HiddenFor(m => m.InternalId));

            
            #line default
            #line hidden
            
            #line 56 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                          
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

WriteLiteral("                    ");

            
            #line 59 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.InternalId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.Description, Piranha.Resources.Global.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 64 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Description, new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n   " +
" <div");

WriteLiteral(" class=\"box main-content content-editor\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\"tools\"");

WriteLiteral(">\r\n                    <ul>\r\n                        <li");

WriteLiteral(" class=\"btn-settings active\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-id=\"pnl-settings\"");

WriteLiteral(">");

            
            #line 74 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                      Write(Piranha.Resources.Global.Settings);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                        <li");

WriteLiteral(" class=\"btn-regions\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-id=\"pnl-regions\"");

WriteLiteral(">");

            
            #line 75 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                             Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                    </ul>\r\n                </td>\r\n                <td>" +
"\r\n                    <div");

WriteLiteral(" id=\"pnl-settings\"");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 80 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                          Write(Piranha.Resources.Global.Settings);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n                        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                <li>\r\n");

WriteLiteral("                                    ");

            
            #line 84 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.LabelFor(m => m.HostNames, Piranha.Resources.SiteTree.HostNames));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 86 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                   Write(Html.TextBoxFor(m => m.HostNames, new { @placeholder = Piranha.Resources.Global.Optional }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                </li>\r\n                                <l" +
"i>\r\n");

WriteLiteral("                                    ");

            
            #line 89 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.LabelFor(m => m.Template.Preview, Piranha.Resources.Page.HtmlPreview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 91 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 6 }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                </li>\r\n                            </ul>\r" +
"\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" id=\"pnl-regions\"");

WriteLiteral(" class=\"main hidden\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 97 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                          Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n                        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" class=\"list region-editor\"");

WriteLiteral(">\r\n                                <tbody>\r\n                                    <" +
"tr>\r\n                                        <th>");

            
            #line 102 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 103 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.InternalId);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 104 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.Type);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th></th>\r\n                       " +
"             </tr>\r\n");

WriteLiteral("                                    ");

            
            #line 107 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.EditorFor(m => m.Regions));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <tr");

WriteLiteral(" class=\"dark\"");

WriteLiteral(">\r\n                                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionName\"");

WriteLiteral(" /></div>\r\n                                        </td>\r\n                       " +
"                 <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionInternalId\"");

WriteLiteral(" /></div>\r\n                                        </td>\r\n                       " +
"                 <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 119 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                           Write(Html.DropDownList("newregionType",
                                                    new SelectList(Model.RegionTypes, "Type", "Name")));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                        </td>\r\n                          " +
"              <td");

WriteLiteral(" class=\"buttons four\"");

WriteLiteral(">\r\n                                            <button");

WriteLiteral(" id=\"btnAddRegion\"");

WriteLiteral(" class=\"btn marg-big\"");

WriteLiteral(">");

            
            #line 123 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                      Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral(@"</button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</div>
");

            
            #line 135 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
