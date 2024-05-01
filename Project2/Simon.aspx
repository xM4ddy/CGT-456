<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simon.aspx.cs" Inherits="Simon.Simon" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Simon - Maddy W</title>
  <link type="text/css" rel="stylesheet" href="index.css" />
</head>

<body>
  <form id="form1" runat="server">

    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <asp:Timer ID="Timer" OnTick="Tick" runat="server" Interval="600" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="Timer" />
    </Triggers>

      <ContentTemplate>
        <asp:Button class="" ID="StartButton" runat="server" Text="START" OnClick="Start" />
        <main>
          <div id="score"><p runat="server" id="scoreCount">1</p></div>
          <div id="container">
            <asp:Button class="" ID="button_green" runat="server" Text="0" OnClick="BtnClicked" />
            <asp:Button class="" ID="button_red" runat="server" Text="1" OnClick="BtnClicked" />
            <asp:Button class="" ID="button_yellow" runat="server" Text="2" OnClick="BtnClicked" />
            <asp:Button class="" ID="button_blue" runat="server" Text="3" OnClick="BtnClicked" />
          </div>
        </main>
      </ContentTemplate>

    </asp:UpdatePanel>
  </form>
</body>
</html>
