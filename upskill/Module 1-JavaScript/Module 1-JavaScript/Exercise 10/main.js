// Using const for array

const events = [

    {
        name: "Music Festival",
        date: "20 June 2026",
        category: "Music",
        seats: 50
    },

    {
        name: "Baking Workshop",
        date: "25 June 2026",
        category: "Workshop",
        seats: 30
    },

    {
        name: "Rock Concert",
        date: "30 June 2026",
        category: "Music",
        seats: 40
    }

];



// Function with default parameter

function displayEvent(eventList = events){

    let output = "";

    eventList.forEach(event => {

        // Destructuring

        const {
            name,
            date,
            category,
            seats
        } = event;


        output += `

        <p>

        <b>Event Name:</b> ${name}<br>

        <b>Date:</b> ${date}<br>

        <b>Category:</b> ${category}<br>

        <b>Seats:</b> ${seats}

        </p>

        <hr>

        `;

    });


    document.getElementById("allEvents").innerHTML = output;

}



// Display all events

displayEvent();



// Spread operator to clone array

let clonedEvents = [...events];



// Filter Music Events

let musicEvents = clonedEvents.filter(event =>

    event.category === "Music"

);



// Display Music Events

let musicOutput = "";

musicEvents.forEach(event => {

    const { name, date, seats } = event;

    musicOutput += `

    <p>

    ${name}<br>

    Date: ${date}<br>

    Seats: ${seats}

    </p>

    <hr>

    `;

});


document.getElementById("musicEvents").innerHTML =

musicOutput;