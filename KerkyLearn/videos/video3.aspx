<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="video3.aspx.cs" Inherits="KerkyLearn.videos.video3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <h1 class="lesson-title" runat="server">ΒΙΝΤΕΟ ΤΡΙΤΗΣ ΕΝΟΤΗΤΑΣ</h1>
        <br />
        <div style="text-align: center;">
            <video class="vid" autoplay="autoplay" muted="muted" controls="controls" runat="server" src="../media/video3.mp4">
                <source type="video/mp4" />

                Your browser does not support HTML video.
            </video>
            <br /><br />
        </div>
            <a href="../dashboard.aspx" style="margin-bottom:5vh">Click to go back to dashboard</a>

</div>
</asp:Content>
