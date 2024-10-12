document.addEventListener("DOMContentLoaded", function () {
    var coll = document.querySelectorAll(".collapsible");
    var toggleAll = document.getElementById("toggle-all");


    


    coll.forEach(function (element) {
        if (element !== toggleAll) {
            element.addEventListener("click", function () {
                this.classList.toggle("active");
                var content = this.parentElement.nextElementSibling;

                if (content.style.display === "block") {
                    content.style.display = "none";
                } else {
                    content.style.display = "block";
                    content.style.height = "auto";
                }

                var allExpanded = Array.from(coll).every(function (collapsible) {
                    if (collapsible === toggleAll) return true;
                    var sectionContent = collapsible.parentElement.nextElementSibling;
                    return sectionContent.style.display === "block";
                });

                toggleAll.textContent = allExpanded ? "Collapse All" : "Expand All";
            });
        }
    });

    toggleAll.addEventListener("click", function () {
        var allOpen = Array.from(document.querySelectorAll(".content")).every(function (content) {
            return content.style.display === "block";
        });

        document.querySelectorAll(".content").forEach(function (content) {
            content.style.display = allOpen ? "none" : "block";
            content.style.height = allOpen ? "0" : "auto";
        });

        document.querySelectorAll(".collapsible").forEach(function (element) {
            if (element !== toggleAll) {
                element.classList.toggle("active", !allOpen);
            }
        });

        toggleAll.textContent = allOpen ? "Expand All" : "Collapse All";
    });
});
