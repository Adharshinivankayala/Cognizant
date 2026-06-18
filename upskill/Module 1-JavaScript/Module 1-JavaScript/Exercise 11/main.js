const form = document.getElementById("registrationForm");


form.addEventListener("submit", function(event){

    // Prevent default form behavior

    event.preventDefault();


    // Clear old errors

    document.getElementById("nameError").innerHTML = "";

    document.getElementById("emailError").innerHTML = "";

    document.getElementById("eventError").innerHTML = "";

    document.getElementById("result").innerHTML = "";


    // Capture values using form.elements

    let name = form.elements["name"].value;

    let email = form.elements["email"].value;

    let selectedEvent = form.elements["event"].value;


    let valid = true;


    // Name validation

    if(name.trim() === ""){

        document.getElementById("nameError").innerHTML =
        "Name is required";

        valid = false;

    }


    // Email validation

    if(email.trim() === ""){

        document.getElementById("emailError").innerHTML =
        "Email is required";

        valid = false;

    }


    // Event validation

    if(selectedEvent === ""){

        document.getElementById("eventError").innerHTML =
        "Please select an event";

        valid = false;

    }


    // Success message

    if(valid){

        document.getElementById("result").innerHTML =

        `Registration Successful!

        Name: ${name}

        Email: ${email}

        Event: ${selectedEvent}`;

    }

});