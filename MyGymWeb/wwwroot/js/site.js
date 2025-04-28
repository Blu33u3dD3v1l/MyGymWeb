document.addEventListener("DOMContentLoaded", function () {
    var trainerResults = document.getElementById("trainerResults");
    if (trainerResults && trainerResults.children.length === 0) {
        trainerResults.style.display = "none";
    }
});

// Показване на резултатите при успешен търсене
document.querySelector("form").addEventListener("submit", function (e) {
    setTimeout(function () {
        var trainerResults = document.getElementById("trainerResults");
        if (trainerResults && trainerResults.children.length > 0) {
            trainerResults.style.display = "block";
        }
    }, 500);
});