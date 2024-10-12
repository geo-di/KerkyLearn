<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="KerkyLearn.index" MasterPageFile="~/site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div style="padding-left:5%">
            <div>
        <section>
            <h1 style="z-index: 100">Welcome to KerkyLearn</h1>
            <br />
        </section>
    </div>

    <div>
        <button id="reg_button" class="button" runat="server" onserverclick="btn_ServerClick"><span>Register to Begin</span></button>
        <h2><asp:Label runat="server" ID="WelcomeMsg" Visible="false"></asp:Label></h2>
    </div>

    <div>
    <footer>
        <section id="footer">
            <div class=" container reveal">
                <h2>Who are we</h2>

                <div class="text-container">
                    <div class="text-box">
                        <h3>AM: P20040 </h3>
                        <p>
                            Name: Georgellis Dimos
                        </p>
                    </div>

                    <div class="text-box">
                        <h3>AM: P20207</h3>
                        <p>
                            Name: Psaros Stamatis
                        </p>
                    </div>

                    <div class="text-box">
                        <h3>AM: P20246</h3>
                        <p>
                            Name: Vlachos Spiridon
                        </p>
                    </div>

                    <div class="text-box">
                        <h3>AM: P20147</h3>
                        <p>
                            Name: Rafalena Oikonomou
                        </p>
                    </div>
                </div>
            </div>
        </section>

    </footer>
</div>
    </div>

    

</asp:Content>
