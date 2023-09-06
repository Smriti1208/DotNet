<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookInventory.aspx.cs" Inherits="Books.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Book Inventory</h1>

            <asp:TextBox runat="server" ID="txtSearch" placeholder="SearchBooks"/>
            <asp:Button runat="server" ID="btnSearch" placeholder="Search" OnClick="btnSearch_Click"/>
        </div>

        <div>
            <h2>Add a new Book</h2>
            <table>
                <tr>
                    <td>Title:</td>
                    <td><asp:TextBox ID="txtTitle" runat="server" /></td>
                </tr>
                <tr>
                    <td>Author:</td>
                    <td><asp:TextBox ID="txtAuthor" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnAddBook" Text="Add Book" OnClick="btnAddBook_Click" runat="server" /></td>
                </tr>
            </table>

            <h2>Book Inventory</h2>
            <asp:GridView ID="gridBooks" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
