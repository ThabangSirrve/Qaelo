<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Qaelo._default" %>

<!--
author: W3layouts
author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <title>Qaelo</title>
    <!-- for-mobile-apps -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Qaelo,Freelance, sell used textbooks, list student accommodation, list events, list student societies,list shops">
    <script type="application/x-javascript">
        addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <link href="Template/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="Template/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="Template/css/popuo-box.css" rel="stylesheet" />
    <!-- js -->
    <script type="text/javascript" src="Template/js/jquery-2.1.4.min.js"></script>
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" integrity="sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN" crossorigin="anonymous">
    <!-- //js -->
    <link href='//fonts.googleapis.com/css?family=Cabin:400,400italic,500,500italic,600,600italic,700,700italic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,700italic,800,800italic' rel='stylesheet' type='text/css'>
    <!-- start-smoth-scrolling -->
    <script type="text/javascript" src="Template/js/move-top.js"></script>
    <script type="text/javascript" src="Template/js/easing.js"></script>
    <script type="text/javascript">
	jQuery(document).ready(function($) {
		$(".scroll").click(function(event){
			event.preventDefault();
			$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
		});
	});
    </script>
    <!-- start-smooth-scrolling -->

    <link rel="shortcut icon" type="image/x-icon" href="favicon.ico">
</head>

<body>

    <%--SSL
    <script type="text/javascript">
        var loc = window.location.href + '';
        if (loc.indexOf('http://') == 0) {
            window.location.href = loc.replace('http://', 'https://');
        }
    </script>--%>
    

    <script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-96845801-1', 'auto');
  ga('send', 'pageview');

    </script>
    <!-- banner -->
    <div class="banner" runat="server" id="homePage">
        <div class="container">
            <nav class="navbar navbar-default">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <div class="logo">
                        <h1><a class="navbar-brand"  href="default.aspx">Qaelo</a></h1>
                        <%--<a class="navbar-brand" style="margin-top:-20px"  href="default.aspx"> <img src="logo.png"  /></a>--%>
                    </div>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse nav-wil" id="bs-example-navbar-collapse-1">
                    <nav class="link-effect-2" id="link-effect-2">
                        <ul class="nav navbar-nav">
                            <li><a href="Web/Users/Student/students-freelancers.aspx"><span data-hover="FIND A FREELANCER">FIND A FREELANCER</span></a></li>
                            <li><a href="Web/Users/Student/students-shops.aspx"><span data-hover="Find a facility">Find a facility</span></a></li>
