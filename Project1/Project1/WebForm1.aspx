<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Project1.WebForm1" %>
  <!DOCTYPE html>

  <html xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <title></title>
      <style>
        body {
            margin: 0;
            padding: 0;
            background: #000;
        }

        .Button,
        #display {
            position: absolute;
        }

        #display {
            left: 482px;
            top: 48px;
            text-align: right;
            font-size: 1.6rem;
            width: 100px;
            background: #00000000;
            outline: none;
            border: none;
            color: blue;
            font-family: monospace;
        }

        .Button {
            width: 55px;
            height: 45px;
            background-color: #00000000;
            color: #00000000;
            outline: none;
            border: none;
        }

        .popcorn {
            left: 434px;
            top: 120px;
        }

        .potato {
            left: 487px;
            top: 120px;
        }

        .pizza {
            width: 45px;
            left: 540px;
            top: 120px;
        }

        .veggies {
            left: 586px;
            top: 120px;
        }

        .stop {
            left: 432px;
            top: 341px;
        }

        .add30s {
            left: 502px;
            top: 340px;
        }

        .start {
            left: 570px;
            top: 340px;
        }

        .start,
        .add30s,
        .stop {
            width: 68px;
        }

        .vent {
            width: 80px;
            left: 503px;
            top: 430px;
        }

      </style>
  </head>

  <body>
    <form id="form1" runat="server">

      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:Timer id="Timer1" runat="server" Interval="1000" OnTick="tick"> </asp:Timer>

            <asp:TextBox left="200" top="200" ID="display" runat="server"></asp:TextBox>
            
            <asp:Button runat="server" Text="popcorn" OnClick="foodBtn" class="popcorn Button"></asp:Button>
            <asp:Button runat="server" Text="potato" OnClick="foodBtn" class="potato Button"></asp:Button>
            <asp:Button runat="server" Text="pizza" OnClick="foodBtn" class="pizza Button"></asp:Button>
            <asp:Button runat="server" Text="veggies" OnClick="foodBtn" class="veggies Button"></asp:Button>
            <asp:Button runat="server" Text="stop" OnClick="controlBtn" class="stop Button"></asp:Button>
            <asp:Button runat="server" Text="add30s" OnClick="controlBtn" class="add30s Button"></asp:Button>
            <asp:Button runat="server" Text="start" OnClick="controlBtn" class="start Button"></asp:Button>
            <asp:Button runat="server" Text="vent" OnClick="controlBtn" class="vent Button"></asp:Button>


          <asp:imagemap id="microwave" imageurl="resources/mw0.png" width="750" height="563" alternatetext="Microwave"
            hotspotmode="PostBack" onclick="numpadClick" runat="Server">

            <asp:RectangleHotSpot left="431" top="204" right="503" bottom="236" postbackvalue="1"
              alternatetext="1 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="503" top="204" right="571" bottom="235" postbackvalue="2"
              alternatetext="2 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="571" top="204" right="640" bottom="235" postbackvalue="3"
              alternatetext="3 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="435" top="238" right="503" bottom="271" postbackvalue="4"
              alternatetext="4 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="503" top="235" right="570" bottom="271" postbackvalue="5"
              alternatetext="5 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="570" top="238" right="640" bottom="273" postbackvalue="6"
              alternatetext="6 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="434" top="271" right="500" bottom="300" postbackvalue="7"
              alternatetext="7 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="502" top="272" right="570" bottom="300" postbackvalue="8"
              alternatetext="8 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="571" top="272" right="640" bottom="300" postbackvalue="9"
              alternatetext="9 Button">
            </asp:RectangleHotSpot>

            <asp:RectangleHotSpot left="502" top="302" right="570" bottom="338" postbackvalue="0"
              alternatetext="0 Button">
            </asp:RectangleHotSpot>

          </asp:imagemap>

        </ContentTemplate>
      </asp:UpdatePanel>
    </form>
  </body>

  </html>
