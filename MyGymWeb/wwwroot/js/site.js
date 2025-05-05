document.addEventListener("DOMContentLoaded", function () {
    var trainerResults = document.getElementById("trainerResults");
    if (trainerResults && trainerResults.children.length === 0) {
        trainerResults.style.display = "none";
    }
});


//document.querySelector("form").addEventListener("submit", function () {
//    setTimeout(function () {
//        var trainerResults = document.getElementById("trainerResults");
//        if (trainerResults && trainerResults.children.length > 0) {
//            trainerResults.style.display = "block";
//        }
//    }, 500);
//});