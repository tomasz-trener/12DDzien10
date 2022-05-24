
$(document).ready(function () {

    //const interval = setInterval(function () {

    //}, 2000);

   // setInterval();
   // clearInterval(interval); // thanks @Luca D'Amico
    PodajLiczbeStron();
    Odswiez(1);

    $("#btnLewo").click(function () {
         
        var t = $("#txtStrona").val();
        t = parseInt(t);
        t = t - 1;
        $("#txtStrona").val(t);
        Odswiez(t);
    });

    $("#btnPrawo").click(function () {
        var t = $("#txtStrona").val();
        t = parseInt(t);
        t = t + 1;
        $("#txtStrona").val(t);
        Odswiez(t);
    });

});

function Odswiez(t) {
    $.ajax({
        method: "POST",
        url: "../API/ZawodnicyServer.aspx",
        data: { strona: t, ile: 6 }
    })
        .done(function (msg) {

            $("#zawartosc").html(msg);

        });
}

function PodajLiczbeStron() {
    $.ajax({
        method: "POST",
        url: "../API/LiczbaStronServer.aspx",
        data: { ile: 6 }
    })
        .done(function (msg) {
            $("#txtLiczbaStron").val(msg);
        });
}