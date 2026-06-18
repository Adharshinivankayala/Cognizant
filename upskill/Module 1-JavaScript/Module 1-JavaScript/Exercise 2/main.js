const eventName = "Community Music Festival";
const eventDate = "20 June 2026";

let seats = 50;

let eventInfo = `Event: ${eventName} | Date: ${eventDate}`;

document.getElementById("eventInfo").innerHTML = eventInfo;

document.getElementById("initialSeats").innerHTML =
    `Available Seats: ${seats}`;

seats--;

document.getElementById("afterRegistration").innerHTML =
    `After Registration: ${seats} seats available`;

seats++;

document.getElementById("afterCancellation").innerHTML =
    `After Cancellation: ${seats} seats available`;