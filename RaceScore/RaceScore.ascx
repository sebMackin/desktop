<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RaceScore.ascx.cs" Inherits="Purplecs.Modules.RaceScore.RaceScore" %>
<h1>Race Scores</h1>

<asp:Repeater ID="rptScores" runat="server">
    
        <ItemTemplate>

            <div class="panel panel-info">

                <div class="panel-heading">

                    <h4>
                        <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Racer_Name").ToString() %>' /> 
                    </h4>

                </div>

                <div class="panel-body">

                
                <h5>
                    <asp:Label ID="lblScore" runat="server" Text="Score:"/> 
                </h5>

                <asp:TextBox ID="txtScore" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Score").ToString() %>'/>

                <asp:HiddenField ID="hfScoreID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"ID").ToString() %>' />

                <asp:HiddenField ID="hfRacerID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"Racer_ID") %>' />

                </div>
                
            </div>

        </ItemTemplate>
   
</asp:Repeater>     
     
<asp:Button ID="btnSave" runat="server" Text="Save Scores" OnClick="btnSave_Click" CssClass="btn btn-primary" />
