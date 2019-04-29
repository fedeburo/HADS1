<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinador.aspx.cs" Inherits="webprueba.coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Asignatura a calcular la nota promedio:<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="Nombre">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Valor medio: "></asp:Label>
            <asp:Label ID="lblValor" runat="server"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString2 %>" SelectCommand="SELECT [Nombre] FROM [Asignaturas]"></asp:SqlDataSource>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesor/Profesor.aspx">Volver a inicio</asp:HyperLink>
    </form>
</body>
</html>
