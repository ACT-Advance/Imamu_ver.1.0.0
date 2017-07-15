using System;
using System.Web;
using System.Web.UI;

namespace Imamu
{

	public partial class login : System.Web.UI.Page
	{
		protected void button1Clicked(object sender, EventArgs args)
		{
			Response.Redirect("chat.aspx");
		}
	}
}
