<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Race.ascx.cs" Inherits="Purplecs.Modules.RaceScore.Race" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<h1>Race</h1>

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    
    <fieldset>

        <%-- Adds the gridview for the admin to see the races already in the database --%>

        <%-- Adds the textbox for the user to enter the race name into the database --%>
        <div class="dnnFormItem">
            Race Name:<asp:TextBox ID="txtRacename" runat="server"/>
        </div>

        <%-- Adds the textbox for the user to enter the date of the race event --%>
        <div>
            Date of Race:<asp:TextBox ID="txtRaceDate" runat="server" MaxLength="50" TextMode="Date" DateFormat="dd/MM/yyyy"
                                      DisplayDateFormat="dd/MM/yyyy"/>
        </div>
       
    </fieldset>
</div>

<%-- Adds the linkButton for submitting the entry into the database --%>
<asp:LinkButton ID="btnSubmit" runat="server" Text="Submit"
    OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" />

<%-- Adds the linkButton for cancelling the submission --%>
<asp:LinkButton ID="btnCancel" runat="server" Text="Cancel"
    OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" />

<%-- Adds the labels for the admin to see the races already in the database --%>
<asp:Repeater ID="rptItemList" OnItemDataBound="rptItemList_ItemDataBound" runat="server">
        <HeaderTemplate>
            <ul class="tm_tl">
        </HeaderTemplate>

        <ItemTemplate>
            <li class="tm_t">

                <%-- Displays the position of the race in repeater on the page --%>
                 <h4>
                    No:
                    <asp:Label ID="Label2" runat="server" Text='<%#Container.ItemIndex + 1 %>' />
                </h4>

                <%-- Displays the name of the race on the page --%>
                <h4>
                    Name:
                    <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
                </h4>

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
            </li>
        </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>