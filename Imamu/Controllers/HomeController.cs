using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Mvc.Ajax;
using Imamu.Models;

namespace Imamu.Controllers
//namespace Socket.Controllers
{
    public class HomeController : Controller
    {

    	public ActionResult Index(string UserId, string password)
        {

            if(UserId != null && UserId != "" &&
               password != null && password != "") {

                Session["UserID"] = UserId;
                ViewBag.msgFlg = "0";
                return RedirectToAction("Chat");

            };

            return View();
        }

		public ActionResult Chat(string message)
		{
            if (string.IsNullOrEmpty(message)) {
                return View("Chat");
            }
			MessageModel msgM = new MessageModel()
			{
				UserId = Session["UserID"] as string,
				Name = Session["Name"] as string,
				Time = DateTime.Now,
				Message = message
			};

			return PartialView("Message", msgM);
		}

		// GET: Login
		[HttpPost]
		public ActionResult Login(string UserId, string password)
		{
			//マップの定義
			IDictionary<string, string> loginDataMap = new Dictionary<string, string>();

			//マップに値の追加
            loginDataMap.Add("LoginID", UserId);
            loginDataMap.Add("Password", password);

			ViewData["LoginPostData"] = loginDataMap;



            return View(Chat(""));
		}


		// GET: Chat
		[HttpPost]
		public ActionResult ChatSendMsg(string message)
		{

			if (string.IsNullOrEmpty(message))
			{
				return View(Chat(""));
			}
			MessageModel msgM = new MessageModel(){
                UserId=Session["UserID"] as string,
                Name=Session["Name"] as string,
                Time = DateTime.Now,
                Message = message
            };

            return PartialView("Message", msgM);
		}
	}

}
