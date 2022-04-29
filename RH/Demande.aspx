<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Demande.aspx.cs" Inherits="Formation.RH.Demande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" ViewStateMode="Disabled">
       <ItemTemplate runat="server">

           <div class="card border-dark mb-3" style="max-width: 20rem;display:inline-grid; margin:20px; ">
      <div class="card-header"> <%#Eval("statut".ToUpper()) %> </div>
      <div class="card-body">
       <%-- <h6 runat="server" class="card-title" id="ctrlID"> <h6 class="titie">ID :</h6>     <%#Eval("id_forma") %>   </h6>--%>
          <h6 class="titie">ID Demand :</h6> 
          <asp:Label runat="server" class="card-title" ID="ctrlID"  Text='  <%#Eval("refDem") %> '>  </asp:Label>
           <h6 class="card-title"> <h6 class="titie">Date Demande :</h6> <%#Eval("date_dem") %> </h6>
           <h6 class="card-title"><h6 class="titie">Motif :</h6> <%#Eval("motif") %> </h6>
           <h6 class="card-title"> <h6 class="titie">ID Salarie :</h6> <%#Eval("id_salarie") %> </h6>
          <h6 class="card-title"><h6 class="titie">ID Formation :</h6> <%#Eval("id_forma") %> </h6>
         <%--  <h6 class="card-title"> <h6 class="titie">Statut :</h6> <%#Eval("statut") %> </h6>--%>
             <h6 class="card-title"> 
                    &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Accepte" class="btn btn-primary btn-sm" Style="margin: 3px" OnClientClick="Repeater1_ItemCommand

                        "
                 CommandName="Accepte" /> 
                    &nbsp;&nbsp;&nbsp;<asp:Button ID="btnR" runat="server" Text="Refuse" class="btn btn-primary btn-sm" OnClientClick="
                        "
                     CommandName="Refuse" />
             </h6>
      </div>

         

           </div>
       </ItemTemplate>
    </asp:Repeater>

</div>
</asp:Content>
