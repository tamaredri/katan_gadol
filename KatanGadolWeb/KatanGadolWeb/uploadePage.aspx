<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadePage.aspx.cs" Inherits="KatanGadolWeb.uploadePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="./css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="tDiv">
            <img src="./Images/Asset 21.png"/>
        </div>
        <hr />
        <div id="openDiv">
            <asp:Label ID="openingSection" runat="server">
                ברוכים הבאים!
                <br />
                רק פרטים קטנים והסרט שלכם מוכן:)
                <br />
                תודה לכם ולנו..
            </asp:Label>

        </div>  
            <hr />
        <div>
            <asp:Label CssClass="lable part1" ID="Name_Lable" runat="server" Text="שם האיש"></asp:Label>
            <asp:TextBox ID="Name" runat="server" placeholder="שם"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="lable part1" ID="Age_Lable" runat="server" Text="גיל כיום"></asp:Label>
            <asp:TextBox ID="Age" runat="server" placeholder="גיל"></asp:TextBox>
        </div>

        <hr />

        <div>
            <asp:Label CssClass="lable" ID="residence_Lable" runat="server" Text="מקום מגורים בזמן השואה"></asp:Label>
            <asp:TextBox ID="country" runat="server" placeholder="מגורים"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="lable" ID="photo_Label" runat="server" Text="תמונה של ניצול השואה "></asp:Label>
            <asp:FileUpload ID="photo" runat="server" />
        </div>

        <div>
            <asp:Label CssClass="lable" ID="conclusionPhoto_Lable" runat="server" Text="תמונת סיכום"></asp:Label>
            <asp:FileUpload ID="conclusionPhoto" runat="server" />
        </div>

        <hr />

        <div class="divColumn">
            <asp:Label CssClass="lable" ID="introVideo_Lable" runat="server" Text="סרטון 1- סיפור משמעותי מהשואה"></asp:Label>
            <asp:FileUpload ID="introVideo" runat="server" />
        </div>

        <div class="divColumn">
            <asp:Label CssClass="lable" ID="Label8" runat="server" Text="סרטון 2- החיים שאחרי"></asp:Label>
            <asp:FileUpload ID="storyVideo" runat="server" />
        </div>
        <asp:Button ID="Button3" runat="server" Text="שלח" OnClick="Button3_Click" />

    </form>
</body>
</html>
