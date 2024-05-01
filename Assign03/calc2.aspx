<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calc2.aspx.cs" Inherits="Assign03.calc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Container{
            width:700px;
            height:700px;
            border-radius:50px;
            background-color:#99ffff;
        }
        #LabelBackground{
            width:700px;
            height:90px;
            position:relative;
            top:0px;
            left:0px;
            background-color:#dddddd;
            border-top-right-radius:50px;
            border-top-left-radius:50px;
        }
        #Label1{
            position:absolute;
            left:100px; 
            top:20px;
            width:450px;
            font-size:32pt;
        }
        #HyperLink1{
            position:absolute;
            top: 30px;
            left: 615px;
        }
        #display{
            position:absolute;
            width:300px; 
            height:50px;
            top: 150px;
            left: 85px;
        }
        #Btn1{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 485px;
            left: 85px;
        }
        #Btn2{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 485px;
            left: 225px;
        }
        #Btn3{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 485px;
            left: 375px;
        }
        #Btn4{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 365px;
            left: 85px;
        }
        #Btn5{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 365px;
            left: 225px;
        }
        #Btn6{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 365px;
            left: 375px;
        }
        #Btn7{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 245px;
            left: 85px;
        }
        #Btn8{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 245px;
            left: 225px;
        }
        #Btn9{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 245px;
            left: 375px;
        }
        #Btn0{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 600px;
            left: 85px;
        }
        #BtnDiv{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 245px;
            left: 515px;
        }
        #BtnMult{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 365px;
            left: 515px;
        }
        #BtnSubtract{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 485px;
            left: 515px;
        }
        #BtnAdd{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 600px;
            left: 375px;
        }
        #BtnEqual{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 600px;
            left: 225px;
        }
        #BtnClear{
            position:absolute;
            width:100px;
            height:100px;
            font-size:24pt;
            top: 125px;
            left: 515px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
        <div id="Container">
            <div id="LabelBackground">
                <asp:Label ID="Label1" runat="server" Text="Single Digit Calculator v2"></asp:Label>
            </div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="calc2.aspx">calc2.aspx</asp:HyperLink>
            
            <asp:TextBox ID="display" runat="server"></asp:TextBox>
            
            <asp:Button ID="Btn0" runat="server" Text="0" OnClick="BtnClicked"/>
            <asp:Button ID="Btn1" runat="server" Text="1" OnClick="BtnClicked"/>
            <asp:Button ID="Btn2" runat="server" Text="2" OnClick="BtnClicked"/>
            <asp:Button ID="Btn3" runat="server" Text="3" OnClick="BtnClicked"/>
            <asp:Button ID="Btn4" runat="server" Text="4" OnClick="BtnClicked"/>
            <asp:Button ID="Btn5" runat="server" Text="5" OnClick="BtnClicked"/>
            <asp:Button ID="Btn6" runat="server" Text="6" OnClick="BtnClicked"/>
            <asp:Button ID="Btn7" runat="server" Text="7" OnClick="BtnClicked"/>
            <asp:Button ID="Btn8" runat="server" Text="8" OnClick="BtnClicked"/>
            <asp:Button ID="Btn9" runat="server" Text="9" OnClick="BtnClicked"/>

            <asp:Button ID="BtnDiv" runat="server" Text="/" OnClick="OperationClicked"/>
            <asp:Button ID="BtnMult" runat="server" Text="*" OnClick="OperationClicked"/>
            <asp:Button ID="BtnSubtract" runat="server" Text="-" OnClick="OperationClicked"/>
            <asp:Button ID="BtnAdd" runat="server" Text="+" OnClick="OperationClicked"/>

            <asp:Button ID="BtnEqual" runat="server" Text="=" OnClick="BtnEqual_Click"/>
            <asp:Button ID="BtnClear" runat="server" Text="C" OnClick="BtnClear_Click"/>
        </div>
    </form>
</body>
</html>
