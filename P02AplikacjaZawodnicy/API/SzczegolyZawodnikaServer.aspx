<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SzczegolyZawodnikaServer.aspx.cs" Inherits="P02AplikacjaZawodnicy.API.SzczegolyZawodnikaServer" %>



<div class="card">
    <input type="hidden" id="txtIdZawodnika" value="<%=ZawodnikWysietlany.id_zawodnika %>" />

              <div class="card-header">
                <h5 class="title">Edit Profile</h5>
              </div>
              <div class="card-body">
                <form>
                  <div class="row">
                    <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Imie</label>
                        <input type="text" id="txtImie" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.imie %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Nazwisko</label>
                        <input type="text" id="txtNazwisko" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.nazwisko %>">
                      </div>
                    </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Kraj</label>
                        <input type="text" id="txtKraj" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.kraj %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Data urodzenia</label>
                        <input type="text" id="txtDataUr" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.data_ur?.ToString("yyyy-MM-dd") %>">
                      </div>
                    </div>
                  </div>

                  <div class="row">
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Waga</label>
                        <input type="text" id="txtWaga" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.waga %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Wzrost</label>
                        <input type="text" id="txtWzrost" class="form-control" placeholder="Username" value="<%= ZawodnikWysietlany.wzrost %>">
                      </div>
                    </div>
     
                  </div>

                    <input id="btnZapisz" type="button" value="Zapisz" class="btn btn-primary btn-block">
                    
                    <input id="btnUsun" type="button" value="Usuń" class="btn btn-primary btn-block">
                </form>
              </div>
            </div>
<script src="../JavaScripts/SzczegolyZawodnikaJS.js"></script>
