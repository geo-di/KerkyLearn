<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KerkyLearn.login" MasterPageFile="~/site.Master" %>


<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div style="width:100%;padding:5% 20%;">      
        <div class="col-md-6">    
                      
                <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br/>
            
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>&nbsp&nbsp


                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="smallbtn" /><br /><br />
        </div>   
          
        
        <div>
            <asp:Label ID="Label3" runat="server" Text="Are you new? Register here: "></asp:Label><br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register Now!" CssClass="smallbtn" />
        </div>
    </div>  


   
</asp:Content>       
   
