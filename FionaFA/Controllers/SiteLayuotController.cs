using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace FionaFA.Controllers
{
    public class SiteLayuotController : SurfaceController
    {
        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/SiteLayout/";
        public ActionResult RenderHeader()
        {
            return PartialView($"{PARTIAL_VIEW_FOLDER}_Header.cshtml");
        }
        
        public ActionResult RenderIntro()
        {
            return PartialView($"{PARTIAL_VIEW_FOLDER}_Intro.cshtml");
        }

        public ActionResult RenderFooter()
        {
            return PartialView($"{PARTIAL_VIEW_FOLDER}_Footer.cshtml");
        }
    }
}