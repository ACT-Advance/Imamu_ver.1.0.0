<%@ Page Language="C#" Inherits="Imamu.chat" %>
<%@ Import Namespace="System.IO" %>
<script runat="server" language="C#">
	void btn1_click(object sender, EventArgs ev)
   {
      string datetime = DateTime.Now.ToString("yyyyMMdd.HHmmss");
      string order = datetime + "\t" + txtName.Text + "\t" + txtAddress.Text + "\t" + txtMail.Text;
      string filename = Server.MapPath("~/App_Data/order.txt");
      using (var s = new StreamWriter(filename, true))
      {
          s.WriteLine(order);
      }
      string message = datetime + " ご注文ありがとうございます。";
      lblMessage.Text = Server.HtmlEncode(message);
  }
</script>
<!DOCTYPE html>
<html>
<head runat="server">
  <style>
    .title {
      position: relative;
      font-weight: bold;
    }
    .btnSize {
      position: relative;
      bottom: 30px;
      width: 130px;
      height: 80px;
    }
  </style>
</head>
<body>
<center>
<table>
  <tr>
    <td width="30%" valign="top">
      <table>
        <tr>
          <td>
            <div class="title">チャット<br></div>
              <textarea rows="17" cols="30" readonly="true">
A
B
C</textarea>
          </td>
        </tr>
      </table>
    </td>
    <td width="70%">
      <table>
        <tr>
          <td>
            <div class="title">会話<br></div>
              <textarea rows="8" cols="80" readonly="true">
A  >  Advance
B  >  Branches
C  >  C#
              </textarea><br>メッセージ<br>
                <div class="title"><br></div>
                <asp:TextBox id="reqMsg" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 72px" runat="server" TextMode="MultiLine"></asp:TextBox>
				<textarea rows="6" cols="60">送信内容</textarea>
                <input type="button" value="送信" class="btnSize" />
                <form runat="server">
                    <asp:button runat="server" id="btn3" onclick="btn3_click" text="送信" />
				</form>
          </td>
        </tr>
      </table>
    </td>
  </tr>
</table>
</center>
</body>
</html>
