const popup = (() => {
    const container = document.createElement('div');
    container.className += ' popup';
    container.innerHTML = 'REDIRECTING YOU MAN HAVE PATIENCE!!!...';
    container.style.display = 'none';
    document.body.appendChild(container);

    function display() {
        container.style.display = '';
    }

    function fadeOut(time) {
        container.style.opacity = container.style.opacity || 1;
        const opacityDecreaseStep = 1 / time * 10;
        decreaseOpacity(opacityDecreaseStep);
    }

    function decreaseOpacity(step) {
        const callSelf = () => {
            decreaseOpacity(step);
        };

        if (container.style.opacity <= 0) {
            return;
        }

        container.style.opacity -= step;
        setTimeout(callSelf, 1);
    }

    return {
        display,
        fadeOut
    };
})();

const redirect = ((popup) => {
    const redirectPromise = new Promise((resolve, reject) => {
        popup.display();
        popup.fadeOut(5000);
        setTimeout(function () {
            resolve('https://telerikacademy.com/');
        }, 4000);
    })
        .then((address) => window.location = address);
})(popup);