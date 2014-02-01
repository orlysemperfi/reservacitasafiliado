<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmReservaCita.aspx.cs" Inherits="WebReservaCitasAfiliado.FrmReservaCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 49px;
        }
        .auto-style4 {
            height: 49px;
            width: 147px;
        }
        .auto-style5 {
            width: 147px;
        }
        .auto-style6 {
            height: 23px;
            width: 147px;
        }
        .auto-style7 {
            height: 49px;
            width: 27px;
        }
        .auto-style8 {
            height: 49px;
            width: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <Table class="auto-style1">
        <tr>
            <td colspan="4"><h2>Reserva de Citas Médicas</h2></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Ingrese DNI"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnBuscarAfiliado" runat="server" Text="Buscar Afiliado" />
            </td>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td colspan="3" class="auto-style2">
                <asp:Label ID="lblMensaje" runat="server" style="font-weight: 700; color: #CC0000" Visible="False"></asp:Label>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Centro de Salud"></asp:Label>
            </td>
            <td colspan="3">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text="Consultorio"></asp:Label>
            </td>
            <td colspan="3">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label4" runat="server" style="font-weight: 700" Text="Especialidad"></asp:Label>
            </td>
            <td class="auto-style2" colspan="3">
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label5" runat="server" style="font-weight: 700" Text="Fecha Deseada"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label6" runat="server" style="font-weight: 700" Text="Día"></asp:Label>
            </td>
            <td colspan="3">
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>Cualquier día</asp:ListItem>
                    <asp:ListItem>Lunes a Viernes</asp:ListItem>
                    <asp:ListItem>Sabado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label7" runat="server" style="font-weight: 700" Text="Turno"></asp:Label>
            </td>
            <td colspan="3">
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>Cualquier turno</asp:ListItem>
                    <asp:ListItem>Mañanas</asp:ListItem>
                    <asp:ListItem>Tardes</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label8" runat="server" style="font-weight: 700" Text="Descripción del malestar físico"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="TextBox1" runat="server" Height="95px" Width="276px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </Table>
</asp:Content>
