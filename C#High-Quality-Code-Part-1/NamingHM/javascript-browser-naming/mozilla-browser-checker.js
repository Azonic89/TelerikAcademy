function IfMozilla() {
    var thisWindow = window,
        currentBrowser = thisWindow.navigator.appCodeName,
        isMozilla = currentBrowser === 'Mozilla';

    if (isMozilla) {
        alert('Yes');
    } else {
        alert('No');
    }
}

IfMozilla();