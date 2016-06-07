<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Racer.ascx.cs" Inherits="Purplecs.Modules.RaceScore.Racer" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>
<h1>Racer</h1>

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    
    <fieldset>

         <%-- Adds the textbox for the user to enter the racer name into the database --%>
        <div class="dnnFormItem">
            Racer's Name:<asp:TextBox ID="txtRacername" runat="server" />
        </div>
    </fieldset>
</div>

<%-- Adds the linkButton for submitting the entry into the database --%>
<asp:LinkButton ID="btnSubmit" runat="server" Text="Submit"
    OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" />

<%-- Adds the linkButton for cancelling the submission --%>
<asp:LinkButton ID="btnCancel" runat="server" Text="Cancel"
    OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" />

<%-- Adds the labels for the admin to see the racers already in the database --%>
<asp:Repeater ID="rptItemList" runat="server">
        <HeaderTemplate>
            <ul class="tm_tl">
        </HeaderTemplate>

        <ItemTemplate>
            <li class="tm_t">

                 <%-- Displays the position of the racer in repeater on the page --%>
                 <h4>
                    No:
                    <asp:Label ID="Label2" runat="server" Text='<%#Container.ItemIndex + 1 %>' />
                </h4>

                <%-- Displays the name of the racer on the page --%>
                <h4>
                    Name:
                    <asp:Label ID="lblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
                </h4>

                <%-- Displays the exact date and time from when the user entered the information --%>
                <h4>
                    Date Created:
                    <asp:Label ID="lblDateTime" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"CreatedDate").ToString() %>' CssClass="tm_td" />
                </h4>

            </li>
        </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
       