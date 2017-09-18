using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace Imamu.Models
{
    public class MessageModel
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
		/// ユーザID
		/// </summary>
		[DisplayName("いまむユーザID")]
		public string imamuUserId { get; set; }

		/// <summary>
		/// imamu名前
		/// </summary>
		[DisplayName("いまむ名前")]
		public string imamuName { get; set; }

		/// <summary>
		/// imamu時刻
		/// </summary>
		[DisplayName("いまむ時刻")]
		public DateTime imamuTime { get; set; }

		/// <summary>
		/// メッセージ
		/// </summary>
		[DisplayName("いまむメッセージ")]
		public string imamuMessage { get; set; }

		/// <summary>
		/// 会話フラグ
		/// </summary>
		[DisplayName("会話フラグ")]
		public string MessageFlg { get; set; }

	}
}
