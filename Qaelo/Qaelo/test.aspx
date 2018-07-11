<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Qaelo.test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
        

    <!--Rating -->
        <script src="Scripts/jquery-1.9.1.min.js"></script>
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="Content/fontawesome-stars.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css">
</head>
    
 <body>
        <form runat="server">

                                        <div class="col-sm-12">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                    <br />
                                    
                                            
                     <strong>Room Rating</strong><asp:DropDownList ID="example1" AutoPostBack="true" runat="server">
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        
                                </div>

            <embed src="Images/Accommodation/1E-UJ%20ACADEMIC%20CALENDAR%202017.pdf" width="800px" height="2100px" />
            
    
            <img src="https://graph.facebook.com/{id}/picture?type=large&w%E2%80%8C%E2%80%8Bidth=720&height=720" height="150px" width="150px"  alt="profile pic"/>
    
                </form>
    </body>



                <!-- Rating --->    
<script type="text/javascript" src="Scripts/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="Scripts/jquery.barrating.min.js"></script>
    <script type="text/javascript">

        //Do for 3 posts
       $(function() {
          $('#example1').barrating({
            theme: 'fontawesome-stars'
          });
          $('#example2').barrating({
              theme: 'fontawesome-stars'
          });
       });
    </script>
    <!-- End of Rating -->
</html>