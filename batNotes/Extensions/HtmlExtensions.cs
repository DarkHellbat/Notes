using batNotes.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace batNotes.HtmlExtensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString GetCurrentUser(this HtmlHelper html)
        {
            var controller = html.ViewContext.Controller as BaseController;
            if (controller != null && controller.CurrentUser != null)
            {
                return html.Partial("DisplayTemplates/User", controller.CurrentUser);
            }
            else
                return MvcHtmlString.Empty;
        }
    }
}