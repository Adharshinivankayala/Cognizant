const events = [

    {
        name: "Music Festival",
        date: "2026-06-20",
        seats: 50
    },

    {
        name: "Food Carnival",
        date: "2024-01-10",
        seats: 25
    },

    {
        name: "Art Exhibition",
        date: "2026-07-15",
        seats: 0
    }

];

const eventList = document.getElementById("eventList");

const today = new Date();

events.forEach(function(event){

    let eventDate = new Date(event.date);

    // if-else to display only upcoming events with seats

    if(eventDate > today && event.seats > 0){

        eventList.innerHTML += `
            <p>
                <b>${event.name}</b><br>
                Date: ${event.date}<br>
                Seats Available: ${event.seats}
            </p>
            <hr>
        `;

    }

    else{

        console.log(`${event.name} is hidden`);

    }

});


// try-catch for registration

try{

    let registrationSeats = 0;

    if(registrationSeats <= 0){

        throw new Error("Registration Failed! No seats available.");

    }

    document.getElementById("message").innerHTML =
    "Registration Successful";

}

catch(error){

    document.getElementById("message").innerHTML =
    error.message;

}