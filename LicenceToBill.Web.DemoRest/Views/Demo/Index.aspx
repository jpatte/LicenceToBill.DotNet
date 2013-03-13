<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Demo.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="Zone1" runat="server">

    <div class="login">

        <h2>Welcome <span style="color:#337733;"><%= CustomPrincipal.Current.NameUser %></span></h2>

        <br />
        <p>This is a fake site whose sole purpose is to demonstrate the capacities of <a href="<%= Constants.UrlLicenceToBill %>"><strong>LicenceToBill</strong></a>
        <br />
        <br />
        <p>Free features are of no interest here, because <a href="<%= Constants.UrlLicenceToBill %>">LicenceToBill</a> embeds an access control system you can use to restrain your paying features to your paying customers.</p>

    </div>

</asp:Content>

