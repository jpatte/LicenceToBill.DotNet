<%@ Control Language="C#" Inherits="ViewUserControl<ModelTestApiResult>" %>

<div id="call_result" class="api-result">

    <%  // get the data
        var data = this.Model;
        // if any
        if(data != null)
        {
    %>
            <%  // if we have a time
                if(data.ElapsedMilliseconds.HasValue)
                {
            %>
                    HTTP status: <%= (int)data.StatusCode %> (<%= data.StatusCode %>) in <%= data.ElapsedMilliseconds%>ms
            <%  }
            %>

            <%  // if data is a single user
                if(data.User != null)
                {
            %>
                    <%= Html.Partial("ResultUser", data.User) %>
            <%  }
                // if data is a list of users 
                else if(data.Users != null)
                {
            %>
                    <%= Html.Partial("ResultUsers", data.Users) %>
            <%  }
                // if data is a single feature
                else if(data.Feature != null)
                {
            %>
                    <%= Html.Partial("ResultFeature", data.Feature) %>
            <%  }
                // if data is a list of features
                else if(data.Features != null)
                {
            %>
                    <%= Html.Partial("ResultFeatures", data.Features) %>
            <%  }
                // if data is a list of offers
                else if(data.Offers != null)
                {
            %>
                    <%= Html.Partial("ResultOffers", data.Offers) %>
            <%  }
                // if data is a list of deals
                else if(data.Deals != null)
                {
            %>
                    <%= Html.Partial("ResultDeals", data.Deals) %>
            <%  }
            %>

            <%  // if we have JSON code
                if(!string.IsNullOrEmpty(data.ResponseBody))
                {
            %>
                    <script type="text/javascript">

                        var container_code = $('#code_result_string');
                        container_code.empty();
                        container_code.append('<%= this.FormatCode(data.ResponseBody) %>');

                        $('#code_result').show();

                    </script>
            <%  }
                // if we have no response body
                else
                {
            %>
                    <script type="text/javascript">

                        $('#code_result_string').empty();
                        $('#code_result').hide();

                    </script>
            <%  }
            %>

            <%  // if we have a message
                if(!string.IsNullOrEmpty(data.Message))
                {
            %>
                    <div class="warning">
                        <%= data.Message %>
                    </div>
            <%  }
            %>
    <%  }
        else
        {
    %>
            <strong>no data</strong>
    <%  }
    %>
</div>

