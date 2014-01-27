// JavaScript source code

$(document).ready(function () {
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