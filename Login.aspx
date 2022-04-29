<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Formation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap_quartz.css" rel="stylesheet" />
    
    
    
    <style type="text/css">
        .auto-style2 {
            height: 86px;
            width: 603px;
            margin-left: 52px;
            margin-top: 171px;
            margin: auto;
              width: 50%;
             
              padding: 10px;
        }
    </style>
    
    
    
</head>
<body style="height: 513px; margin-right: 325;">
    
    
    <br />
    <form runat="server">

        <div class="auto-style2">
  <label class="form-label mt-4">utilisateur</label>
  <div class=" form-floating mb-3" id="userinpt" runat="server"             >
   
      <input type="text"  class="form-control"  id="nomut" runat="server" />
    <label for="floatingInput">Nom utilisateur</label>
  </div>

            


            <label class="form-label mt-4">Mot de pass</label>
  <div class="form-floating">
    
      <asp:TextBox ID="pass" runat="server"  class="form-control" placeholder="Password"  type="password"></asp:TextBox>
    <label for="floatingPassword">Password</label>
  </div>
           
            <br />
            <br />
           

            <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg" Text="Log in" OnClick="Button1_Click" />
    </div>
  
   

    </form>
    

    <p>
        &nbsp;</p>
    

</body>
</html>
