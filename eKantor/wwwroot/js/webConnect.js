var wsUri = "ws://webtask.future-processing.com:8068/ws/currencies";
var output;
var dataJsonFromWeb;
function init() {
output = document.getElementById("output");
testWebSocket();
document.getElementById("data").focus();
 
document.getElementById("data").addEventListener('keypress', function(e) {
var key = e.which || e.keyCode;
if (key === 13) {
doSend(document.getElementById("data").value);
document.getElementById("data").value = "";
}
});
}
 
/* inicjalizacja polaczenia z serwerem oraz przypisanie funkcji do najważniejszych zdazen */
function testWebSocket() {
websocket = new WebSocket(wsUri);
websocket.onopen = function(evt) {
onOpen(evt)
};
websocket.onclose = function(evt) {
onClose(evt)
};
websocket.onmessage = function(evt) {
onMessage(evt)
};
websocket.onerror = function(evt) {
onError(evt)
};
}
 
/* funkcja wywolywana przy zestawieniu polaczenia */
function onOpen(evt) {
writeToScreen("CONNECTED");
doSend("WebSocket rocks");
}
 
/* funkcja wywolywana przy zamknieciu polaczenia */
function onClose(evt) {
writeToScreen("DISCONNECTED");
}
 
/* funkcja wywolywana przy nadejściu nowej wiadomosci */
function onMessage(evt) {
//writeToScreen('<p>Data</p>')
//writeToScreen('<p>RESPONSE: ' + evt.data + '<p>');
    var obj = JSON.parse(evt.data);
    dataJsonFromWeb = obj;
document.getElementById("test").innerHTML = obj.Items[1].Name;
}
 
/* funkcja wywolywana przy wystąpieniu bledu */
function onError(evt) {
writeToScreen('<span style="color: red;">ERROR:</span> ' + evt.data);
}
 
/* funkcja wywolywana przy probie wyslania wiadomosci */
function doSend(message) {
writeToScreen("SENT: " + message);
websocket.send(message);
}
 
/* funkcja pomocnicza wypisująca tekst */
function writeToScreen(message) {
var pre = document.createElement("p");
pre.style.wordWrap = "break-word";
pre.innerHTML = message;
output.appendChild(pre);
//document.getElementsById("data").innerHTML = message;
}
 
window.addEventListener("load", init, false);