using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lennon.Core;
using Lennon.SexCity.Business;
using Lennon.SexCity.Models;
using Webdiyer.WebControls.Mvc;

namespace Lennon.SexCity.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private NovelBusiness novelBusiness;

        public ActionResult Index(int? id=1)
        {
            novelBusiness = new NovelBusiness();

            int pageIndex = id ?? 1;
            const int pageSize = 20;
            PropertySortCondition[] sortConditions = new[] { new PropertySortCondition("Id") };
            int total;
            var list = novelBusiness.GetNovels(pageIndex, pageSize, out total, sortConditions);
            return View(list);
        }

    }
}
