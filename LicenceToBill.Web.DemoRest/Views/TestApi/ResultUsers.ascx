<%@ Control Language="C#" Inherits="ViewUserControl<List<LicenceToBill.Api.UserV2>>" %>

<div class="api-list api-users">
    <%  // get the users
        var users = this.Model;
        // if any
        if((users != null)
            && (users.Count > 0))
        {
    %>
            <table class="result-list">
                <thead>
                    <tr>
                        <th>KeyUser</th>
                        <th>NameUser</th>
                        <th>Limitation</th>
                        <th>From</th>
                        <th>Until</th>
                    </tr>
                </thead>
                <tbody>
                <%  // loop on the users
                    foreach(var user in users)
                    {
                        string limitation = null;
                        // if we have a date
                        if((user.DatePeriodStart.HasValue)
                            || user.Limitation.HasValue)
                        {
                            // then check the limitation
                            if (user.Limitation.HasValue)
                            {
                                // if limitation is 0
                                if (user.Limitation.Value == 0)
                                    limitation = "*no access*";
                                    // if limitation is 1
                                else if (user.Limitation.Value == 1)
                                    limitation = user.Limitation.Value + " unit";
                                    // if every other cases
                                else
                                    limitation = user.Limitation.Value + " units";
                            }
                            else
                                // insert after the name
                                limitation = "unlimited";
                        }

                        string dateStart = null;
                        if(user.DatePeriodStart.HasValue)
                            dateStart = user.DatePeriodStart.Value.ToShortDateString();

                        string dateEnd = null;
                        if(user.DatePeriodEnd.HasValue)
                            dateEnd = user.DatePeriodEnd.Value.ToShortDateString();
%>
                        <tr>
                            <td><%= user.KeyUser %></td>
                            <td><%= user.NameUser %></td>
                            <td><%= limitation %></td>
                            <td><%= dateStart %></td>
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
            <strong>no user</strong>
    <%  }
    %>
</div>

