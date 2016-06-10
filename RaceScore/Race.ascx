<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Race.ascx.cs" Inherits="Purplecs.Modules.RaceScore.Race" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<h1>Races</h1>

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    
    <fieldset>

        <%-- Adds the textbox for the user to enter the race name into the database --%>
        <div>
            <h4>
                <asp:Label ID="lblRaceName" runat="server" Text="Race Name:"/>
            </h4>

            <asp:TextBox ID="txtRacename" runat="server"/>
        </div>
        <asp:RequiredFieldValidator ID="rfvRace" ControlToValidate="txtRaceName" ErrorMessage="Enter a race name" 
        ValidationGroup="RaceValidation" runat="server" />

        <%-- Adds the textbox for the user to enter the date of the race event --%>
        <div>
            <h4>
                <asp:Label ID="lblRaceDate" runat="server" Text="Race Date:"/>
            </h4>
            
            <asp:TextBox ID="txtRaceDate" runat="server" MaxLength="50" TextMode="Date" 
                         DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy"/>
        </div>
       
        <asp:RequiredFieldValidator ID="rfvRaceDate" ControlToValidate="txtRaceDate" ErrorMessage="Enter a race date" 
        ValidationGroup="RaceValidation" runat="server" />
    </fieldset>
</div>

<%-- Adds the linkButton for submitting the entry into the database --%>
<asp:LinkButton ID="btnSubmit" runat="server" Text="Submit"
    OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="btn btn-primary" ValidationGroup = "RaceValidation" />

<%-- Adds the linkButton for cancelling the submission --%>
<asp:LinkButton ID="btnCancel" runat="server" Text="Cancel"
    OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="btn btn-default" />

<%-- Adds the labels for the admin to see the races already in the database --%>
<asp:Repeater ID="rptItemList" OnItemDataBound="rptItemList_ItemDataBound" runat="server">
        

        <ItemTemplate>
            
            <div class="panel panel-info">
                <div class="panel-heading">
                     
                    <%-- Displays the name of the race on the page --%>
                    <h4>
                        <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
                    </h4>

                </div>

                <div class="panel-body">

                    <%-- Displays the exact date of the race --%>
                    <h4>
                        Race Date:
                        <asp:Label ID="lblRaceDate" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"raceDateString") %>' CssClass="tm_td" />
                    </h4>

                    <%-- Displays the exact date and time when the user entered information --%>
                    <h4>
                        Date:
                        <asp:Label ID="Label1" Text='<%#DataBinder.Eval(Container.DataItem,"CreatedDate") %>' runat="server"  CssClass="tm_td" />
                    </h4>
                    <asp:HyperLink ID="hlLotkToScore" runat="server" Text="Go to Scores"></asp:HyperLink>

                </div>

            </div>
               

                
            
        </ItemTemplate>
   
</asp:Repeater>