<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cistella.aspx.cs" Inherits="CistellaCompra.cistella" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="estils.css">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 33px;
            width: 227px;
        }
        .auto-style2 {
            font-size: large;
            color: #33CC33;
        }
        .auto-style4 {
            height: 62px;
            width: 896px;
            margin-right: 0px;
        }
        .auto-style6 {
            color: #FF0000;
        }
        .auto-style7 {
            height: 1105px;
        }
        .auto-style8 {
            height: 53px;
            width: 156px;
        }
        .auto-style9 {
            width: 156px;
        }
        .auto-style10 {
            height: 33px;
            width: 156px;
        }
        </style>
    </head>
<body style="height: 1102px">
    <form id="form1" runat="server">
        <div class="auto-style7">
                <asp:Panel ID="Panel1" runat="server" CssClass="panel1" HorizontalAlign="Center" Height="100px">
                        <br />
                        <asp:Label ID="Label1" runat="server" style="text-align: center; color: #FFFFFF; font-size: x-large; font-weight: 700;" Text="PhoneMarket"></asp:Label>
                    </asp:Panel>
    
                    
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel2" HorizontalAlign="Left" BorderStyle="None">
                                               &nbsp;<asp:Button ID="Button1" CssClass="btnBack" runat="server" BackColor="#333333" ForeColor="#0071E3" Height="60px" Text="&lt; Back" Width="100px" OnClick="Button1_Click" style="font-weight: 700; font-size: large" BorderStyle="None" />
                        
                             </asp:Panel>                      
                  <asp:Panel ID="Panel3" runat="server" Height="942px" Direction="LeftToRight" HorizontalAlign="Center">
                      <br />
                      <br />
                      <table class="auto-style4">
                          <tr>
                              <td class="auto-style8">
                                  <asp:Label ID="Label3" runat="server" CssClass="labels">Nom i Cognoms: </asp:Label>
                              </td>
                              <td class="auto-style1">
                                  <br />
                                  <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Width="210px" />
                                  <br />
                                  <br />
                                  <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:Label ID="Label7" runat="server" CssClass="auto-style6"></asp:Label>
                                  </strong>
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style9">
                                  <asp:Label ID="Label4" runat="server" CssClass="labels" Text="DNI: " />
                              </td>
                              <td class="auto-style1">
                                  <br />
                                  <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Width="210px" />
                                  <br />
                                  <strong>
                                  <br />
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:Label ID="Label8" runat="server" CssClass="auto-style6"></asp:Label>
                                  </strong>
                              </td>
                          </tr>
                          <tr class="tdtxt">
                              <td class="auto-style10">
                                  <asp:Label ID="Label5" runat="server" CssClass="labels" Text="Telèfon: " />
                              </td>
                              <td class="auto-style1">
                                  <br />
                                  <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox" Width="210px" />
                                  <br />
                                  <br />
                                  <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                  <asp:Label ID="Label9" runat="server" CssClass="auto-style6"></asp:Label>
                                  </strong>
                              </td>
                          </tr>
                      </table>
                      <br />
                      <br />
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label2" runat="server" style="font-weight: 700; font-size: x-large"></asp:Label>
                      <br />
                      <br />
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="Button2" runat="server" BorderStyle="None" CssClass="btnComanda" Height="61px" OnClick="Button2_Click" Text="Realitzar Comanda" Width="249px" />
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <strong>
                      <asp:Label ID="Label6" runat="server" CssClass="auto-style2"></asp:Label>
                      </strong>
                 
                  
                  </asp:Panel>

                       
               

        </div>
    </form>
</body>
</html>
