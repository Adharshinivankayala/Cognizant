// Array to store events

let events = [];


// Function to add event

function addEvent(name, category, seats) {

    events.push({
        name: name,
        category: category,
        seats: seats
    });

}


// Add events

addEvent("Music Festival", "Music", 50);

addEvent("Art Exhibition", "Art", 30);

addEvent("Rock Concert", "Music", 40);


// Display all events

let allEventsDiv = document.getElementById("allEvents");

events.forEach(function(event) {

    allEventsDiv.innerHTML += `
        <p>
        Event: ${event.name}<br>
        Category: ${event.category}<br>
        Seats: ${event.seats}
        </p>
        <hr>
    `;

});


// Function to register user

function registerUser(eventName) {

    let event = events.find(function(e) {

        return e.name === eventName;

    });

    if (event && event.seats > 0) {

        event.seats--;

        return `Successfully registered for ${eventName}`;

    }

    else {

        return `Registration failed for ${eventName}`;

    }

}


// Closure to track registrations

function registrationCounter() {

    let count = 0;

    return function() {

        count++;

        return count;

    };

}


let musicRegistration = registrationCounter();

musicRegistration();

musicRegistration();

let total = musicRegistration();

document.getElementById("totalRegistrations").innerHTML =
`Music Category Registrations: ${total}`;


// Higher-order function with callback

function filterEventsByCategory(category, callback) {

    let filtered = events.filter(function(event) {

        return callback(event, category);

    });

    return filtered;

}


// Callback function

function categoryMatch(event, category) {

    return event.category === category;

}


// Filter Music Events

let musicEvents = filterEventsByCategory("Music", categoryMatch);


let filteredDiv = document.getElementById("filteredEvents");

musicEvents.forEach(function(event) {

    filteredDiv.innerHTML += `
        <p>
        ${event.name} - ${event.category}
        </p>
    `;

});


// Register user

let result = registerUser("Music Festival");

document.getElementById("registrationStatus").innerHTML = result;