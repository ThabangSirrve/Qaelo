<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Users/Student/template.Master" AutoEventWireup="true" CodeBehind="students-buy-textbooks.aspx.cs" Inherits="Qaelo.Web.Users.Student.students_buy_textbooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Buy Textbooks</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:60px"></div>
<div class="container col-sm-8 col-sm-offset-2 thumbnail">
        <div class="col-sm-12"><h3 class="text-center">Buy books!</h3><br />
            <div class="row" id="divContent" runat="server">

                <!-- second row-->

                <div class="col-sm-12">

                 <div class="col-sm-6">
                                  <div class="form-group col-sm-offset-1">
                                            <label>Field of study</label>
                                            <asp:DropDownList ID="ddlField" Width="100%" CssClass="form-control" runat="server" >
                                                  <asp:ListItem selected="" Value="N/A">- Select Field of study -</asp:ListItem>
                                                  <asp:ListItem Value="ART Design and architecture">ART Design and architecture</asp:ListItem>
                                                  <asp:ListItem Value="Education">Education</asp:ListItem>
                                                  <asp:ListItem Value="Engineering And Build Environment">Engineering And Build Environment</asp:ListItem>
                                                  <asp:ListItem Value="Finacial Sciences">Finacial Sciences</asp:ListItem>
                                                  <asp:ListItem Value="Health">Health</asp:ListItem>
                                                  <asp:ListItem Value="Humanities">Humanities</asp:ListItem>
                                                  <asp:ListItem Value="Management">Management</asp:ListItem>
                                                  <asp:ListItem Value="Law">Law</asp:ListItem>
                                                  <asp:ListItem Value="Science">Science</asp:ListItem>
                                              </asp:DropDownList>
                                   </div>                             
                                  
              </div>
                 
                 <div class="col-sm-6">
                                           <div class="form-group">
                                                <label>Year</label>
                                              <asp:DropDownList ID="ddlYear" Width="100%" CssClass="form-control" runat="server" >
                                                                              <asp:ListItem selected="" Value="N/A">- Select year of study -</asp:ListItem>
                                                                              <asp:ListItem Value="Bridging">Bridging</asp:ListItem>
                                                                              <asp:ListItem Value="1st">1st</asp:ListItem>
                                                                              <asp:ListItem Value="2nd">2nd</asp:ListItem>
                                                                              <asp:ListItem Value="3rd">3rd</asp:ListItem>
                                                                              <asp:ListItem Value="4th">4th</asp:ListItem>
                                                                              <asp:ListItem Value="Honours">Honours</asp:ListItem>
                                                                              <asp:ListItem Value="Masters">Masters</asp:ListItem>
                                                                              <asp:ListItem Value="Doctorate">Doctorate</asp:ListItem>
                                                                          </asp:DropDownList>
                                               </div>                     
                  </div>
                </div>          

                    <div class="col-sm-12 text-center"> 
                         <asp:TextBox ID="txtText" placeholder="Type Tertiary Institution" runat="server" type="text" class="typeaheadPlaces tt-query form-control" autocomplete="on" spellcheck="false"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-default" style="color:sandybrown" runat="server" Text="Find" OnClick="btnSearch_Click" />
                    </div>        

          </div>
            <hr /></div>
        <div class="col-sm-12">
            <asp:Literal ID="lblBooks" runat="server"></asp:Literal>
        </div>
    </div>
</asp:Content>
