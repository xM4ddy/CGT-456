<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="table.aspx.cs" Inherits="Assign02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Panel ID="myTable" runat="server"></asp:Panel>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateURL="index.aspx">Link to index.aspx</asp:HyperLink>
        </div>
    </form>
</body>
</html>
