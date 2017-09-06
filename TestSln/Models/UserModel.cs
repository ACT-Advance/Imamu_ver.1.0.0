using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace Imamu.Models
{
	public class UserModel
	{

		/// <summary>
		/// ユーザID
		/// </summary>
		[DisplayName("ユーザID")]
		public string UserId { get; set; }

		/// <summary>
		/// パスワード
		/// </summary>
		[DisplayName("パスワード")]
		public string Password { get; set; }

		/// <summary>
		/// 名前
		/// </summary>
		[DisplayName("名前")]
		public string Name { get; set; }
	}
}