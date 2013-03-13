<%@ Page Language="C#" MasterPageFile="~/Views/Shared/TestApi.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ContentPlaceHolderID="Css" runat="server">

</asp:Content>

<asp:Content ContentPlaceHolderID="Zone1" runat="server">

    <div class="demo">

        <%= Html.Partial("Ressources") %>
    </div>

</asp:Content>

<asp:Content ContentPlaceHolderID="Zone2" runat="server">

    <div class="demo">
        <h2>Impersonate another user</h2>
        <i>(current user : '<%= CustomPrincipal.Current.NameUser %>')</i>


        <ul>
            <li>
                <a href="/Home/Impersonate?login=alfred@monreseaupro.com" class="button">Alfred</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=beatrice@monreseaupro.com" class="button">Beatrice</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=charles@monreseaupro.com" class="button">Charles</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=dorothy@monreseaupro.com" class="button">Dorothy</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=eric@monreseaupro.com" class="button">Eric</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=florient@monreseaupro.com" class="button">Florient</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=gaius@monreseaupro.com" class="button">Gaius</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=henry@monreseaupro.com" class="button">Henry</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=igor@monreseaupro.com" class="button">Igor</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=jean@monreseaupro.com" class="button">Jean</a>
            </li>
            <li>
                <a href="/Home/Impersonate?login=karl@monreseaupro.com" class="button">Karl</a>
            </li>
        </ul>
    </div>

</asp:Content>
