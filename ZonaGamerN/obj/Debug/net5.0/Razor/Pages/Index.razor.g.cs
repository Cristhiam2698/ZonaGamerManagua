#pragma checksum "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa06e91c2888bb7b06b53f6399cc8992d8517dd"
// <auto-generated/>
#pragma warning disable 1591
namespace ZonaGamerN.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using ZonaGamerN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Andres\Desktop\ZonaGamerManagua\ZonaGamerN\_Imports.razor"
using ZonaGamerN.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"wrapper\"><div class=\"main-content\"><div class=\"row small-spacing\"><div class=\"col-sm-6 col-lg-3 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title text-orange\">Site Traffic</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"content widget-stat\"><div id=\"traffic-sparkline-chart-3\" class=\"left-content\"></div>\r\n                            \r\n                            <div class=\"right-content\"><h2 class=\"counter text-danger\">12</h2>\r\n                                \r\n                                <p class=\"text text-danger\">Some text here</p></div></div></div></div>\r\n                \r\n                <div class=\"col-sm-6 col-lg-3 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title text-info\">Site Traffic</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"content widget-stat\"><div id=\"traffic-sparkline-chart-1\" class=\"left-content margin-top-15\"></div>\r\n                            \r\n                            <div class=\"right-content\"><h2 class=\"counter text-info\">278</h2>\r\n                                \r\n                                <p class=\"text text-info\">Some text here</p></div></div></div></div>\r\n                \r\n\r\n                <div class=\"col-sm-6 col-lg-3 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title text-success\">Site Traffic</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"content widget-stat\"><div id=\"traffic-sparkline-chart-2\" class=\"left-content margin-top-10\"></div>\r\n                            \r\n                            <div class=\"right-content\"><h2 class=\"counter text-success\">36%</h2>\r\n                                \r\n                                <p class=\"text text-success\">Some text here</p></div></div></div></div>\r\n                \r\n\r\n                <div class=\"col-sm-6 col-lg-3 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title text-orange\">Site Traffic</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"content widget-stat\"><div id=\"traffic-sparkline-chart-3-custom\" class=\"left-content\"></div>\r\n                            \r\n                            <div class=\"right-content\"><h2 class=\"counter text-orange\">849 <i class=\"fa fa-angle-double-up\"></i></h2>\r\n                                \r\n                                <p class=\"text text-orange\">Some text here</p></div></div></div></div></div>\r\n            \r\n            <div class=\"row small-spacing\"><div class=\"col-lg-6 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title\">Activity</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <canvas id=\"bar-chartjs-chart\" class=\"chartjs-chart\" width=\"480\" height=\"320\"></canvas></div></div>\r\n                \r\n                <div class=\"col-lg-6 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title\">Sales</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <canvas id=\"donut-chartjs-chart\" class=\"chartjs-chart\" width=\"475\" height=\"316\"></canvas></div></div></div>\r\n            \r\n            <div class=\"row small-spacing\"><div class=\"col-lg-3 col-md-6 col-xs-12\"><div class=\"box-content bg-success text-white\"><div class=\"statistics-box with-icon\"><i class=\"ico small fa fa-diamond\"></i>\r\n                            <p class=\"text text-white\">SUCCESS</p>\r\n                            <h2 class=\"counter\">72943</h2></div></div></div>\r\n                \r\n                <div class=\"col-lg-3 col-md-6 col-xs-12\"><div class=\"box-content bg-info text-white\"><div class=\"statistics-box with-icon\"><i class=\"ico small fa fa-download\"></i>\r\n                            <p class=\"text text-white\">DOWNLOAD</p>\r\n                            <h2 class=\"counter\">6382</h2></div></div></div>\r\n                \r\n                <div class=\"col-lg-3 col-md-6 col-xs-12\"><div class=\"box-content bg-danger text-white\"><div class=\"statistics-box with-icon\"><i class=\"ico small fa fa-bug\"></i>\r\n                            <p class=\"text text-white\">FIXED BUG</p>\r\n                            <h2 class=\"counter\">12564</h2></div></div></div>\r\n                \r\n                <div class=\"col-lg-3 col-md-6 col-xs-12\"><div class=\"box-content bg-warning text-white\"><div class=\"statistics-box with-icon\"><i class=\"ico small fa fa-usd\"></i>\r\n                            <p class=\"text text-white\">SALES</p>\r\n                            <h2 class=\"counter\">2,637</h2></div></div></div></div>\r\n            \r\n\r\n            <div class=\"row small-spacing\"><div class=\"col-lg-4 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title\">Last Reviews</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"review-list\"><div class=\"review-item\"><div class=\"top\"><div class=\"name\">John Doe</div>\r\n                                    \r\n                                    <div class=\"date\">10 min</div>\r\n                                    \r\n                                    <div class=\"star-rating text-warning\"><i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star-half-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i></div></div>\r\n                                \r\n                                <div class=\"desc\">Amet odio neque nobis consequuntur consequatur a quae, impedit facere, impedit facere.</div></div>\r\n                            \r\n                            <div class=\"review-item\"><div class=\"top\"><div class=\"name\">Harry Halen</div>\r\n                                    \r\n                                    <div class=\"date\">15 min</div>\r\n                                    \r\n                                    <div class=\"star-rating text-warning\"><i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i></div></div>\r\n                                \r\n                                <div class=\"desc\">Amet odio neque nobis consequuntur consequatur a quae, impedit facere, impedit facere.</div></div>\r\n                            \r\n                            <div class=\"review-item\"><div class=\"top\"><div class=\"name\">Thomas Taylor</div>\r\n                                    \r\n                                    <div class=\"date\">30 min</div>\r\n                                    \r\n                                    <div class=\"star-rating text-warning\"><i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star\"></i></div></div>\r\n                                \r\n                                <div class=\"desc\">Amet odio neque nobis consequuntur consequatur a quae, impedit facere, impedit facere.</div></div>\r\n                            \r\n                            <div class=\"review-item\"><div class=\"top\"><div class=\"name\">Helen Candy</div>\r\n                                    \r\n                                    <div class=\"date\">1 hour ago</div>\r\n                                    \r\n                                    <div class=\"star-rating text-warning\"><i class=\"fa fa-star\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i></div></div>\r\n                                \r\n                                <div class=\"desc\">Amet odio neque nobis consequuntur consequatur a quae, impedit facere, impedit facere.</div></div>\r\n                            \r\n                            <div class=\"review-item\"><div class=\"top\"><div class=\"name\">Henny Betty</div>\r\n                                    \r\n                                    <div class=\"date\">1 day ago</div>\r\n                                    \r\n                                    <div class=\"star-rating text-warning\"><i class=\"fa fa-star-half-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i>\r\n                                        <i class=\"fa fa-star-o\"></i></div></div>\r\n                                \r\n                                <div class=\"desc\">Amet odio neque nobis consequuntur consequatur a quae, impedit facere, impedit facere.</div></div></div></div></div>\r\n                \r\n                <div class=\"col-lg-4 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title\">Activity</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"activity-list\"><div class=\"activity-item\"><div class=\"bar bg-primary\"><div class=\"dot bg-primary\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">10 min</div>\r\n                                    \r\n                                    <div class=\"text\">\r\n                                        Harry has finished \"Amaza HTML\" task\r\n                                    </div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-danger\"><div class=\"dot bg-danger\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">15 min</div>\r\n                                    \r\n                                    <div class=\"text\">\r\n                                        You completed your task\r\n                                    </div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-success\"><div class=\"dot bg-success\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">30 min</div>\r\n                                    \r\n                                    <div class=\"text\">\r\n                                        New updated has been installed\r\n                                    </div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-violet\"><div class=\"dot bg-violet\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">1 hour ago</div>\r\n                                    \r\n                                    <div class=\"text\">Write some comments</div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-warning\"><div class=\"dot bg-warning\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">1 day ago</div>\r\n                                    \r\n                                    <div class=\"text\">4 friends request accepted</div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-orange\"><div class=\"dot bg-orange\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">6 days ago</div>\r\n                                    \r\n                                    <div class=\"text\">Betty has joined your team</div></div></div>\r\n                            \r\n                            <div class=\"activity-item\"><div class=\"bar bg-orange\"><div class=\"dot bg-orange\"></div>\r\n                                    <div class=\"last-dot bg-orange\"></div></div>\r\n                                \r\n                                <div class=\"content\"><div class=\"date\">12 days ago</div>\r\n                                    \r\n                                    <div class=\"text\">Daisy has joined your team</div></div></div></div>\r\n                        \r\n                        <a href=\"#\" class=\"activity-link\">View all activity <i class=\"fa fa-angle-down\"></i></a></div></div>\r\n                \r\n                <div class=\"col-lg-4 col-xs-12\"><div class=\"box-content js__todo_widget\"><h4 class=\"box-title\">Todo</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Action</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <div class=\"todo-list js__todo_list\"><div class=\"todo-item\"><div class=\"checkbox\"><input type=\"checkbox\" id=\"todo-1\"><label for=\"todo-1\">Task To Do 1</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox primary\"><input type=\"checkbox\" id=\"todo-2\"><label for=\"todo-2\">Task To Do 2</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox info\"><input type=\"checkbox\" checked id=\"todo-3\"><label for=\"todo-3\">Task To Do 3</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox success\"><input type=\"checkbox\" id=\"todo-4\"><label for=\"todo-4\">Task To Do 4</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox danger\"><input type=\"checkbox\" checked id=\"todo-5\"><label for=\"todo-5\">Task To Do 5</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox success\"><input type=\"checkbox\" id=\"todo-6\"><label for=\"todo-6\">Task To Do 6</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox success\"><input type=\"checkbox\" id=\"todo-7\"><label for=\"todo-7\">Task To Do 7</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox success\"><input type=\"checkbox\" id=\"todo-8\"><label for=\"todo-8\">Task To Do 8</label></div></div>\r\n                            \r\n                            <div class=\"todo-item\"><div class=\"checkbox success\"><input type=\"checkbox\" id=\"todo-9\"><label for=\"todo-9\">Task To Do 9</label></div></div></div>\r\n                        \r\n                        <div class=\"todo-form\"><div class=\"input-group\"><input type=\"text\" placeholder=\"Add new task\" class=\"form-control js__todo_value\">\r\n                                <div class=\"input-group-btn\"><button type=\"button\" class=\"btn btn-success no-border text-white js__todo_button waves-effect waves-light\"><i class=\"fa fa-plus\"></i></button></div></div></div></div></div></div>\r\n            \r\n\r\n            <div class=\"row small-spacing\"><div class=\"col-lg-6 col-xs-12\"><div class=\"box-content\"><div id=\"calendar-widget\"></div></div></div>\r\n                \r\n                <div class=\"col-lg-6 col-xs-12\"><div class=\"box-content\"><h4 class=\"box-title\">Purchases</h4>\r\n                        \r\n                        <div class=\"dropdown js__drop_down\"><a href=\"#\" class=\"dropdown-icon glyphicon glyphicon-option-vertical js__drop_down_button\"></a>\r\n                            <ul class=\"sub-menu\"><li><a href=\"#\">Product</a></li>\r\n                                <li><a href=\"#\">Another action</a></li>\r\n                                <li><a href=\"#\">Something else there</a></li>\r\n                                <li class=\"split\"></li>\r\n                                <li><a href=\"#\">Separated link</a></li></ul></div>\r\n                        \r\n                        <table class=\"table table-striped margin-bottom-10 table-purchases\"><thead><tr><th style=\"width:40%;\">Product</th>\r\n                                    <th>Price</th>\r\n                                    <th>Date</th>\r\n                                    <th>State</th>\r\n                                    <th style=\"width:5%;\"></th></tr></thead>\r\n                            <tbody><tr><td>Amaza Themes</td>\r\n                                    <td>$71</td>\r\n                                    <td>Nov 12,2016</td>\r\n                                    <td class=\"text-success\">Completed</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Macbook</td>\r\n                                    <td>$142</td>\r\n                                    <td>Nov 10,2016</td>\r\n                                    <td class=\"text-danger\">Cancelled</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Samsung TV</td>\r\n                                    <td>$200</td>\r\n                                    <td>Nov 01,2016</td>\r\n                                    <td class=\"text-warning\">Pending</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Ninja Admin</td>\r\n                                    <td>$200</td>\r\n                                    <td>Oct 28,2016</td>\r\n                                    <td class=\"text-warning\">Pending</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Galaxy Note 5</td>\r\n                                    <td>$200</td>\r\n                                    <td>Oct 28,2016</td>\r\n                                    <td class=\"text-success\">Completed</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>CleanUp Themes</td>\r\n                                    <td>$71</td>\r\n                                    <td>Oct 22,2016</td>\r\n                                    <td class=\"text-success\">Completed</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Facebook WP Plugin</td>\r\n                                    <td>$10</td>\r\n                                    <td>Oct 15,2016</td>\r\n                                    <td class=\"text-success\">Completed</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Iphone 7</td>\r\n                                    <td>$100</td>\r\n                                    <td>Oct 12,2016</td>\r\n                                    <td class=\"text-warning\">Pending</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Nova House</td>\r\n                                    <td>$100</td>\r\n                                    <td>Oct 12,2016</td>\r\n                                    <td class=\"text-warning\">Pending</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr>\r\n                                <tr><td>Repair Cars</td>\r\n                                    <td>$35</td>\r\n                                    <td>Oct 12,2016</td>\r\n                                    <td class=\"text-warning\">Pending</td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-plus-circle\"></i></a></td></tr></tbody></table></div></div></div>\r\n            \r\n            <footer class=\"footer\"><ul class=\"list-inline\"><li>2016 © NinjaAdmin.</li>\r\n                    <li><a href=\"#\">Privacy</a></li>\r\n                    <li><a href=\"#\">Terms</a></li>\r\n                    <li><a href=\"#\">Help</a></li></ul></footer></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
