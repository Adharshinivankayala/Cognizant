$(document).ready(function(){


    // Handle Register Button Click

    $("#registerBtn").click(function(){

        alert("Registration Successful!");

    });




    // Fade Out Event Card

    $("#hideBtn").click(function(){

        $("#eventCard").fadeOut();

    });




    // Fade In Event Card

    $("#showBtn").click(function(){

        $("#eventCard").fadeIn();

    });




    // Benefit of React or Vue

    $("#benefit").text(

        "React and Vue help build reusable components and make UI updates easier."

    );

});