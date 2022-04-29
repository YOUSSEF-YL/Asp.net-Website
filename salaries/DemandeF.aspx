<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DemandeF.aspx.cs" Inherits="Formation.salaries.DemandeF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1 style="margin-left: 200px" class="mt-0"> Demande Un Formation</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Labelerror" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF0066" Visible="False"> ERRR</asp:Label>
    </div>
     <div>

       
            

        <div class="auto-style2" style="margin-left: 80px">
        
  <div class="form-floating mb-3" style="margin-left: 120px">
   
      <asp:TextBox ID="idforma" runat="server"  class="form-control"   Width="549px" ReadOnly="True"></asp:TextBox>
    <label for="floatingInput">ID Formation</label>
  </div>
          <br />
  <div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="dateDem" runat="server"  class="form-control" placeholder="Date"   Width="555px" ReadOnly="True"></asp:TextBox>
    <label for="floatingPassword">Date</label>

  </div>
    <br />
<div class="form-floating" style="margin-left: 120px">
    
      <asp:TextBox ID="Motif" runat="server"  class="form-control" placeholder="Motif de demande"   Width="555px"></asp:TextBox>
    <label for="floatingPassword">Motif de demande</label>

  </div>

    <br />


           <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Demander" class="btn btn-primary btn-lg" style="margin-left: 249px" Width="292px" OnClick="Button1_Click" />
          
    </div>
  
   

         
   </div>
</asp:Content>
