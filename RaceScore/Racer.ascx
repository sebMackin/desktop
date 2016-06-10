<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Racer.ascx.cs" Inherits="Purplecs.Modules.RaceScore.Racer" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<h1>Racers</h1>

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    
    <fieldset>

         <%-- Adds the textbox for the user to enter the racer name into the database --%>
        <div>
            <h4>
                <asp:Label ID="lblRacerName" runat="server" Text="Racer Name:"/>
            </h4>
            <asp:TextBox ID="txtRacername" runat="server"/>

            <asp:RequiredFieldValidator ID="rfvRace" ControlToValidate="txtRacerName" ErrorMessage="Enter a racer name" 
            ValidationGroup="RacerValidation" runat="server" />

        </div>
    </fieldset>
</div>

<%-- Adds the linkButton for submitting the entry into the database --%>
<asp:LinkButton ID="btnSubmit" runat="server" Text="Submit"
OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="btn btn-primary" ValidationGroup="RacerValidation"/>

<%-- Adds the linkButton for cancelling the submission --%>
<asp:LinkButton ID="btnCancel" runat="server" Text="Cancel"
    OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="btn btn-default" />

<%-- Adds the labels for the admin to see the racers already in the database --%>
<asp:Repeater ID="rptItemList" runat="server">
        
        <ItemTemplate>          

            <div class="panel panel-info">

                <div class="panel-heading">

                    <%-- Displays the name of the racer on the page --%>
                    <h4>
                        
                        <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
                    </h4>

                </div>

                <div class="panel-body">

                    <%-- Displays the exact date and time from when the user entered the information --%>
                    <h4>
                        Date Created:
                        <asp:Label ID="lblDateTime" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"CreatedDate").ToString() %>' CssClass="tm_td" />
                    </h4>

                </div>
            </div>

         

               
           
        </ItemTemplate>
    
</asp:Repeater>
       