<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ESCUELA.aspx.cs" Inherits="QUIZ.Capa_Vista.ESCUELA" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema de Manejo de Escuelas</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }
        .section {
            display: flex;
            align-items: flex-start;
            gap: 20px;
        }
        .section h1 {
            flex-shrink: 0;
            font-size: 18px;
            margin: 0;
            width: 150px; 
        }
        .grid-container {
            display: flex;
            flex-direction: column;
        }
        .form-container label {
            display: block;
            margin: 5px 0 3px;
        }
        .form-container input {
            width: 100%; 
            margin-bottom: 10px;
            padding: 5px;
            font-size: 14px;
        }
        .form-container .buttons {
            margin-top: 10px;
        }
        .form-container .buttons button {
            margin-right: 5px;
        }
        div {
            background: #F7DCC7;
        }
    </style>
</head>
<body>
    <form id="ESCUELA" runat="server">
        <div class="container">
            <div class="section">
                <h1>Schools</h1>
                <asp:GridView ID="GridView1" runat="server" Width="602px"></asp:GridView>
            </div>
            <div class="form-container">
                <label for="tID">SchoolID:</label>
                <asp:TextBox ID="tID" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tNombre">School Name:</label>
                <asp:TextBox ID="tNombre" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tDescripcion">Descripcion:</label>
                <asp:TextBox ID="tDescripcion" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tAddres">Address:</label>
                <asp:TextBox ID="tAddres" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tPhone">Phone:</label>
                <asp:TextBox ID="tPhone" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tPostCode">PostCode:</label>
                <asp:TextBox ID="tPostCode" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tPostAddress">PostAddress:</label>
                <asp:TextBox ID="tPostAddress" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <div class="buttons">
                    <asp:Button ID="bAgregar" runat="server" Text="Agregar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bAgregar_Click" />
                    <asp:Button ID="bBorrar" runat="server" Text="Borrar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bBorrar_Click" />
                    <asp:Button ID="bModificar" runat="server" Text="Modificar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bModificar_Click" />
                    <asp:Button ID="bConsultar" runat="server" Text="Consultar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bConsultar_Click" />
                </div>
            </div>

            <div class="section">
                <h1>Class </h1>


             <asp:GridView ID="GridView2" runat="server" Width="599px"></asp:GridView>
                   
            </div>
            <div class="form-container">
                <label for="tID2">Class ID:</label>
                <asp:TextBox ID="tID2" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tSchoolID">School ID:</label>
                <asp:TextBox ID="tSchoolID" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tClassName">Class Name:</label>
                <asp:TextBox ID="tClassName" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <label for="tDescripcion2">Descripcion:</label>
                <asp:TextBox ID="tDescripcion2" runat="server" BackColor="#CCCCCC" BorderColor="Black"></asp:TextBox>

                <div class="buttons">
                    <asp:Button ID="bAgregar2" runat="server" Text="Agregar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bAgregar2_Click" />
                    <asp:Button ID="bBorrar2" runat="server" Text="Borrar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bBorrar2_Click" />
                    <asp:Button ID="bModificar2" runat="server" Text="Modificar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bModificar2_Click" />
                    <asp:Button ID="bConsultar2" runat="server" Text="Consultar" BackColor="#3399FF" BorderColor="Black" Font-Names="Arial Black" Font-Size="Medium" OnClick="bConsultar2_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
