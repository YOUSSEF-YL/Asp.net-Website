<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="formation.aspx.cs" Inherits="Formation.salaries.formation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <style>

        
        .auto-style11 {
            width: 1227px;
            height: auto;
            overflow: hidden;
        }
        .titie {
            color:black;
        }
        .card-title{
            display:inline;
        }
    </style>
   
<div class="auto-style11">
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" ViewStateMode="Disabled" >
       <ItemTemplate runat="server">

           <div class="card border-dark mb-3" style="max-width: 20rem;display:inline-grid; margin:20px; ">
      <div class="card-header"> <%#Eval("nom") %> </div>
      <div class="card-body">
       <%-- <h6 runat="server" class="card-title" id="ctrlID"> <h6 class="titie">ID :</h6>     <%#Eval("id_forma") %>   </h6>--%>
          <h6 class="titie">ID :</h6> 
          <asp:Label runat="server" class="card-title" ID="ctrlID"  Text='  <%#Eval("id_forma") %> '>  </asp:Label>
           <h6 class="card-title"> <h6 class="titie">Date Debut :</h6> <%#Eval("DateDebut") %> </h6>
           <h6 class="card-title"><h6 class="titie">Dure :</h6> <%#Eval("Dure") %> </h6>
           <h6 class="card-title"> <h6 class="titie">Description :</h6> <%#Eval("Description") %> </h6>
          
             <h6 class="card-title"> <asp:Button ID="Button1" runat="server" Text="Demander" class="btn btn-primary btn-sm" Style="margin: 3px" OnClientClick="Repeater1_ItemCommand" /> 

             </h6>
      </div>

         

           </div>
       </ItemTemplate>
    </asp:Repeater>

</div>
    
</asp:Content>