<%--                        <li><a href="Web/Users/Student/student-accommodation.aspx" ><span data-hover="ROOMS">ROOMS</span></a></li>
                            <li><a href="Web/Users/Student/students-events.aspx" ><span data-hover="Events & AUditions">Events & AUditions</span></a></li>
                            <li><a href="Web/Users/Student/students-buy-textbooks.aspx"><span data-hover="BUY BOOKS">BUY BOOKS</span></a></li>
                            <li><a href="#portfolio" class="scroll"><span data-hover="My lifestyle">My lifestyle</span></a></li>--%>
                            <%--<li><a href="#faq" data-toggle="modal"><span data-hover="FAQ">FAQ</span></a></li>--%>
                        </ul>
                    </nav>
                </div>
                <!-- /.navbar-collapse -->
            </nav>
            <div class="banner-info">
                <!--style="color:#FFB445"-->
                <h2 >YOUR LOCAL COMMUNITY DIRECTORY!</h2>
                <div class="form-group">
                    <br />
             <div class="more">
            <a href="Web/Account/tempLogin.aspx" class="hvr-shutter-in-vertical" style="margin-bottom:10px">Sign In</a>
            <a href="Web/Account/Registration.aspx" class="hvr-shutter-in-vertical" style="margin-bottom:10px">Create Profile</a>
            <%--<a href="#" onclick="loginByFacebook();" class="hvr-shutter-in-vertical" style="margin-bottom:10px"><i class="fa fa-facebook" aria-hidden="true"></i> Login With Facebook </a>--%>
            <div id="fb-root"></div>
              </div>
                </div>
                    <!--modal-video-->
                    <div class="modal video-modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModal">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <!--<h4>Notice </h4>-->
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                </div>
                                <section>
                                    <div class="modal-body">
                                        <p>
                                            Functionality comming soon.
                                        </p>
                                    </div>
                                </section>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
    <!-- //banner -->

    <!--Profile -->

    <!--/Profile-->

    <!-- Login with facebook-->
    <!--now this is some required facebook's JS, two things to pay attention to
    1. setting the ApplicationID, To make this project work you have to edit "callback.aspx.cs" and put your facebook-app-key there
    2. Adjust the permissions you want to get from user, set that in scope options below.--> 
    <script type="text/javascript">
        window.fbAsyncInit = function () {
            FB.init({
                appId: '140730493223337',
                status: true, // check login status
                cookie: true, // enable cookies to allow the server to access the session
                xfbml: true, // parse XFBML
                oauth: true // enable OAuth 2.0
            });
        };
        (function () {
            var e = document.createElement('script'); e.async = true;
            e.src = document.location.protocol +
            '//connect.facebook.net/en_US/all.js';
            document.getElementById('fb-root').appendChild(e);
        }());

        function loginByFacebook() {
            FB.login(function (response) {
                if (response.authResponse) {
                    FacebookLoggedIn(response);
                } else {
                    console.log('User cancelled login or did not fully authorize.');
                }
            }, { scope: 'email' });
        }

        function FacebookLoggedIn(response) {
            var loc = '/Web/Account/facebook-login.aspx';
            if (loc.indexOf('?') > -1)
                window.location = loc + '&authprv=facebook&access_token=' + response.authResponse.accessToken;
            else
                window.location = loc + '?authprv=facebook&access_token=' + response.authResponse.accessToken;
        }
    </script>
    <!-- faq document -->
    <div class='modal fade' id='share1' tabindex='-1' role='dialog' aria-labelledby='myModalLabel1' aria-hidden='true'>
            <div class='modal-dialog modal-lg'>
                <div class='modal-content'>
                            <div class='modal-body'>
                                <div class="container">
                                    <div class="col-sm-12">
                                        <embed src="faq.pdf" width="800" height="420"/>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-default pull-left' data-dismiss='modal'>Cancel</button>
                            </div>
                        </div>
                    </div>
                </div>

    <!-- faq Test popup-->
    <div class='modal fade' id='faq' tabindex='-1' role='dialog' aria-labelledby='myModalLabel1' aria-hidden='true'>
            <div class='modal-dialog modal-lg'>
                <div class='modal-content'>
                            <div class="modal-header">
                                <div class="container-fluid">
                                <h4>Frequently Asked Questions</h4>
                                    </div>
                            </div>

                            <div class='modal-body'>
                                <div class="container-fluid">
                                    <div class="col-sm-12">
                                       <strong>Question: What is Qaelo?</strong><br />
                                        <p>Answer: Qaelo is a social freelancing website aimed at helping families and small businesses enjoy more free time by offering freelance services that focus on making life and doing business simpler for them. Whether you are looking for a student that will plant vegetables and care of them behind your house the entire year or a part-time accountant for your small carpentry businesses, Qaelo.com lives to fulfil those wishes. This is the reason we emphasise that Qaelo is not a freelancing website, but a “Social” freelancing website where the freelancer you are looking for should be a tertiary institution or 9 streets away from your home or business.
                                        With more than 10 000 tertiary institutions under management, our worldwide duty is to help communities and their freelancers create a more active local economy that will advance living standards, research and technology.
                                        Our added services are as follows (the listing of):<br />
                                        •	Shops<br />
                                        •	Rooms to rent<br />
                                        •	Events<br />
                                        Our added services are free of charge and more information about them is provided further down on this document.<br />
                                        </p>

                                        <br />
                                        <strong>Question: What is a freelancer?</strong><br />
                                        <p>Answer: A freelancer is a self-employed person that offers services to the general community, organisations, and companies at a price set by the self-employed person. In the case of Qaelo, the self-employed persons (freelancers) are students, graduates and young professionals.<br />
                                        Examples… <br />
                                        –	Do you need someone that will entertain your family or colleagues on your next house or office event? With us, you can find freelancers such as Comedians, Singers, Dancers, DJ’s and more offering similar services at different prices. <br />
                                        –	Do you have an elderly parent that you look after? We have freelancers that can drive your parent to check-ups, cook for them if need be and keep them company for the day while you focus on what while you attend meetings, events, travel or work in another city.<br />
                                        –	Do you own a small business? With more than 150 freelance options you can recruit permanent or temporal accountants, repairers, plumbers, software developers, data analysts etc. at no extra cost to you except paying them for their services.<br />
                                        </p>

                                        <br />

                                        <strong>Question: Who is Qaelo meant for?</strong><br />
                                       <p>Answer:<br />
                                        1.	Qaelo is meant for students, graduates and young professionals as a channel for them to expose their skills and services to the public for temporal & permanent employment.<br />
                                        2.	This service is also meant for the community, both the household and small business communities to find affordable freelance service providers.<br />
                                        3.	Thirdly, Qaelo is meant for property rental managers, shop owners and events managers to display, inform and advertise specials to students, graduates and young professionals about their products and services.<br />
                                        </p> 

                                        <br />

                                        <strong>Question: What does Qaelo mean?</strong><br />
                                        <p>Answer: Qaelo has no meaning, but is pronounced as “Khayelo”</p><br />

                                       <strong> Question: What profiles can be created on Qaelo?</strong><br />
                                        <p>Answer:<br /> 
                                        1.	A freelance profile<br />
                                        2.	A property manager profile<br />
                                        3.	A shop manager profile<br />
                                        4.	An events manager profile<br />
                                        </p>

                                        <br />
                                        <strong>Question: How do I go about creating a profile on Qaelo?</strong><br />
                                        <p>Answer: Creating a profile on Qaelo is an easy process that should take about 2 minutes of your time to complete. Once on our website home page, you will click:<br />
                                        •	Create a profile <br />
                                        •	Choose your Qaelo profile<br />
                                        •	Enter your name<br />
                                        •	Enter your surname<br />
                                        •	Enter your email address<br />
                                        •	Create your password<br />
                                        •	Click on create profile <br />
                                        •	Verify your profile on your email Inbox or Spam (last step)<br />
                                        Once your profile has been created, you will be able to fine-tune it to your liking.<br />
                                        </p>
                                        <br />

                                        <strong>Question: How do I search for stuff on Qaelo?</strong><br />
                                       <p>Answer: Say for example you need to find a room to rent around Kingsway Campus, University of Johannesburg; You will click Rooms on the Qaelo home page or in your profile if signed in and search your university by typing it down on the search bar and you will find a list of rooms available around that university campus. This search functionality is the same for all our listing channels, including: <br />
                                        1.	Finding a freelancer (the type of freelancer you are looking for should be entered)<br />
                                        2.	Buying a used textbook<br />
                                        3.	Finding a shop<br />
                                        4.	Finding a room to rent<br />
                                        5.	Finding events around your institution<br /></p>
                                          <br />
                                       <strong> Question: How can I contact Qaelo?</strong><br />
                                         <p>
                                        Answer: Please email us at:<br />
                                        •	<a>info@qaelo.com </a> For general enquiries<br />
                                        •	<a>ads@qaelo.com</a>  For advertising enquiries<br />
                                        •	<a>volunteers@qaelo.com</a> For joining our Volunteer Program<br />
                                        </p> 
                                        <br />

                                        <strong>Question: What is the Qaelo Volunteer Program?</strong>
                                       <p> Answer: The Qaelo Volunteer Program is a marketing program where any registered freelancer can take it upon himself or herself to grow the awareness of Qaelo.com and its services in their tertiary institution through sharing our social media & email messages with their family and friends. At the end of 12 months, the freelancer will get a digital certificate of service which can be used with a CV going forward.<br />
                                        Interested candidates will email their names, surnames and the name of their current or previous tertiary institution of study to <a>volunteers@qaelo.com</a> with the subject “Let’s grow!”<br />
                                        What does the volunteer work require?<br />
                                        The work requires 3 (three) things from the freelancer, explained on the list below.<br />
                                        1.	Like our Facebook page: Qaelo<br />
                                        2.	Share our weekly Facebook posts and emails on your social accounts &<br />
                                        3.	Help three shop managers near your campus or residence create free Qaelo shop profiles.<br />
                                        What’s there to lose? Join us today!<br /></p>
                                        <br />

                                       <strong> Question: How many freelance options can I choose from?</strong>
                                        <p>Answer: You can choose up to 3 freelance options from our list of 150 options!</p><br />
                                       <strong> Question: How many used books can I sell in my store?</strong>
                                       <p> Answer: You can sell up to 8 books in your store; you will upload a picture of your textbook, put a book description and the price that you are selling it for, it is free and we take no commission</p><br />
                                       <strong> Question: How do I advertise myself on landlord’s profiles?</strong>
                                       <p> Answer: After you have signed in to your freelance profile, you will notice a button titled ADVERTISE TO LANDLORDS, click that button and complete the process.</p><br />

                                        <strong>Question: How much is it to advertise on Landlord’s profiles and how does it work?</strong><br />
                                       <p> Answer: <br />
                                        •	It is completely free to advertise yourself to landlords. <br />
                                        •	This functionality is a way to help you find a room to rent easier because your free ad will mention how much rent you are willing to pay, your contact details and other useful information that the property manager will need to see if you qualify to stay in their property. <br />
                                        •	Your ad will only be seen by landlords once they sign into their profiles and can contact you if there is any available room to rent in their property. This ad will be seen by all landlords that have created their profiles under your institution<br />
                                        •	Please remember to delete your ad after you have found accommodation<br /></p><br />

                                        <strong>Question: What happens when I click the button “GO PRIVATE” on my freelance profile?</strong>
                                        <p>Answer: Your profile will only be seen by you and you will not be seen by potential clients when they search for a freelancer that offers the services you also offer through Qaelo.com.</p>

                                        <br />
                                        <strong>Question: What is a Shop profile and what are the benefits associated with creating one?</strong><br />
                                       <p> Answer: A shop profile is an online profile of a shop that is at most 10 kilometres (6 miles) away from a higher institution of learning. The profile should have:<br />
                                        •	A picture of the shop<br />
                                        •	Closing and opening times<br />
                                        •	A short description<br />
                                        •	A menu or product list items for sale<br />
                                        •	Location of the shop and<br />
                                        •	Contact information<br />
                                        <u> <strong>Benefits of creating a shop profile </strong></u><br />
                                        •	It is completely free!<br />
                                        •	You can list as many shops as you own near a university under 1 profile<br />
                                        •	You can create a special and send it to all the freelance profiles in the university you serve<br />
                                        •	You can edit and delete a shop profile you have created<br />
                                        </p>
                                        <br />

                                       <strong>Question: What is a Room profile and what are the benefits associated with creating one?</strong> <br />
                                       <p> Answer: A room profile is an online profile of a property or properties that are at most 10 kilometres (6 miles) away from a higher institution of learning. The profile should have:<br />
                                        •	5 pictures of the property including the room(s) available <br />
                                        •	Detailed description of what a freelancer should expect from your property<br />
                                        •	Location of the property & contact information<br />
                                       <u> <strong>Benefits of creating a room profile</strong></u><br />
                                        •	It is completely free!<br />
                                        •	You can list as many rooms as you own near a university under 1 profile<br />
                                        •	Freelancers can advertise themselves as those looking for accommodation and they will appear on your profile once you log in and you can contact them for a deal<br />
                                        •	You can edit or delete your room profile anytime<br />
                                        </p>
                                        <br />

                                        <strong>Question: What is an Event profile and what are the benefits associated with creating one?</strong><br />
                                       <p>Answer: An event profile is an online profile of an event or audition that is at most 10 kilometres (6 miles) away from a higher institution of learning. The profile should have:<br />
                                        •	A Picture of the proposed event <br />
                                        •	Detailed description of the event<br />
                                        •	Location of the event<br />
                                        •	Contact information<br />
                                        <u><strong>Benefits of creating an event profile</strong></u><br />
                                        •	It is completely free!<br />
                                        •	You can list different events near a university or different universities under 1 profile!<br />
                                        •	You can edit or delete your events anytime<br />
                                        </p> 
                                        <br />
                                        <h4 class="text-center"> Qaelo.com, helping you enjoy more free time!     </h4>
                                    </div>
                                </div>
                            </div>
                
                            <div class='modal-footer'>
                                <button  class='btn btn-danger pull-right' data-dismiss='modal'>Close</button>
                            </div>
                        </div>
                    </div>
                </div>

    <!-- about -->
    <%--<div class="about" id="about">
        <div class="container">
            <div class="about-grids">
                <div class="col-md-5 w3_about_grid_left">
                    <h3>Welcome <span>To</span> <i>Qaelo</i></h3>
                </div>
                <div class="col-md-7 about_grid_right_w3agile">
                    <p style="color:black">If you can imagine an online version of your current physical community (where you can easily know more about what’s new, what’s hot and what’s on special from shops and other community facilities) then you know what Qaelo is: Helping community members and community service providers better serve each other, Qaelo pronounced “Khayelo” is the go to platform for listing and finding shops, events, rooms to rent, freelancers and discounts around your local area! Currently restricted to communities around tertiary institutions globally, we want to welcome you to Qaelo.com and thank you for choosing us today!
                    </p>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>--%>

