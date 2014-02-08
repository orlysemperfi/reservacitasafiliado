<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmMantenimientoDeAfiliado.aspx.cs" Inherits="WebReservaCitasAfiliado.FrmMantenimientoDeAfiliado" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="4"><h2>Mantenimiento de Afiliados</h2></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Ingrese DNI"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnBuscarAfiliado" runat="server" Text="Buscar en Reniec" OnClick="btnBuscarAfiliado_Click" />
            </td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style3">
                </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">
                <asp:Label ID="lblMensaje" runat="server" style="font-weight: 700; color: #CC0000" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Nombre"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtNombre" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text="Apellido Paterno"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtApePaterno" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" style="font-weight: 700" Text="Apellido Materno"></asp:Label>
            </td>
            <td class="auto-style2" colspan="3">
                <asp:TextBox ID="txtApeMaterno" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" style="font-weight: 700" Text="Dirección"></asp:Label>
            </td>
            <td colspan="3">
                <asp:TextBox ID="txtDireccion" runat="server" Width="445px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" style="font-weight: 700" Text="Fecha Nacimiento"></asp:Label>
            </td>
            <td colspan="2">
                <asp:Calendar ID="CaFechaNacimiento" runat="server"></asp:Calendar>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" style="font-weight: 700" Text="Estado"></asp:Label>
            </td>
            <td colspan="2">
                <asp:RadioButtonList ID="rdbLstEstado" runat="server" RepeatDirection="Horizontal" Width="190px">
                    <asp:ListItem Selected="True" Value="1">Activo</asp:ListItem>
                    <asp:ListItem Value="0">Inactivo</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Button ID="btnRegistrarAfiliado" runat="server" Text="Registrar Afiliado" OnClick="btnRegistrarAfiliado_Click" />
                <asp:Button ID="BtnActualizarAfiliado" runat="server" Text="Actualizar Afiliado" OnClick="BtnActualizarAfiliado_Click" />
                <asp:Button ID="btnCamcelarRegistro" runat="server" Text="Limpiar Controles" OnClick="btnCamcelarRegistro_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="6" style="text-align:center">
                <asp:GridView ID="GvAfiliados" DataKeyNames="IdAfiliado" runat="server" AutoGenerateColumns="False"  OnSelectedIndexChanged="GvAfiliados_SelectedIndexChanged" OnRowDeleting="GvAfiliados_RowDeleting">
                    <Columns>
                        <asp:CommandField HeaderText="Seleccionar" SelectText="Seleccionar" ShowSelectButton="True" />
                        <asp:BoundField DataField="IdAfiliado" HeaderText="IdAfiliado" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApePaterno" HeaderText="Apellido Paterno" />
                        <asp:BoundField DataField="ApeMaterno" HeaderText="Apellido Materno" />
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:TemplateField HeaderText="Delete">
	<ItemTemplate>
		<asp:Button ID="deleteButton" runat="server" CommandName="Delete" Text="Eliminar"
OnClientClick="return confirm('¿Deseas Eliminar al Afiliado?');" />
	</ItemTemplate>
</asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        </table>
</asp:Content>
