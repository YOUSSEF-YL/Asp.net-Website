<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="supprimerFormation.aspx.cs" Inherits="Formation.RH.supprimerFormation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div>
        <h1 style="margin-left: 280px" class="mt-0"> Supprimer Un  Formation</h1>
    </div>
    
     <div>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:DropDownList ID="DropDownList1" class="dropdown1" runat="server" AutoPostBack="True" OnTextChanged="Unnamed1_Click" DataSourceID="SqlDataSource1" DataTextField="nom" DataValueField="id_forma" >
           
             
         </asp:DropDownList>

         

         &nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Labelerror" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF0066" Visible="False"></asp:Label>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:formation_catalogConnectionString %>" SelectCommand="SELECT * FROM [formations]"></asp:SqlDataSource>
            
        
         
         <br />
&nbsp;<div class="auto-style2" style="margin-left: 80px">
    
   
  <div class="form-floating mb-3" style="margin-left: 120px">
   
      <asp:TextBox ID="nom" runat="server"  class="form-control"  placeholder="Nom Formation" Width="549px" ReadOnly="True"></asp:TextBox>
    <label for="floatingInput">Nom Formation</label>
  </div>
          <br />
  <div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="Descrip" runat="server"  class="form-control" placeholder="Description"   Width="555px" ReadOnly="True"></asp:TextBox>
    <label for="floatingPassword">Description</label>

  </div>
    <br />
<div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="Dure" runat="server"  class="form-control" placeholder="Dure par jour"   Width="555px" ReadOnly="True"></asp:TextBox>
    <label for="floatingPassword">Dure par jour</label>

  </div>

    <br />

<div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="DateDebut" runat="server"  class="form-control" placeholder="Date Debut"   Width="555px" ReadOnly="True"></asp:TextBox>
    <label for="floatingPassword">Date Debut</label>

  </div>
           <br />
            <br />
    <asp:Button runat="server" Text="Supprimer"  class="btn btn-primary btn-lg" style="margin-left: 241px" Width="290px" ID="Supprimer" OnClick="Unnamed1_Click" />
          
    </div>
  
   

         
   </div>
&nbsp;&nbsp;&nbsp;&nbsp; 




</asp:Content>
