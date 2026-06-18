const apiURL =
"https://jsonplaceholder.typicode.com/users";

const loading =
document.getElementById("loading");

const container =
document.getElementById("eventContainer");



// Using .then() and .catch()

fetch(apiURL)

.then(function(response){

    return response.json();

})

.then(function(data){

    console.log("Using .then()");

    console.log(data);

})

.catch(function(error){

    console.log("Error :", error);

});




// Using async/await

async function fetchEvents(){

    try{

        loading.innerHTML = "Loading events...";

        const response = await fetch(apiURL);

        const data = await response.json();

        loading.innerHTML = "";

        data.slice(0,5).forEach(function(event){

            const card =
            document.createElement("div");

            card.innerHTML = `

            <h3>${event.name}</h3>

            <p>Email: ${event.email}</p>

            <p>City: ${event.address.city}</p>

            <hr>

            `;

            container.appendChild(card);

        });

    }

    catch(error){

        loading.innerHTML =
        "Failed to load events";

        console.log(error);

    }

}



fetchEvents();