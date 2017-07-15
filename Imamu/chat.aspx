<%@ Page Language="C#" Inherits="Imamu.chat" %>
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
                  <textarea rows="6" cols="60">送信内容</textarea>
                    <input type="button" value="憲怣" class="btnSize" />
          </td>
        </tr>
      </table>
    </td>
  </tr>
</table>
</center>
</body>
</html>
