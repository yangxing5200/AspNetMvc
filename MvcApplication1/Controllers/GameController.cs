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
            ViewBag.title = "LOL";
            ViewBag.Desc = "腾讯代运营 英雄联盟";
            return View();
        }

        public string Fun(string name)
        {
            return "hello" + name;
        }
        public string FunInt(int id)
        {
            return "hello" + id;
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
