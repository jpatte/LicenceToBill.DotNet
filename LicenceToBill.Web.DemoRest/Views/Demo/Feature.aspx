<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Demo.Master" Inherits="ViewPage<DemoCheckLimitation>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="Zone1" runat="server">

    <div class="action">

        <%  // get working data
            var model = this.Model;
        %>

        <h2><%= model.NameFeature %></h2>
        <br />
        <br />

        <%  // if unlimited
            if(!model.Limitation.HasValue)
            {
        %>
                <p class="allowed-unlimited">Your access to this feature is <strong>unlimited</strong></p>                
        <%  }
            // if value > 0 : allowed, but limited
            else if(model.Limitation.Value > 0)
            {
                // get the current volume
                int volume = DataManager.GetVolumeFeature(CustomPrincipal.Current.KeyUser);
                // is still remaining
                if(model.Limitation.Value > volume)
                {
        %>
                    <p class="allowed-limited">Your access to this feature is limited to <%= model.Limitation.Value %> units</p>
                    <p>(currently used <%= volume %>)</p>
                    <br />
                    <div class="button-big">
                        <a href="<%= model.UrlChooseOffer %>">
                            Change offer
                        </a>
                    </div>
        <%      }
                else
                {
        %>
                    <p class="allowed-no">Action impossible : you reached your usage limitation of this feature</p>
                    <p>( <%= volume %> / <%= model.Limitation.Value %> units )</p>
        <%      }
            }
            // if value = 0 : NOT ALLOWED
            else if(model.Limitation.Value == 0)
            {
        %>
                <p class="allowed-no">You don't have access to this feature</p>
                <br />
                <div class="button-big">
                    <a href="<%= model.UrlChooseOffer %>">
                        Subscribe
                    </a>
                </div>
        <%  }
        %>

    </div>
</asp:Content>

