console.log("JS carregou");

const API_URL = "https://traveltips-api.azurewebsites.net/api/traveltips";
let allTips = [];

fetch(API_URL)
    .then(response => response.json())
    .then(data => {
        allTips = data;
        renderTips(allTips);
    })
    .catch(error => {
        console.error("Erro no fetch:", error);
    });

function renderTips(tips) {
    const container = document.getElementById("cards");
    container.innerHTML = "";

    tips.forEach(tip => {
        const card = document.createElement("div");
        card.className = "card";

        card.innerHTML = `
            <img src="${tip.imageUrl}" alt="${tip.city}">
            <h3>${tip.city}</h3>
            <p>${tip.description}</p>
            <a href="${tip.airbnbLink}" target="_blank">
                Ver no Airbnb
            </a>
        `;

        container.appendChild(card);
    });
}

function filterTips(type) {
    if (type === "all") {
        renderTips(allTips);
        return;
    }

    const filtered = allTips.filter(tip => tip.tripType === type);
    renderTips(filtered);
}

