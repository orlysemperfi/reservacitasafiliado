<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmHistorialDeCitas.aspx.cs" Inherits="WebReservaCitasAfiliado.FrmHistorialDeCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 202px;
            margin-bottom: 43px;
        }
        .auto-style3 {
            height: 49px;
            width: 175px;
        }
        .auto-style6
        {
            height: 49px;
            width: 28px;
        }
        .auto-style7
        {
            width: 28px;
        }
        .auto-style8
        {
            height: 49px;
            width: 36px;
        }
        .auto-style9
        {
            width: 36px;
        }
        .auto-style10
        {
            height: 49px;
            width: 17px;
        }
        .auto-style11
        {
            width: 17px;
        }
        .auto-style12
        {
            width: 36px;
            height: 48px;
        }
        .auto-style13
        {
            width: 17px;
            height: 48px;
        }
        .auto-style14
        {
            height: 48px;
        }
        .auto-style15
        {
            width: 175px;
        }
        .auto-style16
        {
            width: 36px;
            height: 22px;
        }
        .auto-style17
        {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
               <td colspan="5"><h2>Historial de Citas</h2></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Ingrese DNI"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label10" runat="server" style="font-weight: 700" Text="Desde"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="txtDesde" runat="server" TextMode="Date" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label11" runat="server" style="font-weight: 700" Text="Hasta"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtHasta" runat="server" TextMode="Date" CausesValidation="True" ValidateRequestMode="Enabled"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td colspan="3" class="auto-style17">
                <asp:Label ID="lblMensaje" runat="server" style="font-weight: 700; color: #CC0000" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Afiliado"></asp:Label>
            </td>
            <td colspan="3">
                <asp:Label ID="lblNombre" runat="server"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13">
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" Width="178px" />
            </td>
            <td colspan="2" class="auto-style14">
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" Width="145px" />
            </td>
            <td></td>
        </tr>
        <tr>
          <td colspan="5" class="auto-style14">
                <asp:GridView ID="grdListado" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CaptionAlign="Top" CellPadding="3" Font-Names="Arial" Font-Size="Small" GridLines="Vertical" Width="734px" DataKeyNames="IdAfiliado">
                    <AlternatingRowStyle BackColor="Gainsboro" />
                    <Columns>
                        <asp:BoundField HeaderText="Fecha" ReadOnly="True" />
                        <asp:BoundField HeaderText="Nro.Cita" ReadOnly="True" DataField="IdAfiliado" />
                        <asp:BoundField HeaderText="Centro" ReadOnly="True" />
                        <asp:BoundField HeaderText="Medico" ReadOnly="True" />
                        <asp:BoundField HeaderText="Consultorio" ReadOnly="True" />
                        <asp:BoundField HeaderText="Observacion" ReadOnly="True" />
                        <asp:BoundField HeaderText="Estado" ReadOnly="True" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </td>
        </tr>
        </table>
</asp:Content>

