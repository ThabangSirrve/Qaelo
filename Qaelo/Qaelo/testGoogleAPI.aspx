<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="testGoogleAPI.aspx.cs" Inherits="Qaelo.testGoogleAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>

        @-moz-keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -moz-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -moz-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -moz-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}
@-webkit-keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -webkit-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}
@keyframes bounceDown {
  0%, 20%, 50%, 80%, 100% {
    -moz-transform: translateY(0);
    -ms-transform: translateY(0);
    -webkit-transform: translateY(0);
    transform: translateY(0);
  }
  40% {
    -moz-transform: translateY(-30px);
    -ms-transform: translateY(-30px);
    -webkit-transform: translateY(-30px);
    transform: translateY(-30px);
  }
  60% {
    -moz-transform: translateY(-15px);
    -ms-transform: translateY(-15px);
    -webkit-transform: translateY(-15px);
    transform: translateY(-15px);
  }
}





@-webkit-keyframes bounceLeft {
  0%,
  20%,
  50%,
  80%,
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  40% {
    -webkit-transform: translateX(30px);
    transform: translateX(30px);
  }
  60% {
    -webkit-transform: translateX(15px);
    transform: translateX(15px);
  }
}
@-moz-keyframes bounceLeft {
  0%,
  20%,
  50%,
  80%,
  100% {
    transform: translateX(0);
  }
  40% {
    transform: translateX(30px);
  }
  60% {
    transform: translateX(15px);
  }
}
@keyframes bounceLeft {
  0%,
  20%,
  50%,
  80%,
  100% {
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  40% {
    -ms-transform: translateX(30px);
    transform: translateX(30px);
  }
  60% {
    -ms-transform: translateX(15px);
    transform: translateX(15px);
  }
}
/* /left bounce */


/* right bounce */
@-webkit-keyframes bounceRight {
  0%,
  20%,
  50%,
  80%,
  100% {
    -webkit-transform: translateX(0);
    transform: translateX(0);
  }
  40% {
    -webkit-transform: translateX(-30px);
    transform: translateX(-30px);
  }
  60% {
    -webkit-transform: translateX(-15px);
    transform: translateX(-15px);
  }
}
@-moz-keyframes bounceRight {
  0%,
  20%,
  50%,
  80%,
  100% {
    transform: translateX(0);
  }
  40% {
    transform: translateX(-30px);
  }
  60% {
    transform: translateX(-15px);
  }
}
@keyframes bounceRight {
  0%,
  20%,
  50%,
  80%,
  100% {
    -ms-transform: translateX(0);
    transform: translateX(0);
  }
  40% {
    -ms-transform: translateX(-30px);
    transform: translateX(-30px);
  }
  60% {
    -ms-transform: translateX(-15px);
    transform: translateX(-15px);
  }
}
/* /right bounce */


/* assign bounce */
.fa-arrow-right {
  -webkit-animation: bounceRight 2s infinite;
  animation: bounceRight 2s infinite;
  float:right;
}

.fa-arrow-left {
  -webkit-animation: bounceLeft 2s infinite;
  animation: bounceLeft 2s infinite;
}

.fa-chevron-down {
  -moz-animation: bounceDown 2s infinite;
  -webkit-animation: bounceDown 2s infinite;
  animation: bounceDown 2s infinite;
text-align:center;
  display:block;
}


.credits {padding-top:50px; display:block; clear:both;}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              
    

<i class="fa fa-arrow-left"></i>
<i class="fa fa-chevron-down"></i>
<i class="fa fa-arrow-right"></i>

<p class="credits">Credits: Liquid <a href="http://liquid.gallery" target="_blank">Web Design London</a></p>
</asp:Content>
