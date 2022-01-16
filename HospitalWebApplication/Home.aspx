<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HospitalWebApplication.Home" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" integrity="sha512-Fo3rlrZj/k7ujTnHg4CGR2D7kSs0v4LLanw2qksYuRlEzO+tcaEPQogQ0KaoGN26/zrn20ImR1DfuLWnOo7aBA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <title>Bolnica - Informacije</title>
</head>
<body style="height: 100vh;font-weight:600;background: linear-gradient(90deg, rgba(255,255,255,0.4), rgba(255,255,255,0.4)),
url('images/Form2.jpg');background-size: cover;background-repeat: no-repeat;">
    <form id="form1" runat="server">
    <div class="container w-50">

     <div class="row" style="color:rgb(110, 107, 107);display: flex;flex-direction: column; justify-content: center;height: 100vh;">
         
        <h2 style="color: white; text-align:center; margin: 5px; padding-bottom: 15px">Informacije o pacijentima</h2>
         <div class="row text-center">
             <div class="col-3 text-center">
        <button id="getId" runat="server" onserverclick="getId_ServerClick"  style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-list"></i>
            <p>Lista pacijenata</p>
         </button>
        </div>
              <div class="col-3 text-center">
         <button id="insertId" runat="server" onserverclick="insertId_ServerClick"   style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-plus"></i>
            <p>Dodaj pacijenta</p>
         </button>  
                  </div>
                   <div class="col-3 text-center">
         <button id="updateId" runat="server" onserverclick="updateId_ServerClick"  style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;">
            <i class="fas fa-pen-alt"></i>
            <p>Izmeni informacije</p>
         </button>
            </div>
             <div class="col-3">
         <button id="deleteId" runat="server" onserverclick="deleteId_ServerClick"  style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer; padding: 3px">
            <i class="fas fa-dumpster"></i>
            <p>Izbriši pacijenta</p>
         </button>
                 
            </div>
             <div class="container">
            <div class="container mt-4 mb-4">
         <div class="row">
          <div class="mb-3">
          <input type="text" placeholder="Broj kartona" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-2 mb-1" id="BrojKartona" runat="server" >
          <input type="text" placeholder="Ime" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Ime" runat="server">
          <input type="text" placeholder="Prezime" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Prezime" runat="server" >
         <input type="text" placeholder="JMBG" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="JMBG" runat="server" >
          <input type="text" placeholder="Adresa" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="Adresa" runat="server" >
          <input type="text" placeholder="Broj telefona" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="BrojTelefona" runat="server" >
              </div>
            
             </div>
                <button id="kartonId" runat="server" onserverclick="kartonId_ServerClick" type="submit" style="font-weight: 600;color: white;background: rgb(10, 17, 58); border-radius: 5px" class="btn btn-light mx-auto w-50 text-center">Informacije o kartonima</button>
          </div>
        <%--</div>--%>
         </div>
         
        </div>
        </div>
     </div>
        <div class="container p-5" >
        <div id="pacijentiId" runat="server" style="background:rgb(160, 188, 190); border-radius: 10px 0px; margin-bottom:5px; padding: 3px ">
        </div>

            </div>
        </form>
  
</body>
</html>