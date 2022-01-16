<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kartoni.aspx.cs" Inherits="HospitalWebApplication.Kartoni" %>

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
        <h2 style="color: white; text-align:center; margin: 5px; padding-bottom: 15px">Informacije o kartonima</h2>
         <div class="row">
             <div class="col-4">
        <button id="getId" runat="server" onserverclick="getId_ServerClick" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer; align-content:center;margin:auto">
            <i class="fas fa-list"></i>
            <p>Lista kartona</p>
         </button>
        </div>
              <div class="col-4">
         <button id="insertId" runat="server" onserverclick="insertId_ServerClick" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;  align-content:center;margin:auto">
            <i class="fas fa-plus"></i>
            <p>Dodaj karton</p>
         </button>  
                  </div>
                   <div class="col-4">
         <button id="updateId" runat="server" onserverclick="updateId_ServerClick" style="background: rgba(255, 255, 255, 0.8);border: 5px solid white; border-radius: 10px; font-weight: 600;text-transform: uppercase; text-align: center;cursor: pointer;  align-content:center;margin:auto">
            <i class="fas fa-pen-alt"></i>
            <p>Izmeni karton</p>
         </button>
            </div>
            </div>
             <div class="container">
            <div class=" mt-4 mb-4">
         <div class="row">
          <div class="mb-3">
          <input type="text" placeholder="Broj kartona" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-2 mb-1" id="BrojKartona" runat="server" >
          <input type="text" placeholder="Id doktora" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="IdDoktora" runat="server">
          <input type="text" placeholder="Recept" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Recept" runat="server" >
         <input type="text" placeholder="Bolest" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-1" id="Bolest" runat="server" >
          <input type="text" placeholder="Alergija" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="Alergija" runat="server" >
          <input type="text" placeholder="Simptom" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="Simptom" runat="server" >
         <input type="text" placeholder="Terapija" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="Terapija" runat="server" >
          <input type="text" placeholder="Datum poslednje izmene" style="background: rgba(255, 255, 255, 0.8);" class="form-control mt-1 mb-2" id="DatumPoslednjeIzmene" runat="server" >
           </div>
             </div>
          </div>
        <%--</div>--%>
         </div>
         
        </div>
        </div>
     </div>
        <div class="container p-5" >
        <div id="kartoniId" runat="server" style="background:rgb(160, 188, 190); border-radius: 10px 0px; margin-bottom:5px; padding: 3px ">
        </div>

            </div>
        </form>
  
</body>
</html>