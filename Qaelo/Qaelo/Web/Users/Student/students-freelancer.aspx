<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-freelancer.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_freelancer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Freelancer</title>
    <link href="../../../Content/CustomCss/Profile/assets/css/gsdk-base.css" rel="stylesheet" />
    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.css" rel="stylesheet"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Notifier-->         
        <asp:Label ID="lblErrorMessage" style="opacity:-20" runat="server" Text=""></asp:Label>
                 <script type="text/javascript">
                    (function ($)
                    {
                        var error = $('#<%=lblErrorMessage.ClientID%>').text();

                        if (error.length > 5) {
                            $.notify(error, {
                                type: "danger", animate: {
                                    enter: 'animated bounceIn',
                                    exit: 'animated bounceOut'
                                }
                            });
                    }
                    })(jQuery);
                     </script>
        <!--/Notifier-->

    <a href="#myModal" data-toggle="modal" >Open popup</a>


    <div class="modal  fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModal">
                        <div class="modal-dialog modal-lg" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <!--<h4>Notice </h4>-->
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                </div>
                                <section>
                                    <div class="modal-body">
                                        <!--   Big container   -->
                                    <div class="container">
                                        <div class="row">
                                        <div class="col-sm-8">
                                            <!--      Wizard container        -->   
                                                <div class="card wizard-card ct-wizard-orange" id="wizardProfile">
                                                    <form  action="" method="">
                                                <!--        You can switch "ct-wizard-orange"  with one of the next bright colors: "ct-wizard-blue", "ct-wizard-green", "ct-wizard-orange", "ct-wizard-red"             -->
                
                    	                                <div class="wizard-header">
                        	                                <h3>
                        	                                   <b>Become</b>a freelancer<br/>
                        	                                </h3>
                    	                                </div>
                    	                                <ul>
                                                            <li><a href="#about" data-toggle="tab">Basic </a></li>
                                                            <li><a href="#account" data-toggle="tab">Description</a></li>
                                                            <li><a href="#more" data-toggle="tab">More</a></li>
                                                        </ul>
                        
                                                        <div class="tab-content">
                                                            <div class="tab-pane" id="about">
                                                              <div class="row">
                                                                  <h4 class="info-text"> Basic information</h4>
                                                                  <div class="col-sm-6 col-sm-offset-3">
                                                                      <div class="form-group">
                                                                          <div class="col-sm-12">
                                                                                 <div class="form-group">
                                                                        <label>Your Specialty</label>
                                                                          <asp:DropDownList ID="ddlWork1" Width="100%" CssClass="form-control" runat="server" >
                                                                              <asp:ListItem disabled="" selected="" Value="NONE">- Select type -</asp:ListItem>
                                              
                                              
                                                                              <asp:ListItem Value="Accountant">Accountant</asp:ListItem>
                                                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                                                              <asp:ListItem Value="Actor">Actor</asp:ListItem>
                                                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                                                              <asp:ListItem Value="Babysitter">Babysitter</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                                                              <asp:ListItem Value="Dancer">Dancer</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                                                              <asp:ListItem Value="Event MC">Event MC</asp:ListItem>
                                                                              <asp:ListItem Value="Event usher">Event usher</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Film & TV specialist">Film & TV specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Hairdresser">Hairdresser</asp:ListItem>
                                                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Historian">Historian</asp:ListItem>
                                                                              <asp:ListItem Value="House keeper">House keeper</asp:ListItem>
                                                                               <asp:ListItem Value="Investor">Investor</asp:ListItem>
                              
                                                                              <asp:ListItem Value="Legal specialist">Legal specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                                                                             <asp:ListItem Value="Receptionist">Receptionist</asp:ListItem>
                                                                              <asp:ListItem Value="Sales agent">Sales agent</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Singer">Singer</asp:ListItem>
                                                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                                                            <asp:ListItem Value="Teacher assistant">Teacher assistant</asp:ListItem>
                                            
                                                                                <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                                                                <asp:ListItem Value="Waiter">Waiter</asp:ListItem>
                                                                              <asp:ListItem Value="Waitress">Waitress</asp:ListItem>

                                                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>
                                                                          </asp:DropDownList>
                                                                           <br />  
                                                                        <label>Second Specialty(optional)</label>

                                                                          <asp:DropDownList ID="ddlWork2" Width="100%" CssClass="form-control" runat="server" >
                                                                           <asp:ListItem disabled="" selected="" Value="NONE">- Select type -</asp:ListItem>
                                              
                                              
                                                                              <asp:ListItem Value="Accountant">Accountant</asp:ListItem>
                                                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                                                              <asp:ListItem Value="Actor">Actor</asp:ListItem>
                                                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                                                              <asp:ListItem Value="Babysitter">Babysitter</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                                                              <asp:ListItem Value="Dancer">Dancer</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                                                              <asp:ListItem Value="Event MC">Event MC</asp:ListItem>
                                                                              <asp:ListItem Value="Event usher">Event usher</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Film & TV specialist">Film & TV specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Hairdresser">Hairdresser</asp:ListItem>
                                                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Historian">Historian</asp:ListItem>
                                                                              <asp:ListItem Value="House keeper">House keeper</asp:ListItem>
                                                                               <asp:ListItem Value="Investor">Investor</asp:ListItem>
                              
                                                                              <asp:ListItem Value="Legal specialist">Legal specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                                                                             <asp:ListItem Value="Receptionist">Receptionist</asp:ListItem>
                                                                              <asp:ListItem Value="Sales agent">Sales agent</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Singer">Singer</asp:ListItem>
                                                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                                                            <asp:ListItem Value="Teacher assistant">Teacher assistant</asp:ListItem>
                                            
                                                                                <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                                                                <asp:ListItem Value="Waiter">Waiter</asp:ListItem>
                                                                              <asp:ListItem Value="Waitress">Waitress</asp:ListItem>

                                                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>

                                                                          </asp:DropDownList>
                                                                           <br />    
                                                                        <label>Third Specialty(optional)</label>                                                           
                                                                          <asp:DropDownList ID="ddlWork3" Width="100%" CssClass="form-control" runat="server" >
                                                                             <asp:ListItem disabled="" selected="" Value="NONE">- Select type -</asp:ListItem>
                                              
                                              
                                                                              <asp:ListItem Value="Accountant">Accountant</asp:ListItem>
                                                                              <asp:ListItem Value="Acting Extra">Acting Extra</asp:ListItem>
                                                                              <asp:ListItem Value="Actor">Actor</asp:ListItem>
                                                                              <asp:ListItem Value="Admin Assitant">Admin Assitant</asp:ListItem>
                                                                              <asp:ListItem Value="Animator">Animator</asp:ListItem>
                                                                              <asp:ListItem Value="Babysitter">Babysitter</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Bookkeeper">Bookkeeper</asp:ListItem>
                                                                              <asp:ListItem Value="Business Incubator">Business Incubator</asp:ListItem>
                                                                              <asp:ListItem Value="Call Centre Agent">Call Centre Agent</asp:ListItem>
                                                                              <asp:ListItem Value="Chauffer">Chauffer</asp:ListItem>
                                                                              <asp:ListItem Value="Chef">Chef</asp:ListItem>
                                                                              <asp:ListItem Value="Choreographer">Choreographer</asp:ListItem>
                                                                              <asp:ListItem Value="Comedian">Comedian</asp:ListItem>
                                                                              <asp:ListItem Value="Dancer">Dancer</asp:ListItem>
                                              
                                                                              <asp:ListItem Value="Data Analyst">Data Analyst</asp:ListItem>
                                                                              <asp:ListItem Value="Developer">Developer</asp:ListItem>
                                                                              <asp:ListItem Value="Dog Walker">Dog Walker</asp:ListItem>
                                                                              <asp:ListItem Value="Editor/Proof Reader">Editor/Proof Reader</asp:ListItem>
                                                                              <asp:ListItem Value="Event Dj">Event Dj</asp:ListItem>
                                                                              <asp:ListItem Value="Event host">Event host</asp:ListItem>
                                                                              <asp:ListItem Value="Event MC">Event MC</asp:ListItem>
                                                                              <asp:ListItem Value="Event usher">Event usher</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Fashion Designer">Fashion Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Film & TV specialist">Film & TV specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Forex Trader">Forex Trader</asp:ListItem>
                                                                              <asp:ListItem Value="Google adwords expert">Google adwords expert</asp:ListItem>
                                                                              <asp:ListItem Value="Google analytics consultant">Google analytics consultant</asp:ListItem>
                                                                              <asp:ListItem Value="Graphic Designer">Graphic Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Hairdresser">Hairdresser</asp:ListItem>
                                                                              <asp:ListItem Value="High School sports coach">High School sports coach</asp:ListItem>
                                                                              <asp:ListItem Value="High School tutor">High School tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Historian">Historian</asp:ListItem>
                                                                              <asp:ListItem Value="House keeper">House keeper</asp:ListItem>
                                                                               <asp:ListItem Value="Investor">Investor</asp:ListItem>
                              
                                                                              <asp:ListItem Value="Legal specialist">Legal specialist</asp:ListItem>
                                                                              <asp:ListItem Value="Logistics Assistant">Logistics Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Makeup artist">Makeup artist</asp:ListItem>
                                                                              <asp:ListItem Value="Market researcher">Market researcher</asp:ListItem>
                                                                              <asp:ListItem Value="Marketing Assistant">Marketing Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Medical Assistant">Medical Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Model">Model</asp:ListItem>
                                                                              <asp:ListItem Value="Motivational Speaker">Motivational Speaker</asp:ListItem>
                                                                              <asp:ListItem Value="Night child care nanny">Night child care nanny</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Assistant">Personal Assistant</asp:ListItem>
                                                                              <asp:ListItem Value="Personal Fitness trainer">Personal Fitness trainer</asp:ListItem>
                                                                              <asp:ListItem Value="Photographer">Photographer</asp:ListItem>
                                                                              <asp:ListItem Value="Pre-school tutor">Pre-school tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Product Promoter">Product Promoter</asp:ListItem>
                                                                                             <asp:ListItem Value="Receptionist">Receptionist</asp:ListItem>
                                                                              <asp:ListItem Value="Sales agent">Sales agent</asp:ListItem>
                                              
                                                                               <asp:ListItem Value="Singer">Singer</asp:ListItem>
                                                                              <asp:ListItem Value="Sketch and portrait artist">Sketch and portrait artist</asp:ListItem>
                                                                              <asp:ListItem Value="Social network marketer">Social network marketer</asp:ListItem>
                                                                              <asp:ListItem Value="Tax Administrator">Tax Administrator</asp:ListItem>
                                                                            <asp:ListItem Value="Teacher assistant">Teacher assistant</asp:ListItem>
                                            
                                                                                <asp:ListItem Value="Translator">Translator</asp:ListItem>
                                                                              <asp:ListItem Value="University Tutor">University Tutor</asp:ListItem>
                                                                              <asp:ListItem Value="Voice over">Voice over</asp:ListItem>
                                                                              <asp:ListItem Value="Volunteer">Volunteer</asp:ListItem>
                                                                                <asp:ListItem Value="Waiter">Waiter</asp:ListItem>
                                                                              <asp:ListItem Value="Waitress">Waitress</asp:ListItem>

                                                                              <asp:ListItem Value="Web Designer">Web Designer</asp:ListItem>
                                                                              <asp:ListItem Value="Writer">Writer</asp:ListItem>
                                                                          </asp:DropDownList>
                                                                     </div>
                                                                          </div>
                                                                         </div>
                                                                  </div>
                                                              </div>
                                                            </div>

                                                            <div class="tab-pane" id="account">
                                                                       <div class="row">
                                                                    <div class="col-sm-12">
                                                                        <h4 class="info-text"> Description of your specialty</h4>
                                                                    </div>
                                                                    <div class="col-sm-6">
                                                                         <div class="form-group">
                                                                           <label>Freelancing description</label>
                                                                             <asp:TextBox ID="txtDescription" class="form-control" placeholder="" TextMode="multiline"  Rows="6"  runat="server">
                                                                             </asp:TextBox>
                                                                          </div>
                                                                    </div>

                                                                    <div class="col-sm-6">
                                                                        <div class="col-sm-6">
                                                                            <div class="form-group">
                                                                                <label>Price</label>
                                                                                <asp:TextBox ID="txtPrice" type="Number" Width="100%" CssClass="form-control" runat="server"></asp:TextBox>
                                                                            </div>
                                                                        </div>
                                                                        <div class="col-sm-6">
                                                                            <div class="form-group">
                                                                                <label>Terms</label>
                                                                            <asp:DropDownList ID="ddlPriceTerms" runat="server" Width="100%" CssClass="form-control">
                                                                                <asp:ListItem Value="Once-off">Once-off</asp:ListItem>
                                                                                <asp:ListItem Value="Per/Hour">Per/Hour</asp:ListItem>
                                                                                <asp:ListItem Value="Negotiable">Negotiable</asp:ListItem>
                                                                            </asp:DropDownList>
                                                                                </div>
                                                                        </div>
                                                                    </div>
                                                                    </div>
                                                            </div>

                                                            <div class="tab-pane" id="more">
                                                              <div class="row">
                                                                    <div class="col-sm-12">
                                                                        <h4 class="info-text"> Pictures of your work(Optional)</h4>
                                                                    </div>
                                                                 </div>
                                                            <div class="row">
                                                              <div class="col-sm-4">
                                                                  <br />
                                                                  <h6 class="text-center">Picture 1</h6>
                                                                   <hr style="color:green"/>
                                                                   <img src="" class="img-thumbnail" style="height:230px;width:100%" id="image1"/>
                                                                   <asp:FileUpload ID="file1" CssClass="btn-blue-grey btn-sm" runat="server" />
                                                               </div>
                                                   
                                                              <div class="col-sm-4">
                                                                 <br />
                                                                  <h6 class="text-center">Picture 2</h6>
                                                                   <hr class="primary-color" />
                                                                   <img src="" class="img-thumbnail" style="height:230px;width:100%" id="image2"/>
                                                                   <asp:FileUpload ID="file2" CssClass="btn-blue-grey btn-sm" runat="server" />
                           
                                                               </div> 
                                                 
                                                              <div class="col-sm-4">
                                                              <br />
                                                              <h6 class="text-center">Picture 3</h6>
                                                               <hr class="primary-color"/>
                                                               <img src="" class="img-thumbnail" style="height:230px;width:100%" id="image3"/>
                                                               <asp:FileUpload ID="file3" CssClass="btn-blue-grey btn-sm" runat="server" />
                                                           </div> 


                                                                                 <!--Modal-->
                                                             <div class='modal fade' id='share' tabindex='-1' role='dialog' aria-labelledby='myModalLabel{1}' aria-hidden='true'>
                                                    <div class='modal-dialog'>
                                                        <div class='modal-content'>
                                                        <div class="modal-header">Tell friend</div>
                                                            <div class='modal-body'>
                                                                <p>Please Tell a friend that you are about to be live on Qaelo, Who knows? They may just hire or tell other friends about you</p>
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtshare1" CssClass="form-control" placeholder="Email 1" runat="server"></asp:TextBox>
                                                                </div>
                                                            </div>
                
                                                            <div class='modal-footer'>
                                                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                                                                <asp:Button ID="btnFinish" class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish' runat="server" Text="Publish" OnClick="btnFinish_Click"  />
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                       </div>
                               
                                                        </div>
                                                            </div>
                                                        <div class="wizard-footer">
                                                            <div class="pull-right">
                                                                <input type='button' class='btn btn-next btn-fill btn-warning btn-wd btn-sm' name='next' value='Next' />
                                                                <a href='#' data-toggle='modal' data-target='#share' type='button' class='btn btn-finish btn-fill btn-warning btn-wd btn-sm' name='finish' value='Finish'>Finish</a>

                                                            </div>
                                                            <div class="pull-left">
                                                                <input type='button' class='btn btn-previous btn-fill btn-default btn-wd btn-sm' name='previous' value='Previous' />
                                                            </div>
                                                            <div class="clearfix"></div>
                                                        </div>	
                                                    </form>
                                                </div>
                                        </div>
                                        </div><!-- end row -->
        
                                    </div>
                                     <!--  big container -->
    
                                        <!-- Live Image Loader--> 

                                    </div>
                                </section>
                            </div>
                        </div>
                    </div>
    
     <script>
                document.getElementById("file1").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail. 
                        document.getElementById("image1").src = e.target.result;
                        document.getElementById("imageDefault").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 2
                document.getElementById("file2").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image2").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };

                //Image 3
                document.getElementById("file3").onchange = function () {
                    var reader = new FileReader();
                    reader.onload = function (e) {
                        // get loaded data and render thumbnail.
                        document.getElementById("image3").src = e.target.result;
                    };
                    // read the image file as a data URL.
                    reader.readAsDataURL(this.files[0]);
                };
                </script>
    <!-- Wizard-->
    	<!--   plugins 	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.bootstrap.wizard.js"></script>
	
    <!--  More information about jquery.validate here: http://jqueryvalidation.org/	 -->
<script src="../../../Content/CustomCss/Profile/assets/js/jquery.validate.min.js"></script>
	
    <!--  methods for manipulating the wizard and the validation -->
<script src="../../../Content/CustomCss/Profile/assets/js/wizard.js"></script>
</asp:Content>
