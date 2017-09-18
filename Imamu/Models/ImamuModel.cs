using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace Imamu.Models
{
    public class ImamuModel
	{
		/// <summary>
		/// ユーザID
		/// </summary>
		[DisplayName("ユーザID")]
		public string UserId { get; set; }

		/// <summary>
		/// 名前
		/// </summary>
		[DisplayName("名前")]
		public string Name { get; set; }

		/// <summary>
		/// 時刻
		/// </summary>
		[DisplayName("時刻")]
		public DateTime Time { get; set; }

		/// <summary>
		/// メッセージ
		/// </summary>
		[DisplayName("メッセージ")]
		public string Message { get; set; }

		/// <summary>
		/// 会話フラグ
		/// </summary>
		[DisplayName("会話フラグ")]
		public string MessageFlg { get; set; }

	}
}
