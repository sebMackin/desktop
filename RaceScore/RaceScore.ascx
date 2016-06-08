<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RaceScore.ascx.cs" Inherits="Purplecs.Modules.RaceScore.RaceScore" %>
<h1>Race Score</h1>

<asp:Repeater ID="rptScores" runat="server">
        <HeaderTemplate>
            <ul class="tm_tl">
                
        </HeaderTemplate>

        <ItemTemplate>
            <li class="tm_t">
                
                
                <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Racer_Name").ToString() %>' /> Score: <asp:TextBox ID="txtScore" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Score").ToString() %>'/>
                <asp:HiddenField ID="hfScoreID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"ID").ToString() %>' />
                <asp:HiddenField ID="hfRacerID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"Racer_ID") %>' />
            </li>
        </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>     
     
<asp:Button ID="btnSave" runat="server" Text="Save Scores" OnClick="btnSave_Click" />