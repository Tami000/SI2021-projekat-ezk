<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HospitalWebApplication.LogIn" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <title>Bolnica - Login</title>
</head>
<body style="height: 100vh;font-weight:600;background: 
url('Images/Form.jpg');background-size: cover;background-repeat: no-repeat;">
   
    <div class="container w-50">
    <form id="form1" runat="server" style="color:white;display: flex;flex-direction: column; justify-content: center;height: 100vh;">
        <h2 style="text-align: center;text-transform: uppercase;font-weight: 600;margin-bottom: 2rem;">Bolnica</h2>
        <div class="mb-3">
          <label for="usernameId" class="form-label">Korisničko ime:</label>
          <input type="text" style="background: rgba(255, 255, 255, 0.8);" class="form-control" id="usernameId" runat="server" aria-describedby="emailHelp">
        </div>
        <div class="mb-3">
          <label for="passwordId" class="form-label">Lozinka:</label>
          <input type="password" style="background: rgba(255, 255, 255, 0.8);" class="form-control" id="passwordId" runat="server">
        </div>
        <div class="mb-3 form-check">
        </div>
        <button id="login" runat="server" onserverclick="login_ServerClick" type="submit" style="font-weight: 600;color:rgb(78, 78, 78);background: rgba(255, 255, 255, 0.8);" class="btn btn-light mx-auto w-50">Log In</button>
      </form>
    </div>
</body>
</html>