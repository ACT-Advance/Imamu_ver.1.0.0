using Microsoft.Owin;
using Owin;

// SignalRをサーバー上に稼働
[assembly: OwinStartup(typeof(SignalRHubServer.Startup))]
namespace SignalRHubServer
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// URIマップ先を設定
			app.MapSignalR();
		}

	}
}
