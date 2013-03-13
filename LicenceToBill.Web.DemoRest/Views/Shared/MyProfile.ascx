<%@ Control Language="C#" Inherits="ViewUserControl<LicenceToBill.Web.DemoRest.ModelMyProfile>" %>


<%  // get the principal
    var principal = CustomPrincipal.Current;
    // if authenticated
    if(principal.IsAuthenticated)
    {
        // get the model
        var model = this.Model;
%>
        <ul>
            <li>
                <a href="<%= model.UrlDeals %>" class="button">My deals</a>
            </li>
            <li>
                <a href="<%= model.UrlInvoices %>" class="button">My invoices</a>
            </li>
            <li>
                <a href="<%= model.UrlChooseOffer %>" class="button">Change offer</a>
            </li>
        </ul>
<%  }
%>
