// JavaScript source code

$(document).ready(function () {

    $('.progrecss').attr('data-progrecss', 100);

    $('select').on('change', function (event) {
        var color = $('.color').val(),
         position = $('.position').val();
        $('#progrecss')[0].className = 'progrecss lead ' + color + ' ' + position;
    });

    $("#loading").delay(1500).animate({
        opacity: 0.0
    }, 500, function () {
        // Animation complete.
    });

    $("#loginForm").bind("blur focus", function () {
        if ($(this).val() == "") {
            $(this).val("Username");
        } else if ($(this).val() == "Username") {
            $(this).val("");
        }
    });

    $(".search_field").bind("blur focus", function () {
        if ($(this).val() == "") {
            $(this).val("Enter your search..");
        } else if ($(this).val() == "Enter your search..") {
            $(this).val("");
        }
    });

});