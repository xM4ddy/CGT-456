<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="colors.aspx.cs" Inherits="Assign04.colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		body {
			font-family: "Proxima Nova", "Helvetica Neue", "Helvetica", "Segoe UI", FreeSans, Arial, sans-serif;
			color: #cdd6f4;
			background-color: #1e1e2e;
			font-size: 1.15rem;
			line-height: 1.8;
			font-weight: bold;
		}

		h1 {
			font-size: 2.5rem;
		}

		table {
			margin: auto;
			border-collapse: collapse;
		}

		tr {
			border-radius: 3px;
		}

		td {
			padding: 0.5rem;
			width: fit-content;
		}

		select {
			font-size: 1.25rem;
			border: 1px #cdd6f4 solid;
			border-radius: 3px;
			background-color: #1e1e2e;
			color: #cdd6f4;
		}

		input:disabled {
			font-size: 1.25rem;
			color: #cdd6f4;
			background: none;
			outline: none;
			border: none;
			text-align: center;
		}

		#bgColor {
			border: 3px solid #cdd6f4;
			border-radius: 3px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
			<asp:UpdatePanel ID="UpdatePanel1" runat="server">
				<ContentTemplate>

					<table border="0">
						<tr>
							<td colspan="15"><h1>Binary, Hex, & Bitwise Colors</h1></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td colspan="8">
								<div style="text-align:center;">Binary Digits</div>
							</td>
							<td>&nbsp;</td>
							<td>&nbsp;</td>
							<td>Decimal Value </td>
							<td>&nbsp;</td>
							<td>Hex Value </td>
							<td>
								<div style="text-align:center;">Color</div>
							</td>
						</tr>
						<tr style="border: 3px #cdd6f4 solid;">
							<td>
								<div style="text-align:center; color:#f38ba8; margin-top: -0.18em;">R</div>
							</td>
							<td>
								<asp:DropDownList ID="red8" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red7" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red6" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red5" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red4" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red3" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red2" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="red1" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>&nbsp;</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="rDecText" Width="100" runat="server" disabled="true" Text="00"></asp:TextBox>
							</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="rHexText" Width="100" runat="server" disabled="true" Text="00">
								</asp:TextBox>
							</td>
							<asp:TableCell rowspan="3" ID="bgColor" runat="server" BackColor="Black" Width="200px"></asp:TableCell>
						</tr>
						<tr style="border: 3px #cdd6f4 solid;">
							<td style="border-left: 3px solid #cdd6f4;">
								<div style="text-align:center; color:#a6e3a1; margin-top: -0.18rem;">G</div>
							</td>
							<td>
								<asp:DropDownList ID="green8" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green7" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green6" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green5" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green4" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green3" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green2" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="green1" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>&nbsp;</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="gDecText" Width="100" runat="server" disabled="true" Text="00"></asp:TextBox>
							</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="gHexText" Width="100" runat="server" disabled="true" Text="00"></asp:TextBox>
							</td>
						</tr>
						<tr style="border: 3px #cdd6f4 solid;">
							<td style="border-left: 3px solid #cdd6f4;">
								<div style="text-align:center; color:#89b4fa; margin-top: -0.18em;">B</div>
							</td>
							<td>
								<asp:DropDownList ID="blue8" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue7" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue6" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue5" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue4" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue3" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue2" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>
								<asp:DropDownList ID="blue1" OnSelectedIndexChanged="valueChanged"
									AutoPostBack="true" runat="server">
									<asp:ListItem value="0" text="0" />
									<asp:ListItem value="1" text="1" />
								</asp:DropDownList>
							</td>
							<td>&nbsp;</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="bDecText" Width="100" runat="server" disabled="true" Text="00"></asp:TextBox>
							</td>
							<td>=</td>
							<td>
								<asp:TextBox ID="bHexText" Width="100" runat="server" disabled="true" Text="00">
								</asp:TextBox>
							</td>
						</tr>
						<tr>
							<td colspan="9">Bitwise</td>
							<td colspan="3" style="text-align:center; vertical-align:bottom;">
								<asp:DropDownList ID="bit1" OnSelectedIndexChanged="bitwise"
									AutoPostBack="true"
									runat="server">
									<asp:ListItem value="--" text="--" />
									<asp:ListItem value="R" text="R" />
									<asp:ListItem value="G" text="G" />
									<asp:ListItem value="B" text="B" />
								</asp:DropDownList>

								<asp:DropDownList ID="bit2" OnSelectedIndexChanged="bitwise"
									AutoPostBack="true"
									runat="server">
									<asp:ListItem value="--" text="--" />
									<asp:ListItem value="&" text="&" />
									<asp:ListItem Value="|" Text="|" />
									<asp:ListItem Value="^" Text="^" />
								</asp:DropDownList>

								<asp:DropDownList ID="bit3" OnSelectedIndexChanged="bitwise"
									AutoPostBack="true"
									runat="server">
									<asp:ListItem Value="--" text="--" />
									<asp:ListItem value="R" text="R" />
									<asp:ListItem value="G" text="G" />
									<asp:ListItem value="B" text="B" />
								</asp:DropDownList>
							</td>
							<td style="vertical-align:bottom;">
								<asp:Label ID="bitEqual" runat="server" Text="="></asp:Label>
							</td>
							<td style="vertical-align:bottom;">
								<asp:TextBox ID="bitwiseResult" Width="100" runat="server"></asp:TextBox>
							</td>
						</tr>
					</table>
				</ContentTemplate>
			</asp:UpdatePanel>
		</div>
	</form>
</body>
</html>

