// Event Constructor

function Event(name, date, category, seats) {

    this.name = name;
    this.date = date;
    this.category = category;
    this.seats = seats;

}


// Add method to prototype

Event.prototype.checkAvailability = function () {

    if (this.seats > 0) {

        return "Seats Available";

    }

    else {

        return "Event Full";

    }

};


// Create Event Object

const event1 = new Event(

    "Music Festival",
    "20 June 2026",
    "Music",
    50

);


// Display Event Details

document.getElementById("eventDetails").innerHTML =

`
<p><b>Event Name:</b> ${event1.name}</p>

<p><b>Date:</b> ${event1.date}</p>

<p><b>Category:</b> ${event1.category}</p>

<p><b>Seats:</b> ${event1.seats}</p>
`;


// Call Prototype Method

document.getElementById("availability").innerHTML =

event1.checkAvailability();


// List Keys and Values using Object.entries()

let output = "";

Object.entries(event1).forEach(function([key, value]) {

    output += `<p>${key} : ${value}</p>`;

});


document.getElementById("objectEntries").innerHTML = output;