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

            if (UserId != null && UserId != "" &&
               password != null && password != "")
            {

                Session["UserID"] = UserId;
                ViewBag.msgFlg = "0";
                return RedirectToAction("Chat");

            };

            TempData["会話数"] = "0";
            TempData.Keep();

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
			Dictionary<string, string> loginDataMap = new Dictionary<string, string>();

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

            string imamuMsg = "";
            string msgFlg = (string)TempData.Peek("会話数");
            int intMsgFlg = int.Parse(msgFlg);

            if (intMsgFlg == 0)
            {

                imamuMsg = "こんにちわ！いまむ〜だよ！お名前を教えてね！";
                TempData["会話数"] = "1";

            }
            else if (intMsgFlg == 1)
            {

                imamuMsg = message + "っていうんだね、性別は？？？？？？";
                TempData["会話数"] = "2";

            }
            else if (intMsgFlg == 2 && (message.IndexOf("男") > -1))
            {

                imamuMsg = "そっか、数字で表すと歳は？";
                TempData["会話数"] = "3";

            }
            else if (intMsgFlg == 2 && (message.IndexOf("女") > -1))
            {

                imamuMsg = "数字で表すと歳はいくつ？";
                TempData["会話数"] = "3";

            }
			else if (intMsgFlg == 2)
			{

				imamuMsg = "どっち？";
				TempData["会話数"] = "2";

			}




			else if (intMsgFlg == 3 && (int.Parse(message) > 17) && (int.Parse(message) < 40))
            {

                imamuMsg = "今暇？";
                TempData["会話数"] = "4";

            }
            else if (intMsgFlg == 3 && (int.Parse(message) <= 17))
            {

                imamuMsg = "おじさんね、ちょっと君とは話せないかなぁ^^;　わっぱ掛けられちゃう;;";
                TempData["会話数"] = "99";

            }
            else if (intMsgFlg == 3 && (int.Parse(message) >= 40))
            {

                imamuMsg = "全然そんなふうに思えないです。20代後半かと思いました。";
                TempData["会話数"] = "4";

            }
            else if (intMsgFlg == 4)
            {

                imamuMsg = "どこ住み？";
                TempData["会話数"] = "5";

            }
            else if (intMsgFlg == 5)
            {

                imamuMsg = "会える？";
                TempData["会話数"] = "6";

            }
            else if (intMsgFlg == 6)
            {

                imamuMsg = "冗談です";
                TempData["会話数"] = "99";

            }
            else if (intMsgFlg == 99)
            {
				imamuMsg = "いまむ〜はだんまりを決め込みました。";

			}


				ImamuModel imamuMsgM = new ImamuModel(){
                UserId= "いまむ〜",
                Name= "いまむ〜",
                Time = DateTime.Now,
                Message = imamuMsg
            };

			MessageModel msgM = new MessageModel()
			{
				UserId = Session["UserID"] as string,
				Name = Session["Name"] as string,
				Time = DateTime.Now,
				Message = message,

				imamuUserId = "いまむ〜",
				imamuName = "いまむ〜",
				imamuTime = DateTime.Now,
                imamuMessage = imamuMsg

			};

			return PartialView("Message", msgM);
		}
	}

}
