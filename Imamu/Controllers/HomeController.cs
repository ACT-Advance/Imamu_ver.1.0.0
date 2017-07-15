using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Imamu.Models;

namespace Imamu.Controllers
{
    public class HomeController : Controller
    {
     /* public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        } */

		// GET: Home
		public ActionResult Index()
		{
			return View(new UserModels());
		}

		/// <summary>
		/// 名前をpostされたときの処理
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult Index([Bind(Include = "Name")] UserModels user)
		{
			return RedirectToAction("Hello", user);
		}

		/// <summary>
		/// あいさつページの表示
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public ActionResult Hello(UserModels user)
		{
			if (string.IsNullOrEmpty(user.Name))
			{
				return RedirectToAction("Index");
			}
			return View(user);
		}

	}
}
