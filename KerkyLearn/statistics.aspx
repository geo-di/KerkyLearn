<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="statistics.aspx.cs" Inherits="KerkyLearn.statistics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:10% 39%">
        <div >
            <h1>View Your Statistics</h1>
        </div>
        <div id="statdiv">

            <div class="stat">
                <h2 class="statH">Course Completion</h2>
                <p>
                    <asp:Label runat="server" ID="courseCompletion"></asp:Label>
                </p>
                
            </div>
            <div class="stat">
                <h2 class="statH">Most visited courses</h2>
                <ol id="courseList" runat="server">
                </ol>
            </div>
            <div class="stat">
                <h2 class="statH">Your best quiz!</h2>
                <p>
                    <asp:Label runat="server" ID="bestQuiz"></asp:Label></p>
            </div>
            <div class="stat">
                <h2 class="statH">Your worst quiz! :(</h2>
                <p>
                    <asp:Label runat="server" ID="worstQuiz"></asp:Label>

                </p>
            </div>
            <div class="stat">
                <h2 class="statH">Overall Performance</h2>
                <p>
                    <asp:Label runat="server" ID="overall"></asp:Label>
                </p>
            </div>
        </div>
    </div>
</asp:Content>
