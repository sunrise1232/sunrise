let priceInput = document.querySelector('.tour__price input');
let tourPrice = document.querySelector('#tour-price').value;
let priceDiv = document.querySelector('.tour__price div');

priceInput.value = tourPrice;
priceDiv.textContent = tourPrice;

function changePriceInput(selector) {
    

    let btn = document.querySelectorAll(selector);
    btn.forEach(function(item) {
        item.addEventListener("change", function() {
            let nights = document.querySelector('#nights'),
                adults = document.querySelector('#adults'),
                children = document.querySelector('#children'),
                meals = document.querySelector('#meals').checked ? 1 : 0;
                wifi = document.querySelector('#wifi').checked ? 1 : 0;
                airlines = document.querySelectorAll('input[type = "radio"');

            let airlinePrice = 0;
            
            airlines.forEach(function(item) {
                if (item.checked)
                    airlinePrice = item.previousElementSibling.value.replace(/,/, '.');
                    
                    
            });
            


            priceInput.value = tourPrice * nights.value * (Number(adults.value) + Number(children.value)*0.5) +
                0.2 * meals * tourPrice * nights.value * (Number(adults.value) + Number(children.value)*0.5) +
                0.05 * wifi * tourPrice * nights.value + 
                Number(airlinePrice) * tourPrice * (Number(adults.value) + Number(children.value)*0.5);
            priceDiv.textContent = priceInput.value;

        });
    });
    
}


changePriceInput('#children');
changePriceInput('#adults');
changePriceInput('#nights');
changePriceInput('#meals');
changePriceInput('#wifi');
changePriceInput('.tour__radio input[type = "radio"]');