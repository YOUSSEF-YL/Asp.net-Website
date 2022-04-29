<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ajouteformation.aspx.cs" Inherits="Formation.RH.ajouteformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1 style="margin-left: 200px" class="mt-0"> Ajouter  Un nouvelle  Formation</h1>
    </div>
    
     <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;
         
          

        <div class="auto-style2" style="margin-left: 80px">
   
  <div class="form-floating mb-3" style="margin-left: 120px">
   
      <asp:TextBox ID="nom" runat="server"  class="form-control"  placeholder="Nom Formation" Width="549px"></asp:TextBox>
    <label for="floatingInput">Nom Formation</label>
  </div>
          <br />
  <div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="Descrip" runat="server"  class="form-control" placeholder="Description"   Width="555px"></asp:TextBox>
    <label for="floatingPassword">Description</label>

  </div>
    <br />
<div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="Dure" runat="server"  class="form-control" placeholder="Dure par jour"   Width="555px"></asp:TextBox>
    <label for="floatingPassword">Dure par jour</label>

  </div>

    <br />

<div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="DateDebut" runat="server"  class="form-control" placeholder="Date Debut"   Width="555px"></asp:TextBox>
    <label for="floatingPassword">Date Debut</label>

  </div>
           <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ajouter" Width="422px" style="margin-left: 171px" class="btn btn-primary btn-lg" OnClick="Button1_Click"/>
          
    </div>
  
   

         
   </div>
&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
