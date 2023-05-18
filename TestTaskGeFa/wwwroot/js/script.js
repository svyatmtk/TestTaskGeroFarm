function displayTitles(titles) {
    var workspace = document.getElementById("workspace");

    var doneMessage = document.createElement("div");

    for (var i = 0; i < titles.length; i++) {
        var tile = document.createElement("div");
        tile.className = "tile";
        var truncatedTitle = truncateText(titles[i], 20); 
        tile.textContent = truncatedTitle;
        workspace.appendChild(tile);
    }
}

function truncateText(text, maxLength) {
    var truncatedText = text.length > maxLength ? text.substring(0, maxLength - 3) + '...' : text;
    return truncatedText;
}


