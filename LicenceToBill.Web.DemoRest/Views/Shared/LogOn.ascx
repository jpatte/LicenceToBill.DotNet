<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>


<%  // get the principal
    var principal = CustomPrincipal.Current;
    // if not authenticated
    if(!principal.IsAuthenticated)
    {
%>
        <form action="/Home/Login" method="post">

            <div id="login">
                <ul>
                    <li><input type="text" name="login"/></li>
                    <li><input type="password" name="password"/></li>
                </ul>
                <input type="submit" style="visibility:hidden;"/>

                <script type="text/javascript">
                    // hack for IE
                    $(function () {
                        $('input#password').keydown(function (e) {
                            if (e.keyCode == 13) {
                                $(this).parents('form').submit();
                                return false;
                            }
                        });
                    });
                </script>
            </div>
        </form>
<%  }
    // if authenticated
    else
    {
%>
        <div id="logon">
            <ul>
                <li>
                    <a href="/TestApi"><%= principal.NameUser %></a>
                </li>
                <li>
                    <a href="/Home/SignOut" class="button-mini" style="width:120px;text-align:center;">Disconnect</a>
                </li>
            </ul>
            <div class="spacer"></div>
            <div id="profile">
                <a id="btn_open_profile" href="#" class="button-mini" style="width:120px;text-align:center;">
                    My profile
                </a>
                <div id="profile_popup" style="display:none;">
                    <div id="profile_popup_in">

                        <a href="/TestApi"><%= principal.NameUser %></a>

                        <div id="profile_popup_content">
                        </div>

                    </div>
                </div>
            </div>
            <script type="text/javascript">
                $(function () {
                    $('#btn_open_profile').click(function () {
                        var popup = $('#profile_popup');
                        if(popup.is(':visible'))
                        {
                            popup.slideUp('fast');
                        }
                        else
                        {
                            var content = $('#profile_popup_content');
                            if (content.length > 0)
                            {
                                $.ajax
                                ({ url: '/Home/MyProfileAjax',
                                    success: function (data) {
                                        content.replaceWith(data);
                                    }
                                });
                            }
                            popup.slideDown('fast');
                        }
                    });
                });
            </script>
        </div>

<% }
%>
