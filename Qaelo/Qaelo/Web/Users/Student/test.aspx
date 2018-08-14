<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Qaelo.Web.Users.Student.test" %>

<!DOCTYPE html>
<!DOCTYPE html>
<html>
  <head>
    <title>Place Autocomplete</title>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
        <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
  </head>
  <body>

      <form runat="server">

    <%--<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBaYiQPQ1vAMeFLPA4ilHRPfcFG6zfE7uY&libraries=places&callback=initMap" async defer></script>--%>
      <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?key=AIzaSyDhovLlaG3eVxPiJDVmp6CKDUHXgk2PxS4&libraries=places"></script>

<%--   <script type="text/javascript">
       google.maps.event.addDomListener(window, 'load', function () {
           var places = new google.maps.places.Autocomplete(document.getElementById('txtPlaces'));
           google.maps.event.addListener(places, 'place_changed', function () {
               var place = places.getPlace();
               var address = place.formatted_address;
               var latitude = place.geometry.location.A;
               var longitude = place.geometry.location.F;
               var mesg = "Address: " + address;
               mesg += "\nLatitude: " + latitude;
               mesg += "\nLongitude: " + longitude;
               alert(mesg);
           });
       });
    </script>
    <span>Location:</span>--%>
    <%--<input type="text" id="txtPlaces" style="width: 250px" placeholder="Enter a location" />--%>

      <asp:TextBox ID="txtPlaces" runat="server" style="width: 350px" placeholder="Enter a location"></asp:TextBox>

      <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click" />


      </form>
  </body>
</html>