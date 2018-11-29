// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $('input').on('input',function (e) {
        var first_name = $('#first-name').val();
        var last_name = $('#last-name').val();
        var email = $('#email').val();
        var phone_number = $('#phone-number').val();
        var password = $('#password').val();
        var card_number = $('#card-number').val();

        $(".text-danger").remove();

        if (first_name.length < 1) {
            $('#first-name').after('<span class="text-danger">This field is required</span>');
        }
        if (last_name.length < 1) {
            $('#last-name').after('<span class="text-danger">This field is required</span>');
        }
        if (email.length < 1) {
            $('#email').after('<span class="text-danger">This field is required</span>');
        } else {
            var regEx = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            var validEmail = regEx.test(email);
            if (!validEmail) {
                $('#email').after('<span class="text-danger">Enter a valid email</span>');
            }
        }
        if (phone_number.length < 1) {
            $('#phone-number').after('<span class="text-danger">This field is required</span>');
        } else {
            var regEx = /^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$/;
            var validPhoneNumber = regEx.test(phone_number);
            if (!validPhoneNumber) {
                $('#phone-number').after('<span class="text-danger">Enter a valid phone number</span>');
            }
        }
        if (card_number.length < 1) {
            $('#card-number').after('<span class="text-danger">This field is required</span>');
        } else {
            var regEx = /^(\d{4}[- ]){3}\d{4}|\d{16}$/;
            var validcardNumber = regEx.test(card_number);
            if (!validcardNumber) {
                $('#card-number').after('<span class="text-danger">Enter a valid card number</span>');
            }
        }
        if (password.length < 8) {
            $('#password').after('<span class="text-danger">Password must be at least 8 characters long</span>');
        }
    });

});