function solve(){
    return function (selector) {
        var element;
        if (selector instanceof HTMLElement) {
            element = document.getElementsByTagName(selector)[0];
        }
        else if (typeof selector == 'string') {
            element = document.getElementById(selector);
        }

        if (element) {
            var classBtns = document.getElementsByClassName('button');

            for (var i = 0; i < classBtns.length;  i += 1) {
                classBtns[i].innerHTML = 'hide';

            }

            element.addEventListener('click', function (e) {
                if(e.target.className == 'button') {
                    var clickedBtn = e.target;
                    var nextBtn = clickedBtn.nextElementSibling;

                    if (nextBtn.className == 'content' && nextBtn.nextElementSibling.className == 'button') {
                        if (nextBtn.style.display != 'none') {
                            nextBtn.style.display = 'none';
                            clickedBtn.innerHTML = 'show';
                        } else {
                            nextBtn.style.display = '';
                            clickedBtn.innerHTML = 'hide';
                        }
                    }
                }
            }, false);
            return;
        }

        throw new Error('Id Is not a string or an existing DOM element!');
    };
}