<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadePage.aspx.cs" Inherits="KatanGadolWeb.uploadePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="title" runat="server" Text="קטן_גדול"></asp:Label>
        </div>
        <div>
            <asp:Label ID="openingSection" runat="server" Text="טקסט פתיחה"></asp:Label>
        </div>  
        <div>
            <asp:TextBox ID="Name" runat="server">שם</asp:TextBox>
            <asp:Label ID="Name_Lable" runat="server" Text="שם האיש"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="Age" runat="server">גיל</asp:TextBox>
            <asp:Label ID="Age_Lable" runat="server" Text="גיל כיום"></asp:Label>
        </div>


        <div>
            <asp:DropDownList ID="residence" runat="server"/>
            <asp:Label ID="residence_Lable" runat="server" Text="מקום מגורים בזמן השואה"></asp:Label>
        </div>

        <div>
            <asp:FileUpload ID="photo" runat="server" />
            <asp:Label ID="photo_Label" runat="server" Text="תמונה של ניצול השואה "></asp:Label>
        </div>

        <div>
            <asp:FileUpload ID="conclusionPhoto" runat="server" />
            <asp:Label ID="conclusionPhoto_Lable" runat="server" Text="תמונת סיכום"></asp:Label>
        </div>

        <div>
            <asp:FileUpload ID="introVideo" runat="server" />
            <asp:Label ID="introVideo_Lable" runat="server" Text="סרטון 1- סיפור משמעותי מהשואה"></asp:Label>
        </div>

        <div>

            <asp:FileUpload ID="storyVideo" runat="server" />
            <asp:Label ID="Label8" runat="server" Text="סרטון 2- החיים שאחרי"></asp:Label>
        </div>
        <asp:ImageButton ID="storyVideo_Label" runat="server" />
        <asp:Button ID="Button3" runat="server" Text="שלח" />

    </form>
</body>
</html>