<%--    <div class="about-bottom">
        <div class="container">
            <div class="about-grids-bottom">
                <div class="col-md-6 about-grids-bottom-left">
                </div>
                <div class="col-md-6 agileinfo_about_grids_bottom_right">
                    
                    <img src="Template/images/QaeloQompetition.jpg" style="height:511px;width:400px" alt=" " class="img-responsive" />
                    <div class="agileinfo_about_grids_bottom_right-pos">
                        <h3>Our added services</h3>
                        <p style="color:black">Do you own a business near a tertiary institution, or maybe you host events and auditions around such areas? Let your community know more about you online by creating a free lifetime Qaelo profile and enjoy the following services we offer!<br />
                            •	List your physical shop<br />
                            •	List your rooms to rent<br />
                            •	List your events and auditions<br />
                            •	Enjoy free traffic to your Qaelo online profile today!<br />

                        </p>
                    </div>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>--%>

    <!-- //about -->
    <!-- team -->
    <%--<div class="team">
        <div class="container">
            <h3>Meet Our Team</h3>

            <div class="team-grids">
                <div class="col-md-3 team-grid">
                    <div class="w3l_team_grd">
                        <img src="Template/images/2.jpg" alt=" " class="img-responsive" />
                    </div>
                    <div class="team_grid1_agileits">
                        <h4>Njabulo Mdaka<span>Founder, Head of Marketing</span></h4>
                        <p>This fellow loves to play the game of chess while munching on some wine gums!</p>

                    </div>
                </div>
                <div class="col-md-3 team-grid">
                    <div class="w3l_team_grd">
                        <img src="Template/images/3.jpg" alt=" " class="img-responsive" />
                    </div>
                    <div class="team_grid1_agileits">
                        <h4>Oratile Seabe<span>Head of Research</span></h4>
                        <p>If she’s not travelling to a foreign land,she’s sketching something beautiful!</p>

                    </div>
                </div>
                <div class="col-md-3 team-grid">
                    <div class="w3l_team_grd">
                        <img src="Template/images/4.jpg" alt=" " class="img-responsive" />
                    </div>
                    <div class="team_grid1_agileits">
                        <h4>Thabang Lekwadi <span>Chief Developer</span></h4>
                        <p>Very creative ,but is also a soliloquy.Click <a target="_blank" href="https://tsobang.co.za/">here</a> for website development bookings</p>

                    </div>
                </div>
                <div class="col-md-3 team-grid">
                    <div class="w3l_team_grd">
                        <img src="Template/images/5.jpg" alt=" " class="img-responsive" />
                    </div>
                    <div class="team_grid1_agileits">
                        <h4>Pearl Ngqobo <span>Head of Administration</span></h4>
                        <p>Creative, energetic and in love with great music!<br> <i style="opacity:-20">.</i></p>

                    </div>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>--%>
    <!-- //team -->

    <!-- portfolio -->
    <%--<div class="portfolio" id="portfolio" style="margin-top:-80px">
        <div class="container">
            <h3>Companies we love</h3>
            <div class="portfolio_grid_w3lss">
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel="" href="#" title="Wayfaring">
                            <img src="Images/Convinience/uber.jpg" class="img-responsive"/>
                            <div class="mask">
                                <p><a style="color:white" href="https://play.google.com/store/apps/details?id=com.ubercab&hl=en" target="_blank">Transport</a></p>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Wayfaring">
                            <img src="Images/Convinience/EToro_logo_facebook_profile.jpg" class="img-responsive"  />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.etoro.com/" target="_blank">Forex Trading</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Wayfaring">
                            <img src="Images/Convinience/getor.jpg" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.hostgator.com/" target="_blank">Web Hosting</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/getSmarter.png" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="https://www.getsmarter.com" target="_blank">Online courses</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/Huawei.png" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://consumer.huawei.com" target="_blank">Gadgets</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/Netflix.png"  class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="https://www.netflix.com" target="_blank">Online streaming</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/STATravel.jpg" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://www.statravel.com" target="_blank">Travel</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/ups.png" style="margin-top:-20px" class="img-responsive" />
                            <div class="mask">
                                <p><a style="color:white" href="http://ups.com" target="_blank">Parcel Services</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="col-md-4 portfolio_grid_w3ls">
                    <div class="view second-effect">
                        <a class="zb" rel=" " href="#" title="Life Style">
                            <img src="Images/Convinience/nike.jpg"  class="img-responsive"/>
                            <div class="mask">
                                <p><a style="color:white" href="http://nike.com" target="_blank">Sports Apparel</a></p>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="clearfix"> </div>
            </div>
            <script type="text/javascript" src="Template/js/jquery.zbox.min.js"></script>
            <script type="text/javascript">
				  //<![CDATA[
				  jQuery(document).ready(function(){
					jQuery(".zb").zbox( { margin:40 } );
				  });
				  //]]>
            </script>
        </div>
    </div>--%>
    <!-- //portfolio -->

    <!-- services -->
    <!--<div class="services" id="services">
        <div class="container">
            <h3>Our contribution to you</h3>
            <div class="wthree_services_grids">
                <div class="col-md-6 wthree_services_grid">
                    <div class="col-xs-4 wthree_services_grid-left">
                        <div class="wthree_services_grid-left1">
                            <span class="glyphicon glyphicon-eye-open" aria-hidden="true"></span>
                        </div>
                    </div>
                    <div class="col-xs-8 wthree_services_grid-right">
                        <h4>Make money with us</h4>
                        <p>Freelance. Sell your used textbooks & Build your dream team!</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="col-md-6 wthree_services_grid">
                    <div class="col-xs-4 wthree_services_grid-left">
                        <div class="wthree_services_grid-left1">
                            <span class="glyphicon glyphicon-plane" aria-hidden="true"></span>
                        </div>
                    </div>
                    <div class="col-xs-8 wthree_services_grid-right">
                        <h4>Stay social</h4>
                        <p>Contribute to our weekly blog & Stay social!</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="clearfix"> </div>
            </div>

            <div class="wthree_services_grids">
                <div class="col-md-6 wthree_services_grid">
                    <div class="col-xs-4 wthree_services_grid-left">
                        <div class="wthree_services_grid-left1">
                            <span class="glyphicon glyphicon-retweet" aria-hidden="true"></span>
                        </div>
                    </div>
                    <div class="col-xs-8 wthree_services_grid-right">
                        <h4>Find and list stuff</h4>
                        <p>Find Freelancers & Used Books. List Rooms, Shops, Events & More!</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="col-md-6 wthree_services_grid">
                    <div class="col-xs-4 wthree_services_grid-left">
                        <div class="wthree_services_grid-left1">
                            <span class="glyphicon glyphicon-briefcase" aria-hidden="true"></span>
                        </div>
                    </div>
                    <div class="col-xs-8 wthree_services_grid-right">
                        <h4>Enjoy the convenience we offer</h4>
                        <p>Find 9 of the best products & services for your lifestyle on your profile today!</p>
                    </div>
                    <div class="clearfix"> </div>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>-->
    
    <div class="copy-right">
        <div class="container">
            <p>Copyright &copy; 2018 Qaelo. All Rights Reserved.</p>
            <div class="social_icons">
                <ul>
                    <li><a href="https://twitter.com/qaeloofficial?lang=en" class="icon icon-cube rss"></a></li>
                </ul>
            </div>
        </div>
    </div>

    <!-- //footer -->
    <!-- for bootstrap working -->
    <script src="Template/js/bootstrap.js"></script>
    <!-- //for bootstrap working -->
    <!-- here stars scrolling icon -->
    <script type="text/javascript">
		$(document).ready(function() {

			$().UItoTop({ easingType: 'easeOutQuart' });

			});
    </script>
    <!-- //here ends scrolling icon -->
</body>
</html>