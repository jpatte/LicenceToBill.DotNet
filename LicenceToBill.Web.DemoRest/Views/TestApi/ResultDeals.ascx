<%@ Control Language="C#" Inherits="ViewUserControl<List<LicenceToBill.Api.DealV2>>" %>

<div class="api-list api-deals">
    <%  // get the deals
        var deals = this.Model;
        // if any
        if((deals != null)
            && (deals.Count > 0))
        {
    %>
            <table class="result-list">
                <thead>
                    <tr>
                        <th>KeyOffer</th>
                        <th>TitleLocalized</th>
                        <th>status</th>
                        <th>started on</th>
                        <th>renewal</th>
                        <th>ending</th>
                    </tr>
                </thead>
                <tbody>
                <%  // loop on the deals
                    foreach(var deal in deals)
                    {
                        string dateStart = null;
                        if(deal.DateStart.HasValue)
                            dateStart = deal.DateStart.Value.ToShortDateString();

                        string dateRenewal = null;
                        if(deal.DateRenewal.HasValue)
                            dateRenewal = deal.DateRenewal.Value.ToShortDateString();

                        string dateEnd = null;
                        if(deal.DateEnd.HasValue)
                            dateEnd = deal.DateEnd.Value.ToShortDateString();
%>
                        <tr>
                            <td><%= deal.KeyOffer %></td>
                            <td><%= deal.Title %></td>
                            <td><%= deal.Status %></td>
                            <td><%= dateStart %></td>
                            <td><%= dateRenewal %></td>
                            <td><%= dateEnd %></td>
                        </tr>
                <%  }
                %>
                </tbody>
            </table>
    <%  }
        else
        {
    %>
            <strong>no deal</strong>
    <%  }
    %>
</div>

