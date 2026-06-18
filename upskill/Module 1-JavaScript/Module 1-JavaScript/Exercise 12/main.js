const form = document.getElementById("registrationForm");

const message = document.getElementById("message");


form.addEventListener("submit", function(event){

    event.preventDefault();


    const userData = {

        name: document.getElementById("name").value,

        email: document.getElementById("email").value

    };


    message.innerHTML = "Sending data...";


    // Simulate delay using setTimeout

    setTimeout(() => {

        fetch("https://jsonplaceholder.typicode.com/posts", {

            method: "POST",

            headers: {

                "Content-Type": "application/json"

            },

            body: JSON.stringify(userData)

        })


        .then(response => {

            if(response.ok){

                return response.json();

            }

            else{

                throw new Error("Submission Failed");

            }

        })


        .then(data => {

            console.log(data);

            message.innerHTML =

            "Registration Successful!";

        })


        .catch(error => {

            console.log(error);

            message.innerHTML =

            "Registration Failed!";

        });


    }, 2000);


});