<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="produkts.aspx.cs" Inherits="CistellaCompra.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="produkts.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div style="height: 2641px">
    
                    
                
                    <asp:Panel ID="Panel1" runat="server" CssClass="panel1" HorizontalAlign="Center" Height="100px">
                        <br />
                        <asp:Label ID="Label1" runat="server" style="text-align: center; color: #FFFFFF; font-size: x-large; font-weight: 700;" Text="PhoneMarket"></asp:Label>
                    </asp:Panel>
    
                    
                    <asp:Panel ID="Panel2" runat="server" CssClass="panel2" HorizontalAlign="Left">
              
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="63px" ImageUrl="~/img/313c1187480abab29cbfabfc39c8b9be.png" OnClick="ImageButton1_Click" Width="86px" style="margin-left: 0px" />
                        <br />
                        <br />
                        <br />
               
                             </asp:Panel>

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                            <div class="item">
                                <br />
                                &nbsp;<br />
                                 <asp:Image ID="Image1" runat="server" Height="200px" />
                                <br />
                                <br />
                                 <asp:Label ID="Label2" runat="server"></asp:Label>
                                <br />
                                <br />


                                 <br />


                                 <asp:TextBox ID="TextBox1" runat="server" Width="96px"></asp:TextBox>
                                <br />
                                <br />

                                <asp:Button ID="Button1" CssClass="btnAfegir" runat="server" OnClick="Button1_Click" Text="Afegir al Carret" Width="150px" BorderStyle="None" />
                                <br />
                                <br />
                                <asp:Label ID="Label6" runat="server" Font-Names="Segoe UI Semibold" ForeColor="#CC0000"></asp:Label>
                                <br />
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
                                <br />
                                <br />

                            </div>

                            <div class="item">
                                <br />
                                <br />
                                <asp:Image ID="Image2" runat="server" Height="200px" />
                                <br />
                                <br />
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                                <br />
                                <br />
                                <br />
                                <asp:TextBox ID="TextBox2" runat="server" Width="96px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="Button2" CssClass="btnAfegir" runat="server" OnClick="Button2_Click" Text="Afegir al Carret" Width="150px" BorderStyle="None" />
                                <br />
                                <br />
                                <asp:Label ID="Label7" runat="server" Font-Names="Segoe UI Semibold" ForeColor="#CC0000"></asp:Label>
                                <br />
                                <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
                                <br />
                            </div>
                            <div class="item">
                                <br />
                                <br />
                                <asp:Image ID="Image3" runat="server" Height="200px" />
                                <br />
                                <br />
                                <asp:Label ID="Label4" runat="server"></asp:Label>
                                <br />
                                <br />
                                <br />
                                <asp:TextBox ID="TextBox3" runat="server" Width="96px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="Button3" CssClass="btnAfegir" runat="server" Text="Afegir al Carret" Width="150px" OnClick="Button3_Click" BorderStyle="None" />
                                <br />
                                <br />
                                <asp:Label ID="Label8" runat="server" Font-Names="Segoe UI Semibold" ForeColor="#CC0000"></asp:Label>
                                <br />
                                <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
                            </div>
                            <div class="item">
                                <br />
                                <br />
                                <asp:Image ID="Image4" runat="server" Height="200px" />
                                <br />
                                <br />
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                <br />
                                <br />
                                <br />
                                <asp:TextBox ID="TextBox4" runat="server" Width="96px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="Button4" CssClass="btnAfegir" runat="server" Text="Afegir al Carret" Width="150px" OnClick="Button4_Click" BorderStyle="None" />
                                <br />
                                <br />
                                <asp:Label ID="Label9" runat="server" Font-Names="Segoe UI Semibold" ForeColor="#CC0000"></asp:Label>
                                <br />
                                <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="#009900"></asp:Label>
                            </div>
                        

                      
               
              


                </div>
    </form>
</body>
</html>
