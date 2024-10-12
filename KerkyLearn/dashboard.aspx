<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="KerkyLearn.dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">

        <h1>Learning About Kerkyra</h1>

        <div class="collapsible-list">
            <asp:Panel runat="server" CssClass="panel">
                <div class="heading">
                    <a class="collapsible">ΕΝΟΤΗΤΑ 1: ΕΙΣΑΓΩΓΗ ΣΤΗΝ ΠΑΛΑΙΑ ΠΟΛΗ ΤΗΣ ΚΕΡΚΥΡΑΣ</a>
                    <a id="toggle-all" class="dash-button">Expand All</a>

                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course1.aspx"  class="dash-button">ΜΑΘΗΜΑ 1: ΓΝΩΡΙΜΙΑ ΜΕ ΤΗΝ ΠΑΛΑΙΑ ΠΟΛΗ</a></li>
                        <li><a href="videos/video1.aspx" class="dash-button">ΒΙΝΤΕΟ 1: ΠΡΟΒΟΛΗ ΤΗΣ ΠΑΛΑΙΑΣ ΠΟΛΗΣ</a></li>
                        <li ><a href="quiz.aspx?id=1" class="dash-button quiz1" id="quiz1" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΠΡΩΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>

            <hr />
            <asp:Panel runat="server" CssClass="panel" ID="unit2a" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:green">ENOTHTA 2: ΕΠΑΝΑΛΗΨΗ ΓΙΑ ΤΗΝ ΠΑΛΑΙΑ ΠΟΛΗ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course2a.aspx"  class="dash-button">ΜΑΘΗΜΑ 2: ΑΝΑΛΥΤΙΚΟΤΕΡΑ Η ΠΑΛΑΙΑ ΠΟΛΗ</a></li>
                        <li><a href="videos/video2.aspx" class="dash-button">ΒΙΝΤΕΟ 2: ΞΕΝΑΓΗΣΗ ΣΤΗΝ ΠΑΛΑΙΑ ΠΟΛΗ</a></li>
                        <li><a href="quiz.aspx?id=2" class="dash-button" id="quiz2a" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΔΕΥΤΕΡΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit2b" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:orange">ENOTHTA 2: ΣΤΑ ΚΑΝΤΟΥΝΙΑ ΤΗΣ ΠΑΛΑΙΑΣ ΠΟΛΗΣ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course2b.aspx"  class="dash-button">ΜΑΘΗΜΑ 2: ΑΝΑΛΥΤΙΚΟΤΕΡΑ Η ΠΑΛΑΙΑ ΠΟΛΗ</a></li>
                        <li><a href="videos/video2.aspx" class="dash-button">ΒΙΝΤΕΟ 2: ΞΕΝΑΓΗΣΗ ΣΤΗΝ ΠΑΛΑΙΑ ΠΟΛΗ</a></li>
                        <li><a href="quiz.aspx?id=2" class="dash-button" id="quiz2b" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΔΕΥΤΕΡΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>


            <hr id="hr2" runat="server" visible="false"/>
            <asp:Panel runat="server" CssClass="panel" ID="unit3a" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:green">ENOTHTA 3:ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ ΣΤΑ ΓΡΗΓΟΡΑ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course3a.aspx"  class="dash-button">ΜΑΘΗΜΑ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video3.aspx" class="dash-button">ΒΙΝΤΕΟ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=3" class="dash-button" id="quiz3a" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΡΙΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit3b" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:orange">ENOTHTA 3: ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course3b.aspx"  class="dash-button">ΜΑΘΗΜΑ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video3.aspx" class="dash-button">ΒΙΝΤΕΟ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=3" class="dash-button" id="quiz3b" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΡΙΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit3c" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:orangered">ENOTHTA 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ ΚΑΙ Η ΙΣΤΟΡΙΑ ΤΟΥ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course3c.aspx"  class="dash-button">ΜΑΘΗΜΑ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video3.aspx" class="dash-button">ΒΙΝΤΕΟ 3: ΤΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=3" class="dash-button" id="quiz3c" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΡΙΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <hr  id="hr3" runat="server" visible="false"/>
            <asp:Panel runat="server" CssClass="panel" ID="unit4a" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:green">ENOTHTA 4: ΟΣΑ ΠΡΕΠΕΙ ΝΑ ΞΕΡΕΙΣ ΓΙΑ ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course4a.aspx"  class="dash-button">ΜΑΘΗΜΑ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video4.aspx" class="dash-button">ΒΙΝΤΕΟ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=4" class="dash-button" id="quiz4a" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΕΤΑΡΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit4b" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:orange">ENOTHTA 4: ΤΟ ΟΧΙ ΚΑΙ ΤΟΣΟ ΠΑΛΑΙΟ ΦΡΟΥΡΙΟ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course4b.aspx"  class="dash-button">ΜΑΘΗΜΑ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video4.aspx" class="dash-button">ΒΙΝΤΕΟ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=4" class="dash-button" id="quiz4b" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΕΤΑΡΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit4c" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:orangered">ENOTHTA 4: ΝΕΟ ΦΡΟΥΡΙΟ ΤΗΣ ΚΕΡΚΥΡΑΣ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course4c.aspx"  class="dash-button">ΜΑΘΗΜΑ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video4.aspx" class="dash-button">ΒΙΝΤΕΟ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=4" class="dash-button" id="quiz4c" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΕΤΑΡΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="unit4d" Visible="false">
                <div class="heading">
                    <a class="collapsible" style="color:darkred">ENOTHTA 4: ΣΗΜΑΝΤΙΚΕΣ ΠΛΗΡΟΦΟΡΙΕΣ ΓΙΑ ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a>
                </div>
                <div class="content">
                    <ul>
                        <li><a href="courses/course4d.aspx"  class="dash-button">ΜΑΘΗΜΑ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ</a></li>
                        <li><a href="videos/video4.aspx" class="dash-button">ΒΙΝΤΕΟ 4: ΤΟ ΝΕΟ ΦΡΟΥΡΙΟ ΑΠΟ ΨΗΛΑ</a></li>
                        <li><a href="quiz.aspx?id=4" class="dash-button" id="quiz4d" runat="server">ΚΟΥΙΖ ΣΤΗΝ ΤΕΤΑΡΤΗ ΕΝΟΤΗΤΑ</a></li>
                    </ul>
                </div>
            </asp:Panel>
            <hr  id="hr4" runat="server" visible="false"/>
            <asp:Panel runat="server" CssClass="panel" ID="Final" Visible="false">
                <div class="heading">
                      <a href="quiz.aspx?id=5" class="dash-button" id="finalquiz" runat="server">ΤΕΛΙΚΟ ΕΠΑΝΑΛΗΠΤΙΚΟ ΚΟΥΙΖ</a>
                </div>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="panel" ID="Congrats" Visible="false">
                <div class="heading">
                      <a href="congrats.aspx" class="dash-button"  runat="server">ΣΥΓΧΑΡΗΤΗΡΙΑ ΟΛΟΚΛΗΡΩΣΑΤΕ ΕΠΙΤΥΧΩΣ ΤΟ ΜΑΘΗΜΑ!<br /> ΠΑΤΗΣΤΕ ΕΔΩ ΓΙΑ ΝΑ ΚΕΡΔΙΣΕΤΕ ΤΟ ΤΡΟΠΑΙΟ ΣΑΣ!</a>
                </div>
            </asp:Panel>


        </div>
        </div>

</asp:Content>
