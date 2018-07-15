<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-freelancers.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_freelancers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Freelancers</title>
<%--    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>

    <style>
        .popover1{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
                
        .popover2{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
                        
        .popover3{
    max-width: 100%; /* Max Width of the popover (depending on the container!) */
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
        <div class="container">
	   
    <div class='col-md-12'>
	        <div class="col-md-12">
                  <h3 class="text-center">Find a freelancer!</h3>
            </div>

  <div class="row">
      <br /><br />
          <div class="col-sm-4">
              <div class="form-group">
                  <asp:TextBox ID="txtFreelancers"  placeholder="What freelancer are you looking for?" runat="server" type="text" class="typeaheadFreelancers tt-query freelanceClass form-control " autocomplete="on" spellcheck="false"></asp:TextBox>                              
                                                   </div>
          </div>
                         
       <div class="col-sm-8"> 

                         <asp:TextBox ID="txtText" placeholder="Type Location" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div> 
       
     </div>
        
                 <div class="row"> 
             <div class="col-md-12">
             <hr/>
             </div>
         </div>
	         
            <div class="col-md-12">

            <asp:Literal ID="lblProfileView" runat="server"></asp:Literal>        
            </div>
    </div>
        
    </div>

    <!-- All Freelancers -->

    <!--Single view of freelancer's work-->
    <div class='col-md-12'>
        <asp:Literal ID="lblSingleProfile" runat="server"></asp:Literal>   
    </div>
   
        <%--single image(my work)--%>

<%--        <div class='col-md-12'>
        <asp:Literal ID="lblWorkImages" runat="server"></asp:Literal>   
    </div>--%>


    <%--<div class='modal-dialog modal-lg'>
                            <div class='modal-content'>
                                        <div class='modal-body'>
                                            <div class='container'>
                                                <div class='col-sm-9'>
                                                    <div class='col-sm-5'>
                                                        <h2>Education</h2>
                                                        <hr />            
                                                        <strong>University:</strong><p>{0}</p>
                                                        <strong>Course Enrolled:</strong><p>{1}</p>
                                                        <strong>Freelance:</strong><p>{2}</p>
                                                        <strong>Freelancing Description:</strong><p>{3}</p>
                                                        <strong>Price:</strong><p>{4}</p>
                                                    </div>
                                                    <div class='col-sm-5'>
                                                        <h2>Contact Info</h2>
                                                         <hr />   
                                                        <strong>Full Name :</strong><p>{5}</p>
                                                        <strong>Email:</strong><p>{6}</p>
                                                        <strong>Phone No:</strong><p>{7}</p>
                                                    </div>
                                                 </div>

                                               
                                                 </div>
                                        <div class='modal-footer'>
                                            <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                        </div>
                                        </div>
                                    </div>
                                </div>--%>
    


<script>
    //we have 3 images for each user so lets loop 3 times
    var image = '<img src="../../../Images/Freelancer/1email%20setup.JPG"">';

    $('#popover1').popover({ placement: 'bottom',trigger : 'hover', content: image, html: true });
    $('#popover2').popover({ placement: 'bottom', trigger: 'hover', content: image, html: true });
    $('#popover3').popover({ placement: 'bottom', trigger: 'hover', content: image, html: true });

</script>

</asp:Content>
