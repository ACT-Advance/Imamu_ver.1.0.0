using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Socket.Hubs
{
	// jsから呼び出されるハブの名前を定義
	[HubName("chatHub")]
	public class ChatHub : Hub
	{
		// jsから呼び出される処理を実装
		public void Send(string name, string message)
		{
			// どのクライアントにレスポンスを返すか指定
			// ※ここでは全クライアントに返す
			Clients.All.addNewMessageToPage(name, message);
		}
	}
}