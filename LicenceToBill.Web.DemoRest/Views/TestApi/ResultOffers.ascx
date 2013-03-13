<%@ Control Language="C#" Inherits="ViewUserControl<List<LicenceToBill.Api.OfferV2>>" %>

<div class="api-list api-offers">
    <%  // get the offers
        var offers = this.Model;
        // if any
        if((offers != null)
            && (offers.Count > 0))
        {
    %>
            <table class="result-list">
                <thead>
                    <tr>
                        <th>TitleLocalized</th>
                    </tr>
                </thead>
                <tbody>
                <%  // loop on the offers
                    foreach(var offer in offers)
                    {
%>
                        <tr>
                            <td><%= offer.TitleLocalized %></td>
                        </tr>
                <%  }
                %>
                </tbody>
            </table>
    <%  }
        else
        {
    %>
            <strong>no offer</strong>
    <%  }
    %>
</div>

