using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Index()
        {
            return View();
        }

        public string GetIndex()
        {
            return "执行了 GameController GetIndex()";
        }
        public string GetGameInfo(string name, string type, string id)
        {
            return string.Format("你马上要执行的游戏是{0}，是一个{1}型的游戏，对应的ID是{2}"
                , name, type, id);
        }
    }
}
