using System;
using System.ComponentModel;

namespace Imamu.Models
{
    public class UserModels
    {
		/// <summary>
		/// 名前
		/// </summary>
		[DisplayName("お名前")]
		public string Name { get; set; }
    }
}
