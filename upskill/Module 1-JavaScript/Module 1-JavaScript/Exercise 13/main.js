const form = document.getElementById("registerForm");

const message = document.getElementById("message");


form.addEventListener("submit", function(event){

    event.preventDefault();


    console.log("Step 1 : Form Submitted");


    let name = document.getElementById("name").value;

    let email = document.getElementById("email").value;


    console.log("Step 2 : User Input");

    console.log("Name :", name);

    console.log("Email :", email);


    const userData = {

        name: name,

        email: email

    };


    console.log("Step 3 : Payload");

    console.log(userData);


    fetch("https://jsonplaceholder.typicode.com/posts", {

        method: "POST",

        headers: {

            "Content-Type": "application/json"

        },

        body: JSON.stringify(userData)

    })


    .then(response => {

        console.log("Step 4 : Response Received");

        return response.json();

    })


    .then(data => {

        console.log("Step 5 : Success");

        console.log(data);

        message.innerHTML =

        "Registration Successful";

    })


    .catch(error => {

        console.log("Step 6 : Error");

        console.log(error);

        message.innerHTML =

        "Registration Failed";

    });

});