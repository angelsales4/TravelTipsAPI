console.log("JS carregou");

fetch("https://traveltips-api.azurewebsites.net/api/traveltips")
  .then(response => response.json())
  .then(data => {
    const container = document.getElementById("cards");

    data.forEach(tip => {
      const card = document.createElement("div");
      card.className = "card";

      card.innerHTML = `
        <img src="${tip.imageUrl}" alt="${tip.city}">
        <h3>${tip.city}, ${tip.country}</h3>
        <p>${tip.description}</p>
        <a href="${tip.airbnbLink}" target="_blank">Ver no Airbnb</a>
      `;

      container.appendChild(card);
    });
  })
  .catch(error => {
    console.error("Erro no fetch:", error);
  });
