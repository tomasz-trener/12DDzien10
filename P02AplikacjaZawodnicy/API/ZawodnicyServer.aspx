<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyServer.aspx.cs" Inherits="P02AplikacjaZawodnicy.API.ZawodnicyServer" %>


 <div class="card-body">
                <div class="table-responsive">
                  <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Nazwa
                      </th>
                      <th>
                        Kraj
                      </th>
                      <th>
                        Wzrost
                      </th>
                      <th>
                        Data urodzenia
                      </th>
                    </thead>
                    <tbody>
                      
                        <% 
                            foreach (var z in Zawodnicy)
                            {
                         %>
                            <tr>
                                <td><%= z.imie + " " + z.nazwisko %></td>
                                <td><%= z.kraj %></td>
                                <td><%= z.wzrost %></td>
                                <td><%= z.data_ur?.ToString("dd-MM-yyyy") %></td>
                            </tr>


                         <% }
                            %>


                    </tbody>
                  </table>
                </div>
              </div>
