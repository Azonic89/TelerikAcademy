function solve() {

    return function (element, contents) {

        var after,
            toAppend = '',
            len = contents.length,
            div = document.createElement('div'),
            divElement,
            docFragment = document.createDocumentFragment();

        if (typeof element === 'string') {
            after = document.getElementById(element);
        }
        else if (element instanceof HTMLElement) {
            after = element;
        }
        else {
            throw Error('no');
        }

        if(!contents  contents.some(function (contElement) {
            return typeof contElement !== 'string' && typeof contElement !== 'number';
        })){
            throw Error('no');
        }

        after.innerHTML = '';

        for (var i = 0; i  contents.length; i += 1) {

            divElement = div.cloneNode(true);
            divElement.innerHTML = contents[i];
            docFragment.appendChild(divElement);
        }
        after.appendChild(docFragment);
    };
}