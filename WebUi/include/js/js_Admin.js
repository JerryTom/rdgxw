function toggleMenu(key) {
    document.getElementById("menu_" + key).style.display = "block";
    for(var k in headers) {
        if (id == key) continue;
        document.getElementById("menu_" + k).style.display = "none";
    }
}