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
    },

    {
        name: "Art Exhibition",
        category: "Art",
        seats: 20
    }

];


const container = document.getElementById("eventContainer");

const filter = document.getElementById("categoryFilter");

const searchBox = document.getElementById("searchBox");


// Display Events

function displayEvents(eventList){

    container.innerHTML = "";

    eventList.forEach(function(event){

        const card = document.createElement("div");


        card.innerHTML = `

        <h3>${event.name}</h3>

        <p>Category: ${event.category}</p>

        <p>Seats: <span>${event.seats}</span></p>

        `;


        const button = document.createElement("button");

        button.innerText = "Register";


        // onclick event

        button.onclick = function(){

            if(event.seats > 0){

                event.seats--;

                displayEvents(events);

            }

            else{

                alert("No seats available");

            }

        };


        card.appendChild(button);

        container.appendChild(card);

        container.appendChild(document.createElement("hr"));

    });

}


// Initial Display

displayEvents(events);


// onchange event

filter.onchange = function(){

    let selectedCategory = filter.value;

    if(selectedCategory === "All"){

        displayEvents(events);

    }

    else{

        let filteredEvents = events.filter(function(event){

            return event.category === selectedCategory;

        });

        displayEvents(filteredEvents);

    }

};


// keydown event

searchBox.onkeydown = function(){

    setTimeout(function(){

        let text = searchBox.value.toLowerCase();

        let searchedEvents = events.filter(function(event){

            return event.name.toLowerCase().includes(text);

        });

        displayEvents(searchedEvents);

    },0);

};