// Event Data

const events = [

    {
        name: "Music Festival",
        category: "Music",
        seats: 50
    },

    {
        name: "Baking Workshop",
        category: "Workshop",
        seats: 30
    }

];


// Access DOM using querySelector()

const container = document.querySelector(".eventsContainer");


// Display Events

events.forEach(function(event) {

    // Create Card

    const card = document.createElement("div");

    // Create Heading

    const title = document.createElement("h3");

    title.textContent = event.name;


    // Category

    const category = document.createElement("p");

    category.textContent =
    "Category: " + event.category;


    // Seats

    const seats = document.createElement("p");

    seats.textContent =
    "Available Seats: " + event.seats;


    // Register Button

    const registerBtn =
    document.createElement("button");

    registerBtn.textContent =
    "Register";


    // Cancel Button

    const cancelBtn =
    document.createElement("button");

    cancelBtn.textContent =
    "Cancel";


    // Register Event

    registerBtn.onclick = function() {

        if(event.seats > 0){

            event.seats--;

            seats.textContent =
            "Available Seats: " + event.seats;

        }

        else{

            alert("No seats available");

        }

    };


    // Cancel Event

    cancelBtn.onclick = function(){

        event.seats++;

        seats.textContent =
        "Available Seats: " + event.seats;

    };


    // Append Elements

    card.appendChild(title);

    card.appendChild(category);

    card.appendChild(seats);

    card.appendChild(registerBtn);

    card.appendChild(cancelBtn);


    container.appendChild(card);

});