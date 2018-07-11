<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-advertise-on-landloards-profile.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_advertise_on_landloards_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Advertise on landlords </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  action="" method="">
         <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Advertise</a>
    
        <!--Modal-->
        <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
            <div class='modal-dialog'>
                        
                <div class='modal-content'>
                        <div class="modal-header"><strong>Advertise</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-4">
                                      
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" />
                            </div>
                        </div>
                    </div>
                </div>

        <a href='#' data-toggle='modal' data-target='#viewAdd' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Advertise</a>
        <div class='modal fade' id='viewAdd' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{2}' aria-hidden='true'>
                    
            <div class='modal-dialog'>
                        
                <div class='modal-content'>
                        <div class="modal-header"><strong>Your Ads</strong></div>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-8">
                                         <div class="form-group">
                                          <div class="col-sm-2"><strong> Date</strong></div>
                                          <div class="col-sm-2"><strong>Type</strong></div>
                                          <div class="col-sm-2"><strong>Gender</strong></div>
                                          <div class="col-sm-2"><strong>Payment</strong></div>
                                          <div class="col-sm-2"><strong>Rant</strong></div>
                                </div>
                                    </div>
                                                                        
                                    <div class="col-sm-8">
                                          <div class="col-sm-2">25-May-2017</div>
                                          <div class="col-sm-2">Sharing</div>
                                          <div class="col-sm-2">Male</div>
                                          <div class="col-sm-2">Cash</div>
                                          <div class="col-sm-4">R1250</div>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                     <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Add New</a>
                            </div>
                        </div>
                    </div>
                </div>
            
    </form>
</asp:Content>
