// Create an empty array

let events = [];


// Add events using push()

events.push({

    name: "Baking",
    category: "Workshop"

});

events.push({

    name: "Rock Concert",
    category: "Music"

});

events.push({

    name: "Classical Night",
    category: "Music"

});

events.push({

    name: "Painting",
    category: "Art"

});


// Display all events

let allOutput = "";

events.forEach(function(event){

    allOutput += `
    <p>
    Event Name: ${event.name}<br>
    Category: ${event.category}
    </p>
    <hr>
    `;

});

document.getElementById("allEvents").innerHTML = allOutput;


// Filter only music events

let musicEvents = events.filter(function(event){

    return event.category === "Music";

});


// Display music events

let musicOutput = "";

musicEvents.forEach(function(event){

    musicOutput += `
    <p>
    ${event.name}
    </p>
    `;

});

document.getElementById("musicEvents").innerHTML = musicOutput;


// Format display cards using map()

let cards = events.map(function(event){

    return `Workshop on ${event.name}`;

});


// Display formatted cards

let cardOutput = "";

cards.forEach(function(card){

    cardOutput += `
    <p>${card}</p>
    `;

});

document.getElementById("eventCards").innerHTML = cardOutput;