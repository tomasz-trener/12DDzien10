
$(document).ready(function () {

    const interval = setInterval(function () {
   
        $.ajax({
            method: "POST",
            url: "../API/ZawodnicyServer.aspx",
            //  data: { name: "John", location: "Boston" }
        })
            .done(function (msg) {

                $("#zawartosc").html(msg);

            });


    }, 2000);

    setInterval();
   // clearInterval(interval); // thanks @Luca D'Amico



  


});