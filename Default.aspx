<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BasicCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div style="font-size:x-large; text-align:center">Student Info Manage Form</div>
        <br /> 
        <table class="nav-justified">
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">Student ID</td>
                <td>
                    <asp:TextBox ID="StudentIDValue" runat="server" Font-Size="Medium" Width="205px"></asp:TextBox>
                    <asp:Button ID="GetButton" runat="server" BackColor="#6666FF" Font-Bold="True" Text="GET" Width="69px" OnClick="GetButton_Click" style="margin-left: 31" />
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">Student Name</td>
                <td>
                    <asp:TextBox ID="StudentNameValue" runat="server" Font-Size="Medium" Width="203px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">Adress</td>
                <td>
                    <asp:DropDownList ID="AdressValue" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Lubumbashi</asp:ListItem>
                        <asp:ListItem>Kinshasa</asp:ListItem>
                        <asp:ListItem>Matadi</asp:ListItem>
                        <asp:ListItem>Likasi</asp:ListItem>
                        <asp:ListItem>Goma</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">Age</td>
                <td>
                    <asp:TextBox ID="AgeValue" runat="server" Font-Size="Medium" Width="205px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">Contact</td>
                <td>
                    <asp:TextBox ID="ContactValue" runat="server" Font-Size="Medium" Width="205px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">&nbsp;</td>
                <td>
                    <asp:Button ID="InsertButton" runat="server" BackColor="#6666FF" Font-Bold="True" Text="Insert" Width="75px" OnClick="InsertButton_Click" />
                    <asp:Button ID="UpdateButton" runat="server" BackColor="#6666FF" Font-Bold="True" Text="Update" Width="75px" OnClick="UpdateButton_Click" />
                    <asp:Button ID="DeleteButton" runat="server" BackColor="#6666FF" Font-Bold="True" OnClientClick="return confirm('Are you sure to Delete ?')" Text="Delete" Width="75px" OnClick="DeleteButton_Click" />
                    <asp:Button ID="SearchButton" runat="server" BackColor="#6666FF" Font-Bold="True" Text="Search" Width="75px" OnClick="SearchButton_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 194px">&nbsp;</td>
                <td style="width: 178px">&nbsp;</td>
                <td>
                    <asp:GridView ID="RecordTable" runat="server" Width="594px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
