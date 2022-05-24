
$(document).ready(function () {

    //const interval = setInterval(function () {

    //}, 2000);

   // setInterval();
   // clearInterval(interval); // thanks @Luca D'Amico
    PodajLiczbeStron();
    Odswiez(1);

    //$("#btnLewo").click(function () {
         
    //    var t = $("#txtStrona").val();
    //    t = parseInt(t);
    //    t = t - 1;
    //    $("#txtStrona").val(t);
    //    Odswiez(t);
    //});

    //$("#btnPrawo").click(function () {
    //    var t = $("#txtStrona").val();
    //    t = parseInt(t);
    //    t = t + 1;
    //    $("#txtStrona").val(t);
    //    Odswiez(t);
    //});

    $(".input-group-append").click(function () {
        var zawartosc = $("input.form-control").val();

        Odswiez(1, zawartosc)

    });

    //$('.input-group-append').keypress(function (event) {
    //    //event.preventDefault();
    //    var keycode = (event.keyCode ? event.keyCode : event.which);
    //    if (keycode == '13') {
    //        alert('You pressed a "enter" key in textbox');
    //    }
    //});

   



});

function Odswiez(t, zawartosc) {
    $.ajax({
        method: "POST",
        url: "../API/ZawodnicyServer.aspx",
        data: { strona: t, ile: 3, filtr: zawartosc }
    })
        .done(function (msg) {

            $("#zawartosc").html(msg);

            $("tr.zawodnicyLink").click(function () {
                var id = $(this).data("id");


                $.ajax({
                    method: "POST",
                    url: "../API/SzczegolyZawodnikaServer.aspx",
                    data: { id: id }
                })
                    .done(function (msg) {

                        $("#poleSzczegolyZawodnika").html(msg);
                    });


            });

        });
}

function PodajLiczbeStron() {
    $.ajax({
        method: "POST",
        url: "../API/LiczbaStronServer.aspx",
        data: { ile: 3 }
    })
        .done(function (msg) {
           // $("#txtLiczbaStron").val(msg);
            var ls = parseInt(msg);
            for (var i = 1; i <= ls; i++) {
                $(".pagination").append('<a id="link'+ i +'" href="#">'+i+'</a>');
            }

            $("#link" + 1).addClass("active");

            $(".pagination a").click(function () {
                var t = parseInt($(this).html());
                Odswiez(t);
                $(".pagination a").removeClass("active");
                $("#link" + t).addClass("active");
            });



        });
}