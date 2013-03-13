<%@ Control Language="C#" Inherits="ViewUserControl<LicenceToBill.Api.UserV2>" %>

<div class="api-entity api-user">

    <%  // get the user
        var user = this.Model;
        // if any
        if(user != null)
        {
    %>
            <table class="result-list">
                <thead>
                    <tr>
                        <th>KeyUser</th>
                        <th>NameUser</th>
                    </tr>
                </thead>
                <tbody>
                        <tr>
                            <td><%= user.KeyUser %></td>
                            <td><%= user.NameUser %></td>
                        </tr>
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

