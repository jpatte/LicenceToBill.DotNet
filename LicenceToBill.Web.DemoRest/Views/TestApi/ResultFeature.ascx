<%@ Control Language="C#" Inherits="ViewUserControl<LicenceToBill.Api.FeatureV2>" %>

<div class="api-entity api-feature">

    <%  // get the feature
        var feature = this.Model;
        // if any
        if(feature != null)
        {
            string limitation = null;
            // if we have a date
            if((feature.DatePeriodStart.HasValue)
                || feature.Limitation.HasValue)
            {
                // then check the limitation
                if (feature.Limitation.HasValue)
                {
                    // if limitation is 0
                    if (feature.Limitation.Value == 0)
                        limitation = "*no access*";
                        // if limitation is 1
                    else if (feature.Limitation.Value == 1)
                        limitation = feature.Limitation.Value + " unit";
                        // if every other cases
                    else
                        limitation = feature.Limitation.Value + " units";
                }
                else
                    // insert after the name
                    limitation = "unlimited";
            }

            string dateStart = null;
            if(feature.DatePeriodStart.HasValue)
                dateStart = feature.DatePeriodStart.Value.ToShortDateString();

            string dateEnd = null;
            if(feature.DatePeriodEnd.HasValue)
                dateEnd = feature.DatePeriodEnd.Value.ToShortDateString();            
    %>
            <table class="result-list">
                <thead>
                    <tr>
                        <th>TitleLocalized</th>
                        <th>Limitation</th>
                        <th>From</th>
                        <th>Until</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><%= feature.TitleLocalized %></td>
                        <td><%= limitation %></td>
                        <td><%= dateStart %></td>
                        <td><%= dateEnd %></td>
                    </tr>
                </tbody>
            </table>
    <%  }
        else
        {
    %>
            <strong>no feature</strong>
    <%  }
    %>
</div>

