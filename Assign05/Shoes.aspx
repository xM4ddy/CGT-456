<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shoes.aspx.cs" Inherits="Shoes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateURL="Default.aspx">Link to Default.aspx</asp:HyperLink>
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateURL="query.txt">Link to Query.txt</asp:HyperLink>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="select" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="selectOne" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="insert" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="update" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="delete" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="deleteAll" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="truncate" EventName="Click" />
                </Triggers>

                <ContentTemplate>
                    <asp:Button runat="server" ID="select" Text="Select All" OnClick="Select_Click" />
                    <asp:Button runat="server" ID="selectOne" Text="Select 1" OnClick="SelectOne_Click" />
                    <asp:Button runat="server" ID="insert" Text="Insert" OnClick="Insert_Click" />
                    <asp:Button runat="server" ID="update" Text="Update" OnClick="Update_Click" />
                    <asp:Button runat="server" ID="delete" Text="Delete" OnClick="Delete_Click" />
                    <asp:Button runat="server" ID="deleteAll" Text="Delete All" OnClick="DeleteAll_Click" />
                    <asp:Button runat="server" ID="truncate" Text="Truncate" OnClick="Truncate_Click" />
                    <br />
                    
                    <asp:DataGrid runat="server" ID="results" />

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
