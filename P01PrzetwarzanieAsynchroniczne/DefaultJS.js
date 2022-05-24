

$(document).ready(function () {

    $("#btnPrzyciskHTML").click(function () {

        var liczba1 = $("#txtLiczba1HTML").val();
        var liczba2 = $("#txtLiczba2HTML").val();

       // var wynik = liczba1 + liczba2;
      //  $("#txtWynikHTML").val(wynik);

        $.ajax({
            method: "POST",
            url: "DefaultServer.aspx",
            data: { liczba1: liczba1, liczba2Dane: liczba2 }
        })
        .done(function (msg) {
                alert(msg);
         });


    });



});