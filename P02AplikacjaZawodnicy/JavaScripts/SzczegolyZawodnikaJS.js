$(document).ready(function () {

    $("#btnZapisz").click(function () {

        var id = $("#txtIdZawodnika").val(); 
        var imie = $("#txtImie").val();
        var nazwisko = $("#txtNazwisko").val();
        var kraj = $("#txtKraj").val();
        var wzrost = $("#txtWzrost").val();
        var waga = $("#txtWaga").val();
        var dataUr = $("#txtDataUr").val();

        $.ajax({
            method: "POST",
            url: "../API/EdycjaZawodnika.aspx",
            data: { id:id, imie: imie, nazwisko: nazwisko, kraj:kraj,wzrost:wzrost, waga:waga, dataUr:dataUr}
        })
            .done(function (msg) {
                //alert("Data Saved: " + msg);
                Odswiez();
                $("#poleSzczegolyZawodnika").html("");
                var komunikat = "Zapisano zawodnika" + imie + " " + nazwisko;
                nowuiDashboard.showNotification('top', 'center', komunikat);
            });

    });


    $("#btnUsun").click(function () {

        var id = $("#txtIdZawodnika").val();
        var imie = $("#txtImie").val();
        var nazwisko = $("#txtNazwisko").val();
        $.ajax({
            method: "POST",
            url: "../API/UsuwanieZawodnika.aspx",
            data: { id: id }
        })
            .done(function (msg) {
               
                //alert("Data Saved: " + msg);
                Odswiez();
                $("#poleSzczegolyZawodnika").html("");
                var komunikat = "Usunieto zawodnika" + imie + " " + nazwisko;
                nowuiDashboard.showNotification('top', 'center', komunikat);
            });


    });




});