<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="KerkyLearn.quizClass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div style="display:block;margin-top:5%;padding:10% 35%;">

        <h1 ><asp:Label ID="quizTitle" runat="server"></asp:Label></h1><br />
                <div class="quiz">
                    <h2><asp:Label ID="Question" runat="server"></asp:Label></h2><br />
                    <asp:RadioButtonList ID="answerList" runat="server" RepeatDirection="Vertical">
                        <asp:ListItem runat="server" ID="listItem1" Value="0"></asp:ListItem>
                        <asp:ListItem runat="server" ID="listItem2" Value="1"></asp:ListItem>
                        <asp:ListItem runat="server" ID="listItem3" Value="2"></asp:ListItem>
                        
                        
                    </asp:RadioButtonList>
                    <br />
                    <asp:Button ID="submitButton" runat="server" Text="Submit Answers" OnClick="submitButton_Click" />
                </div>
        
        <a href="dashboard.aspx"><asp:Label ID="messageText" runat="server" Visible="false"></asp:Label></a>
                                

        </div>
        </div>

</asp:Content>
